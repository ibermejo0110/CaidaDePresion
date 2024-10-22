using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CaidaPresion
{
    public partial class frmEspumante : Form
    {
        DataTable dtEspumante;
        DataTable dtConcentracion;
        Dictionary<string, object> colection;
        int Espumante_id;
        public EspumanteRepository EspumanteRepository { get; set; }
        public EspumanteConcentracionRepository EspumanteConcentracionRepository { get; set; }
        public ConcentracionRepository ConcentracionRepository { get; set; }
        public frmEspumante()
        {
            InitializeComponent();
        }
        void nuevo()
        {
            Espumante_id = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
            dtEspumante = EspumanteRepository.GetDataTable();
            dtConcentracion =ConcentracionRepository.GetDataTable(0);
            dgConcentracion.DataSource = dtConcentracion;
            dgEspumante.DataSource = dtEspumante;

        }
        private void frmEspumante_Load(object sender, EventArgs e)
        {
            nuevo();
        }

        private void dgEspumante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Espumante_id = int.Parse(dgEspumante.Rows[e.RowIndex].Cells["id"].Value.ToString());
                txtNombre.Text = dgEspumante.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtDescripcion.Text = dgEspumante.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                dtConcentracion = ConcentracionRepository.GetDataTable(Espumante_id);
                dgConcentracion.DataSource = dtConcentracion;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    Controles.ControlForm.GetMessage("El campo nombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nuevo();
                    return;
                }
                colection = new Dictionary<string, object>
                {
                    { "nombre", txtNombre.Text },
                    {"descripcion",txtDescripcion.Text }
                };
                if (Espumante_id == 0)
                {
                    EspumanteRepository.Save(colection, ref Espumante_id);
                    DataTable dt = ConcentracionRepository.GetDataTable();
                    foreach (DataRow row in dt.Rows)
                    {
                        colection = new Dictionary<string, object>
                        {
                            { "espumante_id", Espumante_id },
                            {"concentracion_id",row["id"].ToString() }
                        };

                        EspumanteConcentracionRepository.Save(colection, ref Espumante_id);
                    }
                    Controles.ControlForm.GetMessage("El registro se ha guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    EspumanteRepository.Update(colection, Espumante_id);
                    Controles.ControlForm.GetMessage("El registro se ha actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Controles.ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            nuevo();
        }

        private void btnValoresIniciales_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea eliminar este registro", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    EspumanteRepository.Delete(Espumante_id);
                    Controles.ControlForm.GetMessage("El registro se ha eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Controles.ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            nuevo();
        }

        private void btnCalibrar_Click(object sender, EventArgs e)
        {
            this .Close();
        }
    }
}
