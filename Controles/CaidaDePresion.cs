using HSG.Numerics;
using System.Data;
namespace Controles
{
    public abstract class CaidaDePresion
    {
        public static double[]? PrimerTermino;
        public static double[]? ReynoldEnjambre;
        public static double[]? SegundoTermino;
        public static double[]? TercerTermino;
        public static double[]? FuncionObjetivo;
        public static double[]? DiametroBurbuja;
        public static DataTable? tblOtrosResultados;

        public static double Holdup { get; set; }

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
        public static double Usg { get; set; }

        static Fsolve.FunctionToSolve FuncUb { get { return new(FuncToSolveUb); } }

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
            // Give number of variables
            int unknownVariables = 1;
            double[] xGuess1 = { 0.0 };                   // Give a guess value       
            (double[] soln1, double[] fx1, string solutionCode1) = Fsolve.Fsolver(funcUb, 
                                                                                  unknownVariables,
                                                                                  xGuess1, 
                                                                                  tol);
            return soln1[0];
        }
        
        static void Inicializar()
        {
            tblOtrosResultados = new DataTable();
            tblOtrosResultados.Columns.Add("PrimerTermino");
            tblOtrosResultados.Columns.Add("ReynoldEnjambre");
            tblOtrosResultados.Columns.Add("SegundoTermino");
            tblOtrosResultados.Columns.Add("TercerTermino");
            tblOtrosResultados.Columns.Add("FuncionObjetivo");
            tblOtrosResultados.Columns.Add("DiametroBurbuja");
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
            return db * Usb * rosl * (1 - Holdup) / miusl; //% Re del enjambre//              
        }
        static double GetTercerTerminoObjetivo(double Usb)
        {
            return Math.Pow((Usb * rosl * (1 - Holdup) / miusl), 0.687);// % Tercer término de la función objetivo                
        }
        static double DerivadaFunciónObjetivo( double p1,double y,double db,double z)
        {
            return 0.10305 * Math.Sqrt(p1) * Math.Pow(y, -0.5) * Math.Pow(db, -0.313) * (z / 2) - 1;
        }
        static double GetDiametroBurbuja(double Ut,double Usb ,ref double  tol)
        {
            Inicializar();
            double db = 0.001;//Diametro de burbuja asumido
            tol = 0.0001;//Tolerancia inicial            
            // double Resb = 0;
            while (tol > 1e-9)
            {
                double p1 = GetPrimerTerminoObjetivo(Ut);//% Primer término de la función objetivo
                double Resb = GetReEnjambre(db, Usb);//% Re del enjambre//              
                double y = GetSegundoTerminoObjetivo(Resb); //% Segundo término de la función objetivo
                double z = GetTercerTerminoObjetivo(Usb);// % Tercer término de la función objetivo                
                double fdb = Math.Sqrt((p1 * y)) - db; //% Función objetivo                
                double ddb = DerivadaFunciónObjetivo(p1, y, db, z);//% Derivada de la función objetivo
                double db1 = db - fdb / ddb;// % Nuevo diametro                
                DataRow row= tblOtrosResultados.NewRow();
                row["PrimerTermino"]=p1;
                row["ReynoldEnjambre"]=Resb;
                row["SegundoTermino"]=y;
                row["TercerTermino"]=z;
                row["FuncionObjetivo"]=fdb;
                row["DiametroBurbuja"]=db1;
                tblOtrosResultados.Rows.Add(row);   
                tol = Math.Abs(db1 - db);// % Tolerancia
                db = db1;
            }
            return db; 
        }
        static double FraccionOcupadaParticula(double csl,double rop,double row)
        {
            return 1 / (1 + ((1 / csl) - 1) * (rop / row));
        }
        static double FraccionOcupadaLiquido(double fip)
        {
            return 1 - fip;
        }
        static double DensidadSlurry(double row,double fil,double rop, double fip)
        {
            return    row* fil +rop * fip;
        }
        static double ViscosidadSlurry(double miuw,double fip)
        {
            return miuw * Math.Pow(1 - fip, -2.5);
        }
        static double DensidadAire(double pmg, double pent, double t )
        {
            return pmg *pent / (0.082 * t);
        }
        static double AirHoldUp(double  deltap,double rosl,double g,double dl) 
        { 
            return 1 - (deltap / (rosl * g * dl));
        }
        static double VelocidadRelativaDesplazamientoBurbujaLiquido(double jg, double  holdup,double  jsl )
        {
            return jg / holdup + jsl / (1 - holdup);
        }
        static double VelocidadTerminalGas(double usg,double holdup,double m)
        {
            return usg * Math.Pow(1 - holdup, (1 - m));
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
        public static double CalcularValorReynold(double deltap, double Jg,double jsl )
        {
            if (Jg == 0)
            {
                Jg = 0.0204;
            }
            deltap *=  6894.71;
            Jg *=0.01;
            jsl *= 0.01;

            //double fip = 1 / (1 + ((1 / Cs1) - 1) * (rop / row));
            double fip = FraccionOcupadaParticula(Cs1,rop,row);

            //fraccion ocupada por el liquido            
            double fil = FraccionOcupadaLiquido(fip);

            //Densidad del slurry (kg/m^3)
            rosl = DensidadSlurry(row, fil, rop, fip); 

            //Viscosidad del slurry (kg/m-s)
            miusl = ViscosidadSlurry(miuw, fip); 

            //Densidad del aire (kg/m^3)            
            rog = DensidadAire(pmg, pent, T);

            //Air hold up            
            Holdup = AirHoldUp(deltap, rosl, g, dl);

            //velocidad relativa de desplazamiento de la burbuja en el liquido (m/s)
            Usg = VelocidadRelativaDesplazamientoBurbujaLiquido(Jg, Holdup, jsl);

            //velocidad terminal del gas (m/s)
            double Ut = VelocidadTerminalGas(Usg, Holdup, m);
            
            double tol = 0;
            db = GetDiametroBurbuja(Ut, Usg, ref tol);    
             
            ub = GetUb(FuncUb, tol);

            return db * rosl * ub  / miusl;       
        }
    }
}
  