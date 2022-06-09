
namespace Fotoğraf_Görüntüleyici
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClsButton = new System.Windows.Forms.Button();
            this.BckgrndBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.ShwBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.39706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.60294F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Sığdır";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ClsButton);
            this.flowLayoutPanel1.Controls.Add(this.BckgrndBtn);
            this.flowLayoutPanel1.Controls.Add(this.ClrBtn);
            this.flowLayoutPanel1.Controls.Add(this.ShwBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 291);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 27);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ClsButton
            // 
            this.ClsButton.AutoSize = true;
            this.ClsButton.Location = new System.Drawing.Point(3, 3);
            this.ClsButton.Name = "ClsButton";
            this.ClsButton.Size = new System.Drawing.Size(75, 23);
            this.ClsButton.TabIndex = 0;
            this.ClsButton.Text = "Kapat";
            this.ClsButton.UseVisualStyleBackColor = true;
            this.ClsButton.Click += new System.EventHandler(this.ClsButton_Click);
            // 
            // BckgrndBtn
            // 
            this.BckgrndBtn.AutoSize = true;
            this.BckgrndBtn.Location = new System.Drawing.Point(84, 3);
            this.BckgrndBtn.Name = "BckgrndBtn";
            this.BckgrndBtn.Size = new System.Drawing.Size(99, 23);
            this.BckgrndBtn.TabIndex = 1;
            this.BckgrndBtn.Text = "Arkaplanı Değiştir";
            this.BckgrndBtn.UseVisualStyleBackColor = true;
            this.BckgrndBtn.Click += new System.EventHandler(this.BckgrndBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.AutoSize = true;
            this.ClrBtn.Location = new System.Drawing.Point(189, 3);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 2;
            this.ClrBtn.Text = "Sil";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // ShwBtn
            // 
            this.ShwBtn.AutoSize = true;
            this.ShwBtn.Location = new System.Drawing.Point(270, 3);
            this.ShwBtn.Name = "ShwBtn";
            this.ShwBtn.Size = new System.Drawing.Size(75, 23);
            this.ShwBtn.TabIndex = 3;
            this.ShwBtn.Text = "Göster";
            this.ShwBtn.UseVisualStyleBackColor = true;
            this.ShwBtn.Click += new System.EventHandler(this.ShwBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Resim Dosyası Seçin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotoğraf Görüntüleyici";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ClsButton;
        private System.Windows.Forms.Button BckgrndBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button ShwBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

