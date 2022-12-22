namespace ExamResultSystem
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnShowResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPoint = new System.Windows.Forms.NumericUpDown();
            this.LblGrade = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblHappy = new System.Windows.Forms.Label();
            this.LblSad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınav Sonucu Hesapla";
            // 
            // BtnShowResult
            // 
            this.BtnShowResult.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnShowResult.FlatAppearance.BorderSize = 0;
            this.BtnShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnShowResult.Location = new System.Drawing.Point(210, 77);
            this.BtnShowResult.Name = "BtnShowResult";
            this.BtnShowResult.Size = new System.Drawing.Size(115, 27);
            this.BtnShowResult.TabIndex = 2;
            this.BtnShowResult.Text = "Sonuç &Göster";
            this.BtnShowResult.UseVisualStyleBackColor = false;
            this.BtnShowResult.Click += new System.EventHandler(this.BtnShowResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sınav Puanı";
            // 
            // TxtPoint
            // 
            this.TxtPoint.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPoint.Location = new System.Drawing.Point(16, 77);
            this.TxtPoint.Name = "TxtPoint";
            this.TxtPoint.Size = new System.Drawing.Size(188, 26);
            this.TxtPoint.TabIndex = 4;
            // 
            // LblGrade
            // 
            this.LblGrade.AutoSize = true;
            this.LblGrade.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrade.Location = new System.Drawing.Point(15, 127);
            this.LblGrade.Name = "LblGrade";
            this.LblGrade.Size = new System.Drawing.Size(37, 41);
            this.LblGrade.TabIndex = 5;
            this.LblGrade.Text = "_";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(67, 135);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(89, 26);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "_______";
            // 
            // LblHappy
            // 
            this.LblHappy.AutoSize = true;
            this.LblHappy.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHappy.ForeColor = System.Drawing.Color.Green;
            this.LblHappy.Location = new System.Drawing.Point(133, 122);
            this.LblHappy.Name = "LblHappy";
            this.LblHappy.Size = new System.Drawing.Size(56, 43);
            this.LblHappy.TabIndex = 7;
            this.LblHappy.Text = "☻";
            this.LblHappy.Visible = false;
            // 
            // LblSad
            // 
            this.LblSad.AutoSize = true;
            this.LblSad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSad.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblSad.Location = new System.Drawing.Point(175, 129);
            this.LblSad.Name = "LblSad";
            this.LblSad.Size = new System.Drawing.Size(54, 37);
            this.LblSad.TabIndex = 8;
            this.LblSad.Text = "☹";
            this.LblSad.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 188);
            this.Controls.Add(this.LblSad);
            this.Controls.Add(this.LblHappy);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblGrade);
            this.Controls.Add(this.TxtPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnShowResult);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Sınav Sonuçları";
            ((System.ComponentModel.ISupportInitialize)(this.TxtPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnShowResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TxtPoint;
        private System.Windows.Forms.Label LblGrade;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblHappy;
        private System.Windows.Forms.Label LblSad;
    }
}

