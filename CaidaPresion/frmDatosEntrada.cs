using Controles;
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

namespace CaidaPresion
{
    public partial class frmDatosEntrada : Form
    {
        DataSet ds;

        public EspumanteRepository? EspumanteRepository { get; set; }
        public ConcentracionRepository? ConcentracionRepository { get; set; }
        public OtrosResultadosRepository? OtrosResultadosRepository { get; set; }
        public ResultadoRepository? ResultadoRepository { get; set; }
        DataTable? tableResultados { get; set; }
        DataTable? tableOtrosResultados { get; set; }
        Excel? excel;
        public frmDatosEntrada()
        {
            InitializeComponent();
        }

        private void frmDatosEntrada_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            string[] arr = { "id", "nombre" };
            ControlForm.FillCombo(EspumanteRepository.GetDataTable(), arr, cmbEspumante);
            excel = new Excel();

        }

        private void dgResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgResultados.Rows[e.RowIndex].Cells["id"].Value.ToString());
            tableOtrosResultados = OtrosResultadosRepository.GetDataTable(id);
            tableOtrosResultados.TableName = "Otros resultados";
            dgOtrosResultados.DataSource = tableOtrosResultados;
        }

        private void cmbEspumante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] arr = { "concentracion_id", "concentracion" };
                int.TryParse(cmbEspumante.SelectedValue != null ? cmbEspumante.SelectedValue.ToString() : "", out int espumante);
                DataTable tblConcentracion = ConcentracionRepository.GetDataTable(espumante);
                ControlForm.FillCombo(tblConcentracion, arr, cmbConcentracion);

            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbConcentracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(cmbEspumante.SelectedValue != null ? cmbEspumante.SelectedValue.ToString() : "", out int espumante);
                int.TryParse(cmbConcentracion.SelectedValue != null ? cmbConcentracion.SelectedValue.ToString() : "", out int concentracion);
                ds.Tables.Clear();
                tableResultados = ResultadoRepository.GetDataTableEspumateConcentracion(espumante, concentracion);
                tableResultados.TableName = "Resultados";

                dgResultados.DataSource = tableResultados;
                tableOtrosResultados = OtrosResultadosRepository.GetDataTable(0);
                dgOtrosResultados.DataSource = tableOtrosResultados;
            }
            catch (Exception ex)
            {

                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableResultados == null || tableOtrosResultados == null)
                {
                    ControlForm.GetMessage("Las tablas deben contener valores", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tableResultados.DataSet == null || tableOtrosResultados.DataSet == null)
                {
                    ds.Tables.Add(tableResultados);
                    ds.Tables.Add(tableOtrosResultados);
                }
                else
                {
                    ds = tableResultados.DataSet;
                }
                this.Cursor = Cursors.WaitCursor;
                excel.ExportarDatos(ds);
            }
            catch (Exception ex)
            {
                ControlForm.GetMessage(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
