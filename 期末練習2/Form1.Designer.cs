namespace 期末練習2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(174, 251);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(178, 45);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "計算BMI";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "身高";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "體重";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "BMI";
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(228, 117);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(179, 25);
            this.txt_height.TabIndex = 4;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(228, 178);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(179, 25);
            this.txt_weight.TabIndex = 5;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(228, 322);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(179, 25);
            this.txt_result.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(408, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(413, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

