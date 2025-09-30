using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace Afiliados
{
    public partial class FRMAfiliados : Form
    {
        List<string> columnas;
        HashSet<string> munis;
        DataTable dt;
        public FRMAfiliados()
        {
            InitializeComponent();
            columnas = new List<string> { "id", "Entidad", "Municipio", "Nombre", "Fecha Afiliacion", "Estatus" };
            munis = new HashSet<string>();
            dt = new DataTable();
            foreach (var col in columnas)
            {
                dt.Columns.Add(col);
            }
        }

        private void salirTSM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTSM_Click(object sender, EventArgs e)
        {
            nuevoTSM_Click(sender, e);
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tBArchivo.Text = ofdExcel.SafeFileName;
                    string archivo = ofdExcel.FileName;
                    Thread t1 = new Thread(() => CargarExcel(archivo));
                    t1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error cargando el archivo");
                }
            }
        }

        private void CargarExcel(String path)
        {
            try
            {
                ExcelPackage.License.SetNonCommercialPersonal("Bryam Jaramillo");
                using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
                {

                    if (package.Workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                        return;
                    }

                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowCount = 0;
                    for (int i = 2; i < worksheet.Dimension.End.Row; i++)
                    {
                        rowCount = rowCount + 1;
                        
                    }
                    
                    rowCount = rowCount + 3;
                    for (int i = 2; i < rowCount; i++)
                    {
                        DataRow row = dt.NewRow();
                        munis.Add("TODOS");
                        string muni = worksheet.Cells[i, 3].Text;
                        if (!string.IsNullOrEmpty(muni))
                        {
                            munis.Add(muni);
                        }
                        else
                        {
                            munis.Add("NO ESPECIFICADO");
                        }

                        for (int j = 1; j < dt.Columns.Count + 1; j++)
                        {
                            row[j - 1] = worksheet.Cells[i, j].Text;
                        }
                        dt.Rows.Add(row);
                    }

                    cBMunicipio.Invoke((MethodInvoker)delegate
                    {
                        cBMunicipio.DataSource = munis.ToList();
                    });

                    dGVAfiliados.Invoke((MethodInvoker)delegate
                    {
                        dGVAfiliados.DataSource = null;
                        dGVAfiliados.Columns.Clear();
                        dGVAfiliados.AutoGenerateColumns = true;
                        dGVAfiliados.DataSource = dt;
                        dGVAfiliados.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        lbAf.Text = dGVAfiliados.Rows.Count.ToString();
                    });

                    this.Invoke((MethodInvoker)delegate
                    {
                        tBEstado.Text = dGVAfiliados.Rows[1].Cells[1].Value.ToString();
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error al cargar el Excel");
            }
        }

        private void nuevoTSM_Click(object sender, EventArgs e)
        {
            dGVAfiliados.DataSource = null;
            dGVAfiliados.Rows.Clear();
            dGVAfiliados.DataSource = dt;
            dt.Rows.Clear();
            dGVAfiliados.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cBMunicipio.DataSource = new List<string>() { "." };
            tBEstado.Text = "";
            tBArchivo.Text = "";
        }

        private void chBFecha_CheckedChanged(object sender, EventArgs e)
        {
            dGVAfiliados.DataSource = dt;
            DataView vista = dt.DefaultView;
            if (chBFecha.Checked == true)
            {
                panelFechas.Visible = true;
            }
            else
            {
                panelFechas.Visible = false;
                vista.RowFilter = "";
            }
        }

        private void cBMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGVAfiliados.DataSource = dt;
            DataView vista = dt.DefaultView;
            if (cBMunicipio.SelectedItem == "TODOS")
            {
                vista.RowFilter = "";
            }
            else if(cBMunicipio.SelectedItem == "NO ESPECIFICADO")
            {
                vista.RowFilter = $"Municipio = '{""}'";
            }
            else
            {
                vista.RowFilter = $"Municipio = '{cBMunicipio.SelectedItem.ToString()}'";
            }
            
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime inicio = dTPInicio.Value.Date;
            DateTime fin = dTPFinal.Value.Date;

            dGVAfiliados.DataSource = dt;
            DataView vista = dt.DefaultView;

            string colFecha = "Fecha Afiliacion";

            try
            {
                string filtro = $"CONVERT([{colFecha}], 'System.DateTime') >= #{inicio:MM/dd/yyyy}# AND " + 
                                $"CONVERT([{colFecha}], 'System.DateTime') <= #{fin:MM/dd/yyyy}#";
                vista.RowFilter = filtro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBNumAf_TextChanged(object sender, EventArgs e)
        {
            dGVAfiliados.DataSource = dt;
            DataView vista = dt.DefaultView;
            if (tBNumAf.Text == "")
            {
                vista.RowFilter = "";
            }
            else
            {
                vista.RowFilter = $"id = '{tBNumAf.Text}'";
            }
        }
    }
}
