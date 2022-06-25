
namespace Apartman_Otomasyon
{
    partial class Form1
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
            this.btn_Gelirler = new System.Windows.Forms.Button();
            this.btn_giderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gelirler
            // 
            this.btn_Gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gelirler.Location = new System.Drawing.Point(73, 139);
            this.btn_Gelirler.Name = "btn_Gelirler";
            this.btn_Gelirler.Size = new System.Drawing.Size(111, 111);
            this.btn_Gelirler.TabIndex = 0;
            this.btn_Gelirler.Text = "Gelirler";
            this.btn_Gelirler.UseVisualStyleBackColor = true;
            this.btn_Gelirler.Click += new System.EventHandler(this.btn_Gelirler_Click);
            // 
            // btn_giderler
            // 
            this.btn_giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giderler.Location = new System.Drawing.Point(228, 139);
            this.btn_giderler.Name = "btn_giderler";
            this.btn_giderler.Size = new System.Drawing.Size(111, 111);
            this.btn_giderler.TabIndex = 1;
            this.btn_giderler.Text = "Giderler";
            this.btn_giderler.UseVisualStyleBackColor = true;
            this.btn_giderler.Click += new System.EventHandler(this.btn_giderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btn_giderler);
            this.Controls.Add(this.btn_Gelirler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gelirler;
        private System.Windows.Forms.Button btn_giderler;
    }
}

