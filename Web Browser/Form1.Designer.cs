
namespace Web_Browser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonback = new System.Windows.Forms.ToolStripButton();
            this.buttonforward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbolocation = new System.Windows.Forms.ToolStripComboBox();
            this.buttongo = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonback,
            this.buttonforward,
            this.toolStripSeparator1,
            this.cbolocation,
            this.buttongo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // buttonback
            // 
            this.buttonback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonback.Image = ((System.Drawing.Image)(resources.GetObject("buttonback.Image")));
            this.buttonback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(41, 22);
            this.buttonback.Text = "BACK";
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonforward
            // 
            this.buttonforward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonforward.Image = ((System.Drawing.Image)(resources.GetObject("buttonforward.Image")));
            this.buttonforward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonforward.Name = "buttonforward";
            this.buttonforward.Size = new System.Drawing.Size(67, 22);
            this.buttonforward.Text = "FORWARD";
            this.buttonforward.Click += new System.EventHandler(this.buttonforward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cbolocation
            // 
            this.cbolocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.cbolocation.Name = "cbolocation";
            this.cbolocation.Size = new System.Drawing.Size(121, 25);
            this.cbolocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbolocation_KeyDown);
            // 
            // buttongo
            // 
            this.buttongo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttongo.Image = ((System.Drawing.Image)(resources.GetObject("buttongo.Image")));
            this.buttongo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttongo.Name = "buttongo";
            this.buttongo.Size = new System.Drawing.Size(28, 22);
            this.buttongo.Text = "GO";
            this.buttongo.Click += new System.EventHandler(this.buttongo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonback;
        private System.Windows.Forms.ToolStripButton buttonforward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbolocation;
        private System.Windows.Forms.ToolStripButton buttongo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

