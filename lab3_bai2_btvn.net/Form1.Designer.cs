namespace lab3_bai2_btvn.net
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChuyenHauTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.richTextBoxTrungTo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHauTo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN BIỂU THỨC TRUNG TỐ ĐẦY ĐỦ DẤU NGOẶC HOẶC SANG HẬU TỐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập biểu thức trung tố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(24, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Biểu thức hậu tố";
            // 
            // btnChuyenHauTo
            // 
            this.btnChuyenHauTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChuyenHauTo.Location = new System.Drawing.Point(247, 272);
            this.btnChuyenHauTo.Name = "btnChuyenHauTo";
            this.btnChuyenHauTo.Size = new System.Drawing.Size(129, 35);
            this.btnChuyenHauTo.TabIndex = 3;
            this.btnChuyenHauTo.Text = "Chuyển hậu tố";
            this.btnChuyenHauTo.UseVisualStyleBackColor = true;
            this.btnChuyenHauTo.Click += new System.EventHandler(this.btnChuyenHauTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(407, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 35);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // richTextBoxTrungTo
            // 
            this.richTextBoxTrungTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBoxTrungTo.Location = new System.Drawing.Point(27, 108);
            this.richTextBoxTrungTo.Name = "richTextBoxTrungTo";
            this.richTextBoxTrungTo.Size = new System.Drawing.Size(735, 117);
            this.richTextBoxTrungTo.TabIndex = 5;
            this.richTextBoxTrungTo.Text = "";
            // 
            // richTextBoxHauTo
            // 
            this.richTextBoxHauTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBoxHauTo.Location = new System.Drawing.Point(28, 376);
            this.richTextBoxHauTo.Name = "richTextBoxHauTo";
            this.richTextBoxHauTo.Size = new System.Drawing.Size(735, 117);
            this.richTextBoxHauTo.TabIndex = 6;
            this.richTextBoxHauTo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.richTextBoxHauTo);
            this.Controls.Add(this.richTextBoxTrungTo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChuyenHauTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChuyenHauTo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox richTextBoxTrungTo;
        private System.Windows.Forms.RichTextBox richTextBoxHauTo;
    }
}

