
namespace ApartmanOtomasyon
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
            this.chkElectric = new System.Windows.Forms.CheckBox();
            this.chkSu = new System.Windows.Forms.CheckBox();
            this.chkAsansor = new System.Windows.Forms.CheckBox();
            this.chkTemizlik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGiderTutar = new System.Windows.Forms.NumericUpDown();
            this.dtGiderTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGiderEkle = new System.Windows.Forms.Button();
            this.grpBoxGiderler = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiderTutar)).BeginInit();
            this.grpBoxGiderler.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkElectric
            // 
            this.chkElectric.AutoSize = true;
            this.chkElectric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkElectric.Location = new System.Drawing.Point(67, 43);
            this.chkElectric.Name = "chkElectric";
            this.chkElectric.Size = new System.Drawing.Size(88, 24);
            this.chkElectric.TabIndex = 0;
            this.chkElectric.Text = "Elektrik";
            this.chkElectric.UseVisualStyleBackColor = true;
            // 
            // chkSu
            // 
            this.chkSu.AutoSize = true;
            this.chkSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSu.Location = new System.Drawing.Point(67, 86);
            this.chkSu.Name = "chkSu";
            this.chkSu.Size = new System.Drawing.Size(50, 24);
            this.chkSu.TabIndex = 0;
            this.chkSu.Text = "Su";
            this.chkSu.UseVisualStyleBackColor = true;
            // 
            // chkAsansor
            // 
            this.chkAsansor.AutoSize = true;
            this.chkAsansor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsansor.Location = new System.Drawing.Point(67, 129);
            this.chkAsansor.Name = "chkAsansor";
            this.chkAsansor.Size = new System.Drawing.Size(94, 24);
            this.chkAsansor.TabIndex = 0;
            this.chkAsansor.Text = "Asansör";
            this.chkAsansor.UseVisualStyleBackColor = true;
            // 
            // chkTemizlik
            // 
            this.chkTemizlik.AutoSize = true;
            this.chkTemizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTemizlik.Location = new System.Drawing.Point(67, 172);
            this.chkTemizlik.Name = "chkTemizlik";
            this.chkTemizlik.Size = new System.Drawing.Size(92, 24);
            this.chkTemizlik.TabIndex = 0;
            this.chkTemizlik.Text = "Temizlik";
            this.chkTemizlik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // nudGiderTutar
            // 
            this.nudGiderTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGiderTutar.Location = new System.Drawing.Point(407, 45);
            this.nudGiderTutar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGiderTutar.Name = "nudGiderTutar";
            this.nudGiderTutar.Size = new System.Drawing.Size(271, 26);
            this.nudGiderTutar.TabIndex = 2;
            // 
            // dtGiderTarih
            // 
            this.dtGiderTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGiderTarih.Location = new System.Drawing.Point(409, 103);
            this.dtGiderTarih.Name = "dtGiderTarih";
            this.dtGiderTarih.Size = new System.Drawing.Size(269, 22);
            this.dtGiderTarih.TabIndex = 3;
            // 
            // btnGiderEkle
            // 
            this.btnGiderEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiderEkle.Location = new System.Drawing.Point(407, 161);
            this.btnGiderEkle.Name = "btnGiderEkle";
            this.btnGiderEkle.Size = new System.Drawing.Size(161, 33);
            this.btnGiderEkle.TabIndex = 4;
            this.btnGiderEkle.Text = "Ekle";
            this.btnGiderEkle.UseVisualStyleBackColor = true;
            this.btnGiderEkle.Click += new System.EventHandler(this.btnGiderEkle_Click);
            // 
            // grpBoxGiderler
            // 
            this.grpBoxGiderler.Controls.Add(this.chkElectric);
            this.grpBoxGiderler.Controls.Add(this.btnGiderEkle);
            this.grpBoxGiderler.Controls.Add(this.chkSu);
            this.grpBoxGiderler.Controls.Add(this.dtGiderTarih);
            this.grpBoxGiderler.Controls.Add(this.chkAsansor);
            this.grpBoxGiderler.Controls.Add(this.nudGiderTutar);
            this.grpBoxGiderler.Controls.Add(this.chkTemizlik);
            this.grpBoxGiderler.Controls.Add(this.label2);
            this.grpBoxGiderler.Controls.Add(this.label1);
            this.grpBoxGiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGiderler.Location = new System.Drawing.Point(64, 12);
            this.grpBoxGiderler.Name = "grpBoxGiderler";
            this.grpBoxGiderler.Size = new System.Drawing.Size(703, 207);
            this.grpBoxGiderler.TabIndex = 5;
            this.grpBoxGiderler.TabStop = false;
            this.grpBoxGiderler.Text = "Giderler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(64, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 251);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(329, 240);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 251);
            this.listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(594, 240);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(172, 251);
            this.listBox3.TabIndex = 6;
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 510);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.grpBoxGiderler);
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGiderTutar)).EndInit();
            this.grpBoxGiderler.ResumeLayout(false);
            this.grpBoxGiderler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkElectric;
        private System.Windows.Forms.CheckBox chkSu;
        private System.Windows.Forms.CheckBox chkAsansor;
        private System.Windows.Forms.CheckBox chkTemizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGiderTutar;
        private System.Windows.Forms.DateTimePicker dtGiderTarih;
        private System.Windows.Forms.Button btnGiderEkle;
        private System.Windows.Forms.GroupBox grpBoxGiderler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}