using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleCliente
{
    public partial class AddClientForm : Form
    {
        private string _excelFile = @"DB.xlsx";
        private int _edit_id = -1;

        public AddClientForm()
        {
            InitializeComponent();
        }
        
        public AddClientForm(int id, string name, string entryDate, string departureDate, string entryEquipaments, string performedProcedures)
        {
            InitializeComponent();
            _edit_id = id;
            txbName.Text = name;
            mtxbEntryDate.Text = entryDate;
            mtxbDepartureDate.Text = departureDate;
            rtbEntryEquipaments.Text = entryEquipaments;
            rtbPerformedProcedures.Text = performedProcedures;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFields() && _edit_id == -1)
            {
                var excelPackage = new ExcelPackage(new FileInfo(_excelFile));
                var sheet = excelPackage.Workbook.Worksheets[0];

                int lastRow = sheet.Dimension.End.Row;
                string departureDate = "";

                var pattern = @"[0-9]{2}/[0-9]{2}/[0-9]{4}";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(mtxbDepartureDate.Text))
                {
                    departureDate = mtxbDepartureDate.Text;
                }

                if (sheet.Cells[lastRow, 1].Value.Equals("ID"))
                {
                    lastRow += 1;
                    sheet.Cells[lastRow, 1].Value = 1;
                    sheet.Cells[lastRow, 2].Value = txbName.Text;
                    sheet.Cells[lastRow, 3].Value = mtxbEntryDate.Text;
                    sheet.Cells[lastRow, 4].Value = rtbEntryEquipaments.Text;
                    sheet.Cells[lastRow, 5].Value = rtbPerformedProcedures.Text;
                    sheet.Cells[lastRow, 6].Value = departureDate;
                }
                else
                {
                    var id = double.Parse(sheet.Cells[lastRow, 1].Value.ToString()) + 1;
                    lastRow += 1;
                    sheet.Cells[lastRow, 1].Value = (int)id;
                    sheet.Cells[lastRow, 2].Value = txbName.Text;
                    sheet.Cells[lastRow, 3].Value = mtxbEntryDate.Text;
                    sheet.Cells[lastRow, 4].Value = rtbEntryEquipaments.Text;
                    sheet.Cells[lastRow, 5].Value = rtbPerformedProcedures.Text;
                    sheet.Cells[lastRow, 6].Value = departureDate;
                }
                excelPackage.Save();
                this.Dispose();
            }
            else if (CheckFields() && _edit_id != -1)
            {
                var excelPackage = new ExcelPackage(new FileInfo(_excelFile));
                var sheet = excelPackage.Workbook.Worksheets[0];

                int lastRow = sheet.Dimension.End.Row;
                string departureDate = "";

                var pattern = @"[0-9]{2}/[0-9]{2}/[0-9]{4}";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(mtxbDepartureDate.Text))
                {
                    departureDate = mtxbDepartureDate.Text;
                }

                for (int row = 2; row <= lastRow; row++)
                {
                    int rowId = (int)Double.Parse(sheet.Cells[row, 1].Value.ToString());
                    if (rowId == _edit_id)
                    {
                        sheet.Cells[row, 1].Value = rowId;
                        sheet.Cells[row, 2].Value = txbName.Text;
                        sheet.Cells[row, 3].Value = mtxbEntryDate.Text;
                        sheet.Cells[row, 4].Value = rtbEntryEquipaments.Text;
                        sheet.Cells[row, 5].Value = rtbPerformedProcedures.Text;
                        sheet.Cells[row, 6].Value = departureDate;
                        break;
                    }
                }
                
                excelPackage.Save();
                this.Dispose();
            }
        }

        private bool CheckFields()
        {
            if (String.IsNullOrEmpty(txbName.Text))
            {
                FillFieldMessage("nome");
                return false;
            }

            var pattern = @"[0-9]{2}/[0-9]{2}/[0-9]{4}";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(mtxbEntryDate.Text))
            {
                FillFieldMessage("data de entrada");
                return false;
            }

            if (String.IsNullOrEmpty(rtbEntryEquipaments.Text))
            {
                FillFieldMessage("equipamentos de entrada");
            }
            return true;
        }

        private void FillFieldMessage(string field)
        {
            MessageBox.Show($"Favor preencher {field} para prosseguir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
