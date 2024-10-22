using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;
namespace CaidaPresion
{
    public partial class frmCalibracion : Form
    {
       PuertoSerial puertoSerial;
        public string Dato { get; set; }
        public frmCalibracion()
        {
            InitializeComponent();
            puertoSerial = new PuertoSerial();
          ControlForm .Form = this;
            ControlForm.textBox = txtDeltaP;
            Dato = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ControlForm.FillCombo( puertoSerial.Serialports, cmbSerialPort);
            if (cmbSerialPort.Items.Count == 0)
            {
                MessageBox.Show("No hay Dispositivos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                puertoSerial.OpenDevice(cmbSerialPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (!puertoSerial.SerialPort.IsOpen)
            {
                MessageBox.Show("El dispositivo no esta abierto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            puertoSerial.CloseDevice();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                CxProgrammer.Ole.ExtreaerDatos("C:\\Users\\indir\\OneDrive\\Documentos\\Bkp PLc.cxp");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
