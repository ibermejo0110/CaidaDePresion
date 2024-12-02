using System.Data;
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
