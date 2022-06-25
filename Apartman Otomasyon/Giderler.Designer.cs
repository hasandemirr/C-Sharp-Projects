
namespace Apartman_Otomasyon
{
    partial class Giderler
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
            this.chck_Elektrik = new System.Windows.Forms.CheckBox();
            this.chck_Su = new System.Windows.Forms.CheckBox();
            this.chck_Asansor = new System.Windows.Forms.CheckBox();
            this.chck_temizlik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chck_Elektrik
            // 
            this.chck_Elektrik.AutoSize = true;
            this.chck_Elektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_Elektrik.Location = new System.Drawing.Point(22, 52);
            this.chck_Elektrik.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chck_Elektrik.Name = "chck_Elektrik";
            this.chck_Elektrik.Size = new System.Drawing.Size(97, 28);
            this.chck_Elektrik.TabIndex = 0;
            this.chck_Elektrik.Text = "Elektrik";
            this.chck_Elektrik.UseVisualStyleBackColor = true;
            // 
            // chck_Su
            // 
            this.chck_Su.AutoSize = true;
            this.chck_Su.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_Su.Location = new System.Drawing.Point(22, 92);
            this.chck_Su.Margin = new System.Windows.Forms.Padding(6);
            this.chck_Su.Name = "chck_Su";
            this.chck_Su.Size = new System.Drawing.Size(54, 28);
            this.chck_Su.TabIndex = 1;
            this.chck_Su.Text = "Su";
            this.chck_Su.UseVisualStyleBackColor = true;
            // 
            // chck_Asansor
            // 
            this.chck_Asansor.AutoSize = true;
            this.chck_Asansor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_Asansor.Location = new System.Drawing.Point(22, 132);
            this.chck_Asansor.Margin = new System.Windows.Forms.Padding(6);
            this.chck_Asansor.Name = "chck_Asansor";
            this.chck_Asansor.Size = new System.Drawing.Size(105, 28);
            this.chck_Asansor.TabIndex = 2;
            this.chck_Asansor.Text = "Asansör";
            this.chck_Asansor.UseVisualStyleBackColor = true;
            // 
            // chck_temizlik
            // 
            this.chck_temizlik.AutoSize = true;
            this.chck_temizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chck_temizlik.Location = new System.Drawing.Point(22, 172);
            this.chck_temizlik.Margin = new System.Windows.Forms.Padding(6);
            this.chck_temizlik.Name = "chck_temizlik";
            this.chck_temizlik.Size = new System.Drawing.Size(106, 28);
            this.chck_temizlik.TabIndex = 3;
            this.chck_temizlik.Text = "Temizlik";
            this.chck_temizlik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 29);
            this.numericUpDown1.TabIndex = 7;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(298, 172);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(200, 52);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chck_Elektrik);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.chck_Su);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.chck_Asansor);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.chck_temizlik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 261);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 288);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 220);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(224, 288);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(163, 220);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(442, 288);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(163, 220);
            this.listBox3.TabIndex = 12;
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 523);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Giderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chck_Elektrik;
        private System.Windows.Forms.CheckBox chck_Su;
        private System.Windows.Forms.CheckBox chck_Asansor;
        private System.Windows.Forms.CheckBox chck_temizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}