
namespace FirmaAsigurari
{
    partial class Asigurari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asigurari));
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipAsig = new System.Windows.Forms.ComboBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPretTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Asigurare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PretTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbAn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.serializareAltSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareALTDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza Tipul de Asigurare:";
            // 
            // cbTipAsig
            // 
            this.cbTipAsig.FormattingEnabled = true;
            this.cbTipAsig.Items.AddRange(new object[] {
            "RCA",
            "CASCO",
            "Asigurare de bunuri",
            "Asigurare de calatorie",
            "Asigurare de viata"});
            this.cbTipAsig.Location = new System.Drawing.Point(32, 56);
            this.cbTipAsig.Name = "cbTipAsig";
            this.cbTipAsig.Size = new System.Drawing.Size(113, 21);
            this.cbTipAsig.TabIndex = 1;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(32, 126);
            this.tbPret.Name = "tbPret";
            this.tbPret.ReadOnly = true;
            this.tbPret.Size = new System.Drawing.Size(100, 20);
            this.tbPret.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pret:";
            // 
            // tbPretTotal
            // 
            this.tbPretTotal.Location = new System.Drawing.Point(32, 263);
            this.tbPretTotal.Name = "tbPretTotal";
            this.tbPretTotal.ReadOnly = true;
            this.tbPretTotal.Size = new System.Drawing.Size(100, 20);
            this.tbPretTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pret Total Asigurare:";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(32, 294);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 48);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga Asigurare";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Asigurare,
            this.Pret,
            this.Ani,
            this.PretTotal});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 190);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListView1_ItemDrag);
            // 
            // Asigurare
            // 
            this.Asigurare.Tag = "";
            this.Asigurare.Text = "Asigurare";
            this.Asigurare.Width = 119;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            this.Pret.Width = 45;
            // 
            // Ani
            // 
            this.Ani.Text = "Ani";
            this.Ani.Width = 34;
            // 
            // PretTotal
            // 
            this.PretTotal.Text = "PretTotal";
            this.PretTotal.Width = 77;
            // 
            // cbAn
            // 
            this.cbAn.FormattingEnabled = true;
            this.cbAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbAn.Location = new System.Drawing.Point(32, 197);
            this.cbAn.Name = "cbAn";
            this.cbAn.Size = new System.Drawing.Size(121, 21);
            this.cbAn.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alegeti Anii de Asigurare";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anuleaza Asigurarea";
            this.label5.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label5_DragEnter);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(622, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareAltSToolStripMenuItem,
            this.deserializareALTDToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(96, 22);
            this.toolStripDropDownButton1.Text = "SerializareXML";
            // 
            // serializareAltSToolStripMenuItem
            // 
            this.serializareAltSToolStripMenuItem.Name = "serializareAltSToolStripMenuItem";
            this.serializareAltSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.serializareAltSToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.serializareAltSToolStripMenuItem.Text = "Serializare ";
            this.serializareAltSToolStripMenuItem.Click += new System.EventHandler(this.serializareAltSToolStripMenuItem_Click);
            // 
            // deserializareALTDToolStripMenuItem
            // 
            this.deserializareALTDToolStripMenuItem.Name = "deserializareALTDToolStripMenuItem";
            this.deserializareALTDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.deserializareALTDToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.deserializareALTDToolStripMenuItem.Text = "Deserializare";
            this.deserializareALTDToolStripMenuItem.Click += new System.EventHandler(this.deserializareALTDToolStripMenuItem_Click);
            // 
            // btnEditare
            // 
            this.btnEditare.Location = new System.Drawing.Point(154, 294);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(115, 48);
            this.btnEditare.TabIndex = 14;
            this.btnEditare.Text = "Editare Asigurare";
            this.btnEditare.UseVisualStyleBackColor = true;
            this.btnEditare.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(622, 439);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPretTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.cbTipAsig);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipAsig;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPretTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Asigurare;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Ani;
        private System.Windows.Forms.ColumnHeader PretTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem serializareAltSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareALTDToolStripMenuItem;
        private System.Windows.Forms.Button btnEditare;
    }
}

