using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Neonatal_SanBartolome
{
    public class FuncionesGenerales
    {

        public void WriteCSV(DataGridView gridIn)
        {
            string ruta = string.Empty;

            var saveFileDialog1 = new SaveFileDialog
                                      {
                                          InitialDirectory = @"C:\",
                                          Title = @"Guardar Archivo",
                                          CheckPathExists = true,
                                          DefaultExt = "csv",
                                          Filter = @"Text files (*.csv)|",
                                          FilterIndex = 2,
                                          RestoreDirectory = true
                                      };

            //saveFileDialog1.CheckFileExists = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                ruta = saveFileDialog1.FileName;

            }

            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value;
                DataGridViewRow dr; // = new DataGridViewRow();
                var swOut = new StreamWriter(ruta, true, Encoding.UTF8);

                //write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(gridIn.Columns[i].HeaderText);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                try
                {
                    swOut.Close();
                    MessageBox.Show(@"Archivo de Excel creado correctamente");
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Hubo un problema al generar el archivo");
                }
                
            }
        }       
    }
}
