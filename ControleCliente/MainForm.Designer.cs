
namespace ControleCliente
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnInclude = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExclude = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAllClients = new System.Windows.Forms.TextBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.cboHeaders = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInclude
            // 
            this.btnInclude.Location = new System.Drawing.Point(13, 13);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(75, 41);
            this.btnInclude.TabIndex = 0;
            this.btnInclude.Text = "Cadastrar";
            this.btnInclude.UseVisualStyleBackColor = true;
            this.btnInclude.Click += new System.EventHandler(this.btnInclude_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(115, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 41);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExclude
            // 
            this.btnExclude.Location = new System.Drawing.Point(217, 13);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(75, 41);
            this.btnExclude.TabIndex = 2;
            this.btnExclude.Text = "Excluir";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(12, 86);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(776, 321);
            this.dgvClients.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº de Registros";
            // 
            // txbAllClients
            // 
            this.txbAllClients.Location = new System.Drawing.Point(734, 418);
            this.txbAllClients.Name = "txbAllClients";
            this.txbAllClients.ReadOnly = true;
            this.txbAllClients.Size = new System.Drawing.Size(54, 20);
            this.txbAllClients.TabIndex = 10;
            // 
            // txbFilter
            // 
            this.txbFilter.Location = new System.Drawing.Point(293, 60);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(415, 20);
            this.txbFilter.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(714, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(13, 418);
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(369, 20);
            this.txbFilePath.TabIndex = 7;
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(388, 416);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseFiles.TabIndex = 8;
            this.btnBrowseFiles.Text = "...";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(443, 416);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(121, 23);
            this.btnImportFile.TabIndex = 9;
            this.btnImportFile.Text = "Importar Planilha";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // cboHeaders
            // 
            this.cboHeaders.FormattingEnabled = true;
            this.cboHeaders.Location = new System.Drawing.Point(13, 60);
            this.cboHeaders.Name = "cboHeaders";
            this.cboHeaders.Size = new System.Drawing.Size(274, 21);
            this.cboHeaders.TabIndex = 3;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(319, 13);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 41);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Exibir Todos";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.cboHeaders);
            this.Controls.Add(this.btnImportFile);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.txbFilePath);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.txbAllClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInclude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Clientes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExclude;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAllClients;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.ComboBox cboHeaders;
        private System.Windows.Forms.Button btnShowAll;
    }
}

