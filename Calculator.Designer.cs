
namespace congtrunhanchia
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "nhập b";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(193, 82);
            this.txta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(162, 23);
            this.txta.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(66, 190);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(82, 22);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "Cộng";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(167, 190);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(82, 22);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "Trừ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiple.Location = new System.Drawing.Point(265, 190);
            this.btnMultiple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(82, 22);
            this.btnMultiple.TabIndex = 7;
            this.btnMultiple.Text = "Nhân";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(364, 190);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(82, 22);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "Chia";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kết quả:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(206, 258);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(0, 15);
            this.lblkq.TabIndex = 12;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(193, 129);
            this.txtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(162, 23);
            this.txtb.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 338);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtb;
    }
}

