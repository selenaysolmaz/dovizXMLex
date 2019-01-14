namespace DövizKurlarıDataSource
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
            this.lstBoxDoviz = new System.Windows.Forms.ListBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblAlıs = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.dataGridVievDoviz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DovizAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satıs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVievDoviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxDoviz
            // 
            this.lstBoxDoviz.FormattingEnabled = true;
            this.lstBoxDoviz.Location = new System.Drawing.Point(12, 26);
            this.lstBoxDoviz.Name = "lstBoxDoviz";
            this.lstBoxDoviz.Size = new System.Drawing.Size(123, 186);
            this.lstBoxDoviz.TabIndex = 0;
            this.lstBoxDoviz.SelectedIndexChanged += new System.EventHandler(this.lstBoxDoviz_SelectedINdexChanged);
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(24, 218);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(91, 21);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "button1";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(196, 26);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(35, 13);
            this.lblBirim.TabIndex = 2;
            this.lblBirim.Text = "label1";
            // 
            // lblAlıs
            // 
            this.lblAlıs.AutoSize = true;
            this.lblAlıs.Location = new System.Drawing.Point(196, 58);
            this.lblAlıs.Name = "lblAlıs";
            this.lblAlıs.Size = new System.Drawing.Size(35, 13);
            this.lblAlıs.TabIndex = 3;
            this.lblAlıs.Text = "label1";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(196, 90);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(35, 13);
            this.lblSatis.TabIndex = 4;
            this.lblSatis.Text = "label1";
            // 
            // dataGridVievDoviz
            // 
            this.dataGridVievDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVievDoviz.Location = new System.Drawing.Point(306, 26);
            this.dataGridVievDoviz.Name = "dataGridVievDoviz";
            this.dataGridVievDoviz.Size = new System.Drawing.Size(433, 115);
            this.dataGridVievDoviz.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "alış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "birim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "satış";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DovizAd,
            this.Satıs});
            this.dataGridView1.Location = new System.Drawing.Point(306, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 115);
            this.dataGridView1.TabIndex = 9;
            // 
            // DovizAd
            // 
            this.DovizAd.HeaderText = "Doviz Ad";
            this.DovizAd.Name = "DovizAd";
            // 
            // Satıs
            // 
            this.Satıs.HeaderText = "satış";
            this.Satıs.Name = "Satıs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridVievDoviz);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblAlıs);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.lstBoxDoviz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVievDoviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxDoviz;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblAlıs;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.DataGridView dataGridVievDoviz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovizAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satıs;
    }
}

