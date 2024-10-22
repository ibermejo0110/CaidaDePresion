using HSG.Numerics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Utilities
{
    public abstract class CaidaDePresion
    {
        public static double holdup { get; set; }
        public static double[]? PrimerTermino;
        public static double[]? ReynoldEnjambre;
        public static double[]? SegundoTermino;
        public static double[]? TercerTermino;
        public static double[]? FuncionObjetivo;
        public static double[]? DiametroBurbuja;
        public static double db { get; set; }
        
        public static double ub { get; set; }
        
        public static double  rosl { get; set; }

        public static double rog { get; set; }
        
        public static double miusl {  get; set; }
        
        public static int m { get { return 3; } }

        //Densidad de la particula (kg/m3)
        public static double rop { get { return 1.230e3; } }

        // Presion de entrada (atm)
        public static double pent { get { return 1; } }

        //Densidad del agua (kg/m3)
        public  static double row { get { return 999; } }      

        //porcentaje p/p del slurry (%p/p)
        public static  double Cs1 { get { return 0.025; } }

        //deltha de L, medicion del holdup (m)
        public static  double dl { get { return 0.51; } }
        
        //Temperatura (K)
        public static  double T { get { return 298.15; } }        
       
        //viscosidad del agua
        public static  double miuw { get { return 0.00105; } }

        //peso molecular del gas
        public static  double pmg { get { return 28.964; } }

        // gravedad (kg/m^2)
        public static  double g { get { return 9.81; } }

        //Diametro de la particula (m)
        public static   double dp { get { return 0.000038; } }

        // Give number of variables
        static int unknownVariables = 1;
        public static bool EsEvaluada(string sDeltaP, string sVelLinealGas, string sJsl, ref string msg)
        {
            double.TryParse(sDeltaP, out double DeltaP);
            double.TryParse(sVelLinealGas, out double VelLinealGas);
            double.TryParse(sJsl, out double Jsl);
            if (DeltaP == 0)
            {
                msg = "Delta p debe ser mayor que 0";
                return false;
            }
            if (VelLinealGas == 0)
            {
                msg = "velocidad lineal gas debe ser mayor que 0";
                return false;
            }
            if (Jsl == 0)
            {
                msg = "Jsl debe ser mayor que 0";
                return false;
            }
            return true;
        }
        static void FuncToSolveUb(int n, IntPtr x, IntPtr fx)
        {
            double[] x1 = Fsolve.MakeArray(n, x);   // Make an array for 'x' values from its Pointer
            double[] fx1 = Fsolve.MakeArray(n, fx); // Make an array for 'fx' equation/function values from its Pointer
            fx1[0]= x1[0] - g * Math.Pow(db, 2) *(rosl - rog) /(18 * miusl * (1 + 0.15 *(Math.Pow((rosl  * db  * x1[0] / miusl), 0.687))));// Write equations/functions as f(x) = 0, here it becomes x - 1 = 0
            Fsolve.CopyArray(n, fx1, fx);                // Copy fx1 array values to fx Pointer                                                         
        }
        
        static double GetUb(Fsolve.FunctionToSolve funcUb, double tol)
        {       
            double[] xGuess1 = { 0.0 };                   // Give a guess value       
            (double[] soln1, double[] fx1, string solutionCode1) = Fsolve.Fsolver(funcUb, 
                                                                                  unknownVariables,
                                                                                  xGuess1, 
                                                                                  tol);
            return soln1[0];
        }
        
        static void Inicializar()
        {
            PrimerTermino = new double[1];
            ReynoldEnjambre = new double[1];
            SegundoTermino = new double[1];
            TercerTermino = new double[1];
            FuncionObjetivo = new double[1];
            DiametroBurbuja = new double[1];
        }
        static  void LlenarArray( double valor,int i,int j,ref double[] arr)
        {
            arr[i] = valor;
            Array.Resize(ref arr, j);
        }
        static double GetPrimerTerminoObjetivo(double Ut)
        {
            return  (18 * miusl * Ut) / (g * (rosl - rog)); //% Primer término de la función objetivo
        }
        static double GetSegundoTerminoObjetivo(double Resb)
        {
            return 1 + 0.15 * Math.Pow(Resb, 0.687); //% Segundo término de la función objetivo
        }
        static double GetReEnjambre(double db,double Usb )
        {
            return db * Usb * rosl * (1 - holdup) / miusl; //% Re del enjambre//              
        }
        static double GetTercerTerminoObjetivo(double Usb)
        {
            return Math.Pow((Usb * rosl * (1 - holdup) / miusl), 0.687);// % Tercer término de la función objetivo                
        }
        static double GetDiametroBurbuja(double Ut,double Usb ,ref double  tol)
        {
            Inicializar();
            //Diametro de burbuja asumido
            double db = 0.001;

            //Tolerancia inicial
            tol = 0.0001;
            
            // double Resb = 0;
            int i = 0;
            int j = 1;
            while (tol > 1e-9)
            {
                j++;
                double p1 = GetPrimerTerminoObjetivo(Ut);// (18 * miusl * Ut) / (g * (rosl - rog)); //% Primer término de la función objetivo
                double Resb = GetReEnjambre(db, Usb);// db0 * Usb * rosl * (1 - holdup) / miusl; //% Re del enjambre//              
                double y = GetSegundoTerminoObjetivo(Resb);// 1 + 0.15 * Math.Pow(Resb, 0.687); //% Segundo término de la función objetivo
                double z = GetTercerTerminoObjetivo(Usb);// Math.Pow((Usb * rosl * (1 - holdup) / miusl), 0.687);// % Tercer término de la función objetivo                
                double fdb = Math.Sqrt((p1 * y)) - db; //% Función objetivo                
                double ddb = 0.10305 * Math.Sqrt(p1) * Math.Pow(y, -0.5) * Math.Pow(db, -0.313) * (z / 2) - 1; //% Derivada de la función objetivo
                double db1 = db - fdb / ddb;// % Nuevo diametro
                LlenarArray(fdb, i, j, ref FuncionObjetivo);
                LlenarArray(y, i, j, ref SegundoTermino);
                LlenarArray(z, i, j, ref TercerTermino);
                LlenarArray(db1, i, j, ref DiametroBurbuja);
                LlenarArray(p1, i, j, ref PrimerTermino);
                LlenarArray(Resb, i, j, ref ReynoldEnjambre);
                tol = Math.Abs(db1 - db);// % Tolerancia
                i++;
                db = db1;
            }
            return db; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deltap">
        /// Caida de presion
        /// </param>
        /// <param name="Jg">
        /// velocidad lineal del gas (m/s)
        /// </param>
        /// <returns></returns>
        public static  double CalcularValorReynold(double deltap, double Jg,double jsl )
        {
            if (Jg == 0)
            {
                Jg = 0.0204;
            }           

            //Fraccion ocupada por la particula
            double fip = 1 / (1 + ((1 / Cs1) - 1) * (rop / row));
            
            //fraccion ocupada por el liquido
            double fil = 1 - fip;
            
            //Densidad del slurry (kg/m^3)
             rosl = row * fil + rop * fip;
            
            //Viscosidad del slurry (kg/m-s)
             miusl = miuw * Math.Pow(1 - fip, -2.5);
            
            //Densidad del aire (kg/m^3)            
             rog = pmg * pent / (0.082 * T);

             //Air hold up            
             holdup = 1 - (deltap / (rosl * g * dl));

             //velocidad relativa de desplazamiento de la burbuja en el liquido (m/s)
             double Usb = Jg / holdup  + jsl / (1 - holdup);

             // velocidad terminal del gas (m/s)
             double Ut =  Usb * Math.Pow(1 - holdup, (1 - m));
            
             double tol = 0;
             db = GetDiametroBurbuja(Ut, Usb, ref tol);    
             

             // Wrap function so it can be called
             Fsolve.FunctionToSolve funcUb = new(FuncToSolveUb);        

             ub = GetUb(funcUb, tol);
             return db * rosl * ub  / miusl;       
        }
    }
}
  