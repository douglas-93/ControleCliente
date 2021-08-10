
namespace ControleCliente
{
    partial class AddClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxbEntryDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxbDepartureDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbEntryEquipaments = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbPerformedProcedures = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(53, 12);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(353, 20);
            this.txbName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Entrada";
            // 
            // mtxbEntryDate
            // 
            this.mtxbEntryDate.Location = new System.Drawing.Point(503, 12);
            this.mtxbEntryDate.Mask = "00/00/0000";
            this.mtxbEntryDate.Name = "mtxbEntryDate";
            this.mtxbEntryDate.Size = new System.Drawing.Size(73, 20);
            this.mtxbEntryDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Saída";
            // 
            // mtxbDepartureDate
            // 
            this.mtxbDepartureDate.Location = new System.Drawing.Point(665, 12);
            this.mtxbDepartureDate.Mask = "00/00/0000";
            this.mtxbDepartureDate.Name = "mtxbDepartureDate";
            this.mtxbDepartureDate.Size = new System.Drawing.Size(73, 20);
            this.mtxbDepartureDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Equipamentos que deram entrada";
            // 
            // rtbEntryEquipaments
            // 
            this.rtbEntryEquipaments.Location = new System.Drawing.Point(12, 58);
            this.rtbEntryEquipaments.Name = "rtbEntryEquipaments";
            this.rtbEntryEquipaments.Size = new System.Drawing.Size(340, 347);
            this.rtbEntryEquipaments.TabIndex = 3;
            this.rtbEntryEquipaments.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Procedimentos Realizados";
            // 
            // rtbPerformedProcedures
            // 
            this.rtbPerformedProcedures.Location = new System.Drawing.Point(401, 58);
            this.rtbPerformedProcedures.Name = "rtbPerformedProcedures";
            this.rtbPerformedProcedures.Size = new System.Drawing.Size(340, 347);
            this.rtbPerformedProcedures.TabIndex = 4;
            this.rtbPerformedProcedures.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(585, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(666, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 444);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbPerformedProcedures);
            this.Controls.Add(this.rtbEntryEquipaments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxbDepartureDate);
            this.Controls.Add(this.mtxbEntryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxbEntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxbDepartureDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbEntryEquipaments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbPerformedProcedures;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}