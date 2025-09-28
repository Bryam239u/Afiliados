using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afiliados
{
    public partial class FRMAfiliados : Form
    {
        List<string> columnas;
        public FRMAfiliados()
        {
            InitializeComponent();
            columnas = new List<string>();
            columnas.Add("ID");
            columnas.Add("Entidad");
            columnas.Add("Municipio");
            columnas.Add("Nombre");
            columnas.Add("Fecha Afiliacion");
            columnas.Add("Estatus");
        }

        private void salirTSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTSM_Click(object sender, EventArgs e)
        {
            dGVAfiliados.Rows.Clear();
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofdExcel.FileName;
                tBArchivo.Text = ofdExcel.SafeFileName;
                CargarExcel(archivo);
            }
        }

        private void CargarExcel(string path)
        {
            try
            {
                DataTable dt = new DataTable();
                ExcelPackage.License.SetNonCommercialPersonal("Jose Luis Mota Espeleta");

                using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
                {
                    if (package.Workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                        return; //En caso que no haya hojas
                    }

                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    // Leer los encabezados de columna
                    foreach (var col in columnas)
                    {
                        dt.Columns.Add(col);
                    }

                    // Leer las filas de datos
                    int rowCount = 0;
                    for (int i = 1; i < worksheet.Dimension.End.Row; i++)
                    {
                       rowCount = rowCount + 1;
                    }
                    rowCount = rowCount + 3;
                    for (int i = 2; i < rowCount-1; i++)
                    {
                        DataRow row = dt.NewRow();
                        for (int j = 1; j < dt.Columns.Count + 1; j++)
                        {
                            row[j - 1] = worksheet.Cells[i, j].Text;
                        }
                        dt.Rows.Add(row);
                    }
                }

                // Mostrar los datos en el DataGridView
                dGVAfiliados.Rows.Add(dt.Rows.Count);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        dGVAfiliados.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                    }
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void nuevoTSM_Click(object sender, EventArgs e)
        {
            dGVAfiliados.Rows.Clear();
        }
    }
}
