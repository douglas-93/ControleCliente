using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using OfficeOpenXml;

namespace ControleCliente
{
    public partial class MainForm : Form
    {
        private string _excelFile = @"DB.xlsx";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(_excelFile))
            {
                GetData();
            }
            else
            {
                try
                {
                    var package = new ExcelPackage();
                    var workbook = package.Workbook;
                    var sheet = workbook.Worksheets.Add("Clientes");


                    sheet.Cells[1, 1].Value = "ID";
                    sheet.Cells[1, 2].Value = "Nome";
                    sheet.Cells[1, 3].Value = "Data Entrada";
                    sheet.Cells[1, 4].Value = "Equipamentos Fornecidos";
                    sheet.Cells[1, 5].Value = "Procedimentos Realizados";
                    sheet.Cells[1, 6].Value = "Data Saída";

                    package.SaveAs(new FileInfo(_excelFile));

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetData();
            }
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvClients.CurrentRow;
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            string name = selectedRow.Cells[1].Value.ToString();
            string entryDate = selectedRow.Cells[2].Value.ToString();
            string entryEquipaments = selectedRow.Cells[3].Value.ToString();
            string performedProcedures = selectedRow.Cells[4].Value.ToString();
            string departureDate = selectedRow.Cells[5].Value.ToString();

            var addClientForm = new AddClientForm(id, name, entryDate, departureDate, entryEquipaments, performedProcedures);
            addClientForm.ShowDialog();
            GetData();
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            var currentRow = dgvClients.CurrentRow;
            int rowIDToDelete = (int)Double.Parse(currentRow.Cells[0].Value.ToString());

            var excelPackage = new ExcelPackage(new FileInfo(_excelFile));
            var sheet = excelPackage.Workbook.Worksheets[0];
            int lastRow = sheet.Dimension.End.Row;

            for (int row = 2; row <= lastRow; row++)
            {
                int rowID = (int)Double.Parse(sheet.Cells[row, 1].Value.ToString());
                
                if (rowID == rowIDToDelete)
                {
                    sheet.DeleteRow(row);
                    break;
                }
            }
            excelPackage.Save();
            GetData();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = txbFilter.Text.Trim().Replace("'", "\"");
                ((DataTable)dgvClients.DataSource).DefaultView.RowFilter = $"Convert([{cboHeaders.Text}], System.String) like '%{filter}%'";
                txbAllClients.Text = dgvClients.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Worksheets|*.xls;*.xlsx|All Files|*.*";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbFilePath.Text) && File.Exists(txbFilePath.Text))
            {
                _excelFile = txbFilePath.Text;
                GetData();
                txbFilePath.Clear();
            }
        }

        private void GetData()
        {
            try
            {
                cboHeaders.Items.Clear();

                var data = GetExcelTable(_excelFile);
                dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvClients.DataSource = data;

                txbAllClients.Text = (dgvClients.Rows.Count).ToString();
                string[] headers = data.Columns.OfType<DataColumn>().Select(field => field.ColumnName).ToArray();

                cboHeaders.Items.AddRange(headers);

                if (cboHeaders.Items.Count > 0)
                {
                    cboHeaders.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetExcelTable(string excelFile)
        {
            var data = new DataTable();
            try
            {
                string extension = Path.GetExtension(excelFile);
                string connectionString = "";

                connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source ={excelFile}; Extended Properties = 'Excel 12.0 Xml;HDR=YES'";

                var connection = new OleDbConnection(connectionString);
                var command = new OleDbCommand();
                var dataAdapter = new OleDbDataAdapter();

                command.Connection = connection;
                connection.Open();

                DataTable dataSchema;
                dataSchema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                var sheetName = dataSchema.Rows[0]["TABLE_NAME"].ToString();
                connection.Close();

                connection.Open();
                command.CommandText = $"SELECT * FROM [{sheetName}]";
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(data);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
    }
}
