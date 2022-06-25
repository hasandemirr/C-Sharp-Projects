
namespace Connected_Mimari_Ürün_Detay
{
    partial class ProductDetail
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
            this.lbl_prdct_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_qpu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_prdct_name
            // 
            this.lbl_prdct_name.AutoSize = true;
            this.lbl_prdct_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_prdct_name.Location = new System.Drawing.Point(68, 76);
            this.lbl_prdct_name.Name = "lbl_prdct_name";
            this.lbl_prdct_name.Size = new System.Drawing.Size(213, 31);
            this.lbl_prdct_name.TabIndex = 0;
            this.lbl_prdct_name.Text = "lbl_prdct_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "QPU:";
            // 
            // lbl_qpu
            // 
            this.lbl_qpu.AutoSize = true;
            this.lbl_qpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_qpu.Location = new System.Drawing.Point(159, 171);
            this.lbl_qpu.Name = "lbl_qpu";
            this.lbl_qpu.Size = new System.Drawing.Size(108, 31);
            this.lbl_qpu.TabIndex = 2;
            this.lbl_qpu.Text = "lbl_qpu";
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.lbl_qpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_prdct_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductDetail";
            this.Text = "ProductDetail";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_prdct_name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_qpu;
    }
}