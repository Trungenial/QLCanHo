using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCanHo.Class
{
    internal class ToExcel
    {
        public static void DgvToExcel(DataGridView dgvLSThueCanHo, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "xuatexcel";

                // export header
                for (int i = 0; i < dgvLSThueCanHo.ColumnCount; i++)
                {
                    {
                        worksheet.Cells[1, i + 1] = dgvLSThueCanHo.Columns[i].HeaderText;
                    }
                }

                //export content
                for (int i = 0; i < dgvLSThueCanHo.RowCount; i++)
                {
                    
                    for (int j = 0; j < dgvLSThueCanHo.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvLSThueCanHo.Rows[i].Cells[j].Value.ToString();
                    }
                    
                }

                //save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Export seccessful.!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
