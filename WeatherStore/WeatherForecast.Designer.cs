namespace WeatherStore
{
    partial class WeatherForecast
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBxCity = new System.Windows.Forms.ComboBox();
            this.dateTimeCity = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.txtMaxi = new System.Windows.Forms.TextBox();
            this.txtPrecip = new System.Windows.Forms.TextBox();
            this.txtHumidty = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtMini = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.GridViewStore = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReportView = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStore)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "WEATHER FORECAST FOR GENERAL USER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather Forecast";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBxCity);
            this.groupBox2.Controls.Add(this.dateTimeCity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(449, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "City AND Date";
            // 
            // comboBxCity
            // 
            this.comboBxCity.FormattingEnabled = true;
            this.comboBxCity.Items.AddRange(new object[] {
            "Johannesburg",
            "Cape Town",
            "Bloemfontein",
            "Durban",
            "Pretoria",
            "Limpopo"});
            this.comboBxCity.Location = new System.Drawing.Point(133, 20);
            this.comboBxCity.Name = "comboBxCity";
            this.comboBxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBxCity.TabIndex = 5;
            // 
            // dateTimeCity
            // 
            this.dateTimeCity.Location = new System.Drawing.Point(130, 58);
            this.dateTimeCity.Name = "dateTimeCity";
            this.dateTimeCity.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHOOSE CITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherStore.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnCapture);
            this.groupBox3.Controls.Add(this.txtMaxi);
            this.groupBox3.Controls.Add(this.txtPrecip);
            this.groupBox3.Controls.Add(this.txtHumidty);
            this.groupBox3.Controls.Add(this.txtWind);
            this.groupBox3.Controls.Add(this.txtMini);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(7, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 149);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Capture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(101, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Storing Values To The Weather Forecast Database";
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCapture.Location = new System.Drawing.Point(582, 37);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(124, 35);
            this.btnCapture.TabIndex = 10;
            this.btnCapture.Text = "CAPTURE TO STORE";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtMaxi
            // 
            this.txtMaxi.Location = new System.Drawing.Point(443, 56);
            this.txtMaxi.Name = "txtMaxi";
            this.txtMaxi.Size = new System.Drawing.Size(100, 20);
            this.txtMaxi.TabIndex = 9;
            this.txtMaxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxi_KeyPress);
            // 
            // txtPrecip
            // 
            this.txtPrecip.Location = new System.Drawing.Point(171, 82);
            this.txtPrecip.Name = "txtPrecip";
            this.txtPrecip.Size = new System.Drawing.Size(100, 20);
            this.txtPrecip.TabIndex = 8;
            this.txtPrecip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecip_KeyPress);
            // 
            // txtHumidty
            // 
            this.txtHumidty.Location = new System.Drawing.Point(443, 89);
            this.txtHumidty.Name = "txtHumidty";
            this.txtHumidty.Size = new System.Drawing.Size(100, 20);
            this.txtHumidty.TabIndex = 7;
            this.txtHumidty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHumidty_KeyPress);
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(314, 120);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(100, 20);
            this.txtWind.TabIndex = 6;
            this.txtWind.TextChanged += new System.EventHandler(this.txtWind_TextChanged);
            this.txtWind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWind_KeyPress);
            // 
            // txtMini
            // 
            this.txtMini.Location = new System.Drawing.Point(171, 56);
            this.txtMini.Name = "txtMini";
            this.txtMini.Size = new System.Drawing.Size(100, 20);
            this.txtMini.TabIndex = 5;
            this.txtMini.TextChanged += new System.EventHandler(this.txtMini_TextChanged);
            this.txtMini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMini_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "WIND SPEED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "HUMIDITY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "PRECIPITATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "MAXIMUM TEMPERATURE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MINIMUM TEMPERATURE";
            // 
            // btnViewData
            // 
            this.btnViewData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnViewData.Location = new System.Drawing.Point(416, 33);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(124, 35);
            this.btnViewData.TabIndex = 11;
            this.btnViewData.Text = "GENERAL  USER";
            this.btnViewData.UseVisualStyleBackColor = false;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(770, 701);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GridViewStore
            // 
            this.GridViewStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.GridViewStore.Location = new System.Drawing.Point(7, 574);
            this.GridViewStore.Name = "GridViewStore";
            this.GridViewStore.Size = new System.Drawing.Size(739, 150);
            this.GridViewStore.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "City";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Minimum Temp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Maximum Temp";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Humidity";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Preciptation";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Wind Speed";
            this.Column7.Name = "Column7";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReportView);
            this.groupBox4.Controls.Add(this.btnViewData);
            this.groupBox4.Controls.Add(this.btnSingle);
            this.groupBox4.Controls.Add(this.btnMultiple);
            this.groupBox4.Location = new System.Drawing.Point(81, 462);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(547, 83);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // btnReportView
            // 
            this.btnReportView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReportView.Location = new System.Drawing.Point(31, 33);
            this.btnReportView.Name = "btnReportView";
            this.btnReportView.Size = new System.Drawing.Size(107, 35);
            this.btnReportView.TabIndex = 15;
            this.btnReportView.Text = "REPORT VIEW";
            this.btnReportView.UseVisualStyleBackColor = false;
            this.btnReportView.Click += new System.EventHandler(this.btnReportView_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSingle.Location = new System.Drawing.Point(159, 33);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(107, 35);
            this.btnSingle.TabIndex = 14;
            this.btnSingle.Text = "SINGLE VIEW";
            this.btnSingle.UseVisualStyleBackColor = false;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMultiple.Location = new System.Drawing.Point(296, 33);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(100, 35);
            this.btnMultiple.TabIndex = 13;
            this.btnMultiple.Text = "MULTIPLE VIEW";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 741);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GridViewStore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "WeatherForecast";
            this.Text = "WeatherForecast";
            this.Load += new System.EventHandler(this.WeatherForecast_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStore)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox txtMaxi;
        private System.Windows.Forms.TextBox txtPrecip;
        private System.Windows.Forms.TextBox txtHumidty;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtMini;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBxCity;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView GridViewStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnReportView;
    }
}