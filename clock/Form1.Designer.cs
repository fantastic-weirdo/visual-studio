namespace clock
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
            this.components = new System.ComponentModel.Container();
            this.txtClock = new System.Windows.Forms.TextBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.cmbMin1 = new System.Windows.Forms.ComboBox();
            this.cmbHour1 = new System.Windows.Forms.ComboBox();
            this.cmbMin2 = new System.Windows.Forms.ComboBox();
            this.cmbHour2 = new System.Windows.Forms.ComboBox();
            this.cmbMin3 = new System.Windows.Forms.ComboBox();
            this.cmbHour3 = new System.Windows.Forms.ComboBox();
            this.cmbMin4 = new System.Windows.Forms.ComboBox();
            this.cmbHour4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtClock
            // 
            this.txtClock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtClock.Enabled = false;
            this.txtClock.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtClock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClock.Location = new System.Drawing.Point(71, 32);
            this.txtClock.Name = "txtClock";
            this.txtClock.Size = new System.Drawing.Size(640, 114);
            this.txtClock.TabIndex = 0;
            this.txtClock.Text = "18:05:50";
            this.txtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbHour
            // 
            this.cmbHour.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(71, 165);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(168, 37);
            this.cmbHour.TabIndex = 1;
            // 
            // cmbMin
            // 
            this.cmbMin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(255, 165);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(168, 37);
            this.cmbMin.TabIndex = 2;
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOn.Location = new System.Drawing.Point(481, 165);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(230, 64);
            this.btnOn.TabIndex = 11;
            this.btnOn.Text = "啟動鬧鐘";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOff.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOff.Location = new System.Drawing.Point(481, 255);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(230, 64);
            this.btnOff.TabIndex = 12;
            this.btnOff.Text = "關閉鬧鐘";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // timerClcok
            // 
            this.timerClcok.Tick += new System.EventHandler(this.timerClcok_Tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // cmbMin1
            // 
            this.cmbMin1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin1.FormattingEnabled = true;
            this.cmbMin1.Location = new System.Drawing.Point(255, 219);
            this.cmbMin1.Name = "cmbMin1";
            this.cmbMin1.Size = new System.Drawing.Size(168, 37);
            this.cmbMin1.TabIndex = 14;
            // 
            // cmbHour1
            // 
            this.cmbHour1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour1.FormattingEnabled = true;
            this.cmbHour1.Location = new System.Drawing.Point(71, 219);
            this.cmbHour1.Name = "cmbHour1";
            this.cmbHour1.Size = new System.Drawing.Size(168, 37);
            this.cmbHour1.TabIndex = 13;
            // 
            // cmbMin2
            // 
            this.cmbMin2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin2.FormattingEnabled = true;
            this.cmbMin2.Location = new System.Drawing.Point(255, 272);
            this.cmbMin2.Name = "cmbMin2";
            this.cmbMin2.Size = new System.Drawing.Size(168, 37);
            this.cmbMin2.TabIndex = 16;
            // 
            // cmbHour2
            // 
            this.cmbHour2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour2.FormattingEnabled = true;
            this.cmbHour2.Location = new System.Drawing.Point(71, 272);
            this.cmbHour2.Name = "cmbHour2";
            this.cmbHour2.Size = new System.Drawing.Size(168, 37);
            this.cmbHour2.TabIndex = 15;
            // 
            // cmbMin3
            // 
            this.cmbMin3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin3.FormattingEnabled = true;
            this.cmbMin3.Location = new System.Drawing.Point(255, 328);
            this.cmbMin3.Name = "cmbMin3";
            this.cmbMin3.Size = new System.Drawing.Size(168, 37);
            this.cmbMin3.TabIndex = 18;
            // 
            // cmbHour3
            // 
            this.cmbHour3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour3.FormattingEnabled = true;
            this.cmbHour3.Location = new System.Drawing.Point(71, 328);
            this.cmbHour3.Name = "cmbHour3";
            this.cmbHour3.Size = new System.Drawing.Size(168, 37);
            this.cmbHour3.TabIndex = 17;
            // 
            // cmbMin4
            // 
            this.cmbMin4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbMin4.FormattingEnabled = true;
            this.cmbMin4.Location = new System.Drawing.Point(255, 384);
            this.cmbMin4.Name = "cmbMin4";
            this.cmbMin4.Size = new System.Drawing.Size(168, 37);
            this.cmbMin4.TabIndex = 20;
            // 
            // cmbHour4
            // 
            this.cmbHour4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbHour4.FormattingEnabled = true;
            this.cmbHour4.Location = new System.Drawing.Point(71, 384);
            this.cmbHour4.Name = "cmbHour4";
            this.cmbHour4.Size = new System.Drawing.Size(168, 37);
            this.cmbHour4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMin4);
            this.Controls.Add(this.cmbHour4);
            this.Controls.Add(this.cmbMin3);
            this.Controls.Add(this.cmbHour3);
            this.Controls.Add(this.cmbMin2);
            this.Controls.Add(this.cmbHour2);
            this.Controls.Add(this.cmbMin1);
            this.Controls.Add(this.cmbHour1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.cmbMin);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.txtClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClock;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Timer timerClcok;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.ComboBox cmbMin1;
        private System.Windows.Forms.ComboBox cmbHour1;
        private System.Windows.Forms.ComboBox cmbMin2;
        private System.Windows.Forms.ComboBox cmbHour2;
        private System.Windows.Forms.ComboBox cmbMin3;
        private System.Windows.Forms.ComboBox cmbHour3;
        private System.Windows.Forms.ComboBox cmbMin4;
        private System.Windows.Forms.ComboBox cmbHour4;
    }
}

