namespace DataBase_Encryption
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.TXTSOYAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTMAIL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTSIFRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTHESAPNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNKAYDET = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // TXTAD
            // 
            this.TXTAD.Location = new System.Drawing.Point(89, 6);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(100, 26);
            this.TXTAD.TabIndex = 2;
            // 
            // TXTSOYAD
            // 
            this.TXTSOYAD.Location = new System.Drawing.Point(89, 38);
            this.TXTSOYAD.Name = "TXTSOYAD";
            this.TXTSOYAD.Size = new System.Drawing.Size(100, 26);
            this.TXTSOYAD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad:";
            // 
            // TXTMAIL
            // 
            this.TXTMAIL.Location = new System.Drawing.Point(89, 70);
            this.TXTMAIL.Name = "TXTMAIL";
            this.TXTMAIL.Size = new System.Drawing.Size(100, 26);
            this.TXTMAIL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail:";
            // 
            // TXTSIFRE
            // 
            this.TXTSIFRE.Location = new System.Drawing.Point(321, 3);
            this.TXTSIFRE.Name = "TXTSIFRE";
            this.TXTSIFRE.Size = new System.Drawing.Size(100, 26);
            this.TXTSIFRE.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre:";
            // 
            // TXTHESAPNO
            // 
            this.TXTHESAPNO.Location = new System.Drawing.Point(321, 41);
            this.TXTHESAPNO.Name = "TXTHESAPNO";
            this.TXTHESAPNO.Size = new System.Drawing.Size(100, 26);
            this.TXTHESAPNO.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hesapno:";
            // 
            // BTNKAYDET
            // 
            this.BTNKAYDET.Location = new System.Drawing.Point(346, 87);
            this.BTNKAYDET.Name = "BTNKAYDET";
            this.BTNKAYDET.Size = new System.Drawing.Size(75, 30);
            this.BTNKAYDET.TabIndex = 11;
            this.BTNKAYDET.Text = "KAYDET";
            this.BTNKAYDET.UseVisualStyleBackColor = true;
            this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 288);
            this.Controls.Add(this.BTNKAYDET);
            this.Controls.Add(this.TXTHESAPNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTSIFRE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTMAIL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTSOYAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.TextBox TXTSOYAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTMAIL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTSIFRE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTHESAPNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNKAYDET;
    }
}

