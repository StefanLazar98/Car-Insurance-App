
namespace FirmaAsigurari
{
    partial class EditClienti
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipPlataEdit = new System.Windows.Forms.ComboBox();
            this.tbNumeEdit = new System.Windows.Forms.TextBox();
            this.tbTelefonEdit = new System.Windows.Forms.TextBox();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tip de Plata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon";
            // 
            // cbTipPlataEdit
            // 
            this.cbTipPlataEdit.FormattingEnabled = true;
            this.cbTipPlataEdit.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cbTipPlataEdit.Location = new System.Drawing.Point(180, 117);
            this.cbTipPlataEdit.Name = "cbTipPlataEdit";
            this.cbTipPlataEdit.Size = new System.Drawing.Size(121, 21);
            this.cbTipPlataEdit.TabIndex = 1;
            // 
            // tbNumeEdit
            // 
            this.tbNumeEdit.Location = new System.Drawing.Point(180, 38);
            this.tbNumeEdit.Name = "tbNumeEdit";
            this.tbNumeEdit.Size = new System.Drawing.Size(100, 20);
            this.tbNumeEdit.TabIndex = 2;
            this.tbNumeEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeEdit_Validating);
            this.tbNumeEdit.Validated += new System.EventHandler(this.tbNumeEdit_Validated);
            // 
            // tbTelefonEdit
            // 
            this.tbTelefonEdit.Location = new System.Drawing.Point(180, 198);
            this.tbTelefonEdit.Name = "tbTelefonEdit";
            this.tbTelefonEdit.Size = new System.Drawing.Size(100, 20);
            this.tbTelefonEdit.TabIndex = 2;
            this.tbTelefonEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefonEdit_Validating);
            this.tbTelefonEdit.Validated += new System.EventHandler(this.tbTelefonEdit_Validated);
            // 
            // btnOk2
            // 
            this.btnOk2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk2.Location = new System.Drawing.Point(507, 382);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(102, 38);
            this.btnOk2.TabIndex = 3;
            this.btnOk2.Text = "OK";
            this.btnOk2.UseVisualStyleBackColor = true;
            this.btnOk2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel2.Location = new System.Drawing.Point(677, 382);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(99, 38);
            this.btnCancel2.TabIndex = 3;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.tbTelefonEdit);
            this.Controls.Add(this.tbNumeEdit);
            this.Controls.Add(this.cbTipPlataEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm2";
            this.Text = "EditForm2";
            this.Load += new System.EventHandler(this.EditForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipPlataEdit;
        private System.Windows.Forms.TextBox tbNumeEdit;
        private System.Windows.Forms.TextBox tbTelefonEdit;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}