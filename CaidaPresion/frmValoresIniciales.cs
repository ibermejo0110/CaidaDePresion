using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaidaPresion
{
    public partial class frmValoresIniciales : Form
    {
        public DataTable? dt { get; set; }
        
        public frmValoresIniciales()
        {
            InitializeComponent();
        }

        private void frmValoresIniciales_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }
    }
}
