
namespace FirmaAsigurari
{
    partial class EditAsigurari
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipAsigEdit = new System.Windows.Forms.ComboBox();
            this.cbAnEdit = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip de Asigurare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ani de Asigurare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pret Total Asigurare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pret";
            // 
            // cbTipAsigEdit
            // 
            this.cbTipAsigEdit.FormattingEnabled = true;
            this.cbTipAsigEdit.Items.AddRange(new object[] {
            "RCA",
            "CASCO",
            "Asigurare de bunuri",
            "Asigurare de calatorie",
            "Asigurare de viata"});
            this.cbTipAsigEdit.Location = new System.Drawing.Point(246, 35);
            this.cbTipAsigEdit.Name = "cbTipAsigEdit";
            this.cbTipAsigEdit.Size = new System.Drawing.Size(121, 21);
            this.cbTipAsigEdit.TabIndex = 1;
            // 
            // cbAnEdit
            // 
            this.cbAnEdit.FormattingEnabled = true;
            this.cbAnEdit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbAnEdit.Location = new System.Drawing.Point(246, 171);
            this.cbAnEdit.Name = "cbAnEdit";
            this.cbAnEdit.Size = new System.Drawing.Size(121, 21);
            this.cbAnEdit.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnOK1
            // 
            this.btnOK1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK1.Location = new System.Drawing.Point(561, 381);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(85, 46);
            this.btnOK1.TabIndex = 3;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = true;
            this.btnOK1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel1.Location = new System.Drawing.Point(691, 381);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(84, 46);
            this.btnCancel1.TabIndex = 4;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            // 
            // EditForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbAnEdit);
            this.Controls.Add(this.cbTipAsigEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm1";
            this.Text = "EditForm1";
            this.Load += new System.EventHandler(this.EditForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipAsigEdit;
        private System.Windows.Forms.ComboBox cbAnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnCancel1;
    }
}