using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Utilities
{
    public abstract class Control
    {
        public static Form Form;
        public static TextBox textBox;
        static string Dato;
        public static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort=(SerialPort)sender;
            Thread.Sleep(500);
            Dato = serialPort.ReadExisting()+";";
      //      serialPort.Close();
            Form .Invoke(new EventHandler(DisplayText));
        }
        private static void DisplayText(object sender, EventArgs e)
        {
            textBox.AppendText(Dato);
            Thread.Sleep(1000);
         //   Form.Close();
        }
        public static void FillCombo(ComboBox comboBox, Array arr)
        {
            foreach (var value in arr)
            {
                comboBox.Items.Add(value);
            }
        }
    }
}
