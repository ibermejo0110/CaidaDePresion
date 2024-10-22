using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;
namespace PuertoSerie
{
    public partial class frmSimulador : Form
    {
        PuertoSerial puertoSerial;
        public frmSimulador()
        {
            InitializeComponent();
            puertoSerial = new PuertoSerial();
        }
        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeltaP.Text))
            {
                MessageBox.Show("Delta p debe ser mayor que 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            puertoSerial.WriteData(txtDeltaP.Text);
           // this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puertoSerial.OpenDevice(cmbSerialPort.Text);
            txtDeltaP.Text = string.Empty;
        }

        private void frmSimulador_Load(object sender, EventArgs e)
        {
            ControlForm.FillCombo(puertoSerial.StopBits, cmbStopBits);
            ControlForm.FillCombo(puertoSerial.Parities, cmbParity);
            ControlForm.FillCombo(puertoSerial.Serialports, cmbSerialPort); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (!puertoSerial.SerialPort.IsOpen)
            {
                MessageBox.Show("El dispositivo no esta abierto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            puertoSerial.CloseDevice();
            this.Close();
        }
    }
}
