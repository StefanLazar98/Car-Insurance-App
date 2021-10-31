
namespace FirmaAsigurari
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareAsigurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl11 = new FirmaAsigurari.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniToolStripMenuItem,
            this.vizualizareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareAsigurareToolStripMenuItem});
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // adaugareAsigurareToolStripMenuItem
            // 
            this.adaugareAsigurareToolStripMenuItem.Name = "adaugareAsigurareToolStripMenuItem";
            this.adaugareAsigurareToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.adaugareAsigurareToolStripMenuItem.Text = "Adaugare Asigurare";
            this.adaugareAsigurareToolStripMenuItem.Click += new System.EventHandler(this.adaugareAsigurareToolStripMenuItem_Click);
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareDateToolStripMenuItem});
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // vizualizareDateToolStripMenuItem
            // 
            this.vizualizareDateToolStripMenuItem.Name = "vizualizareDateToolStripMenuItem";
            this.vizualizareDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vizualizareDateToolStripMenuItem.Text = "Vizualizare Date";
            this.vizualizareDateToolStripMenuItem.Click += new System.EventHandler(this.vizualizareDateToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma de Asigurari";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(97, 125);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(613, 187);
            this.userControl11.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareAsigurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareDateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private UserControl1 userControl11;
    }
}