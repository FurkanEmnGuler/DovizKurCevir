namespace DovizKurCevir
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.rbTL = new System.Windows.Forms.RadioButton();
            this.rbUSD = new System.Windows.Forms.RadioButton();
            this.rbEURO = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(291, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "ÇALIŞTIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbTL
            // 
            this.rbTL.AutoSize = true;
            this.rbTL.Location = new System.Drawing.Point(151, 54);
            this.rbTL.Name = "rbTL";
            this.rbTL.Size = new System.Drawing.Size(38, 17);
            this.rbTL.TabIndex = 17;
            this.rbTL.TabStop = true;
            this.rbTL.Text = "TL";
            this.rbTL.UseVisualStyleBackColor = true;
            // 
            // rbUSD
            // 
            this.rbUSD.AutoSize = true;
            this.rbUSD.Location = new System.Drawing.Point(151, 78);
            this.rbUSD.Name = "rbUSD";
            this.rbUSD.Size = new System.Drawing.Size(48, 17);
            this.rbUSD.TabIndex = 18;
            this.rbUSD.TabStop = true;
            this.rbUSD.Text = "USD";
            this.rbUSD.UseVisualStyleBackColor = true;
            // 
            // rbEURO
            // 
            this.rbEURO.AutoSize = true;
            this.rbEURO.Location = new System.Drawing.Point(151, 102);
            this.rbEURO.Name = "rbEURO";
            this.rbEURO.Size = new System.Drawing.Size(56, 17);
            this.rbEURO.TabIndex = 19;
            this.rbEURO.TabStop = true;
            this.rbEURO.Text = "EURO";
            this.rbEURO.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(10, 54);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 20;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(252, 51);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(161, 81);
            this.txtResult.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "KUR DEĞERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(148, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "KUR BİÇİMİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "GİRİLEN DEĞER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.rbEURO);
            this.Controls.Add(this.rbUSD);
            this.Controls.Add(this.rbTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tcmb Döviz Kur Çevirme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbTL;
        private System.Windows.Forms.RadioButton rbUSD;
        private System.Windows.Forms.RadioButton rbEURO;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

