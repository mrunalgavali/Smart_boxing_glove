
namespace iBox
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRead = new System.Windows.Forms.Button();
            this.btnHeart = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnAccelX = new System.Windows.Forms.Button();
            this.btnAccelY = new System.Windows.Forms.Button();
            this.btnAccelZ = new System.Windows.Forms.Button();
            this.txbAvg = new System.Windows.Forms.TextBox();
            this.txbData = new System.Windows.Forms.TextBox();
            this.chrtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btnHits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.Indigo;
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(12, 114);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(219, 62);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnHeart
            // 
            this.btnHeart.BackColor = System.Drawing.Color.Indigo;
            this.btnHeart.FlatAppearance.BorderSize = 0;
            this.btnHeart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnHeart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeart.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeart.ForeColor = System.Drawing.Color.White;
            this.btnHeart.Location = new System.Drawing.Point(12, 182);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Size = new System.Drawing.Size(219, 54);
            this.btnHeart.TabIndex = 1;
            this.btnHeart.Text = "Heart Rate";
            this.btnHeart.UseVisualStyleBackColor = false;
            this.btnHeart.Click += new System.EventHandler(this.btnHeart_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.BackColor = System.Drawing.Color.Indigo;
            this.btnTemp.FlatAppearance.BorderSize = 0;
            this.btnTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemp.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.ForeColor = System.Drawing.Color.White;
            this.btnTemp.Location = new System.Drawing.Point(12, 242);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(219, 53);
            this.btnTemp.TabIndex = 2;
            this.btnTemp.Text = "Body Temperature";
            this.btnTemp.UseVisualStyleBackColor = false;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnAccelX
            // 
            this.btnAccelX.BackColor = System.Drawing.Color.Indigo;
            this.btnAccelX.FlatAppearance.BorderSize = 0;
            this.btnAccelX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAccelX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccelX.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccelX.ForeColor = System.Drawing.Color.White;
            this.btnAccelX.Location = new System.Drawing.Point(12, 301);
            this.btnAccelX.Name = "btnAccelX";
            this.btnAccelX.Size = new System.Drawing.Size(219, 57);
            this.btnAccelX.TabIndex = 4;
            this.btnAccelX.Text = "Accel X";
            this.btnAccelX.UseVisualStyleBackColor = false;
            this.btnAccelX.Click += new System.EventHandler(this.btnAccelX_Click);
            // 
            // btnAccelY
            // 
            this.btnAccelY.BackColor = System.Drawing.Color.Indigo;
            this.btnAccelY.FlatAppearance.BorderSize = 0;
            this.btnAccelY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAccelY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccelY.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccelY.ForeColor = System.Drawing.Color.White;
            this.btnAccelY.Location = new System.Drawing.Point(12, 364);
            this.btnAccelY.Name = "btnAccelY";
            this.btnAccelY.Size = new System.Drawing.Size(219, 53);
            this.btnAccelY.TabIndex = 5;
            this.btnAccelY.Text = "Accel Y";
            this.btnAccelY.UseVisualStyleBackColor = false;
            this.btnAccelY.Click += new System.EventHandler(this.bntAccelY_Click);
            // 
            // btnAccelZ
            // 
            this.btnAccelZ.BackColor = System.Drawing.Color.Indigo;
            this.btnAccelZ.FlatAppearance.BorderSize = 0;
            this.btnAccelZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnAccelZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccelZ.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccelZ.ForeColor = System.Drawing.Color.White;
            this.btnAccelZ.Location = new System.Drawing.Point(12, 424);
            this.btnAccelZ.Name = "btnAccelZ";
            this.btnAccelZ.Size = new System.Drawing.Size(219, 56);
            this.btnAccelZ.TabIndex = 6;
            this.btnAccelZ.Text = "Accel Z";
            this.btnAccelZ.UseVisualStyleBackColor = false;
            this.btnAccelZ.Click += new System.EventHandler(this.btnAccelZ_Click);
            // 
            // txbAvg
            // 
            this.txbAvg.BackColor = System.Drawing.SystemColors.InfoText;
            this.txbAvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAvg.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAvg.ForeColor = System.Drawing.Color.White;
            this.txbAvg.Location = new System.Drawing.Point(986, 313);
            this.txbAvg.Multiline = true;
            this.txbAvg.Name = "txbAvg";
            this.txbAvg.Size = new System.Drawing.Size(344, 166);
            this.txbAvg.TabIndex = 7;
            // 
            // txbData
            // 
            this.txbData.BackColor = System.Drawing.SystemColors.WindowText;
            this.txbData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbData.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.ForeColor = System.Drawing.Color.White;
            this.txbData.Location = new System.Drawing.Point(986, 114);
            this.txbData.Multiline = true;
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(344, 166);
            this.txbData.TabIndex = 8;
            // 
            // chrtData
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtData.Legends.Add(legend1);
            this.chrtData.Location = new System.Drawing.Point(263, 119);
            this.chrtData.Name = "chrtData";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DarkViolet;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            this.chrtData.Series.Add(series1);
            this.chrtData.Size = new System.Drawing.Size(700, 361);
            this.chrtData.TabIndex = 9;
            this.chrtData.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(516, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Boxing Glove Dashboard";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1338, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Indigo;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(12, 46);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(219, 62);
            this.btn_Home.TabIndex = 16;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btnHits
            // 
            this.btnHits.BackColor = System.Drawing.Color.Indigo;
            this.btnHits.FlatAppearance.BorderSize = 0;
            this.btnHits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnHits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHits.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHits.ForeColor = System.Drawing.Color.White;
            this.btnHits.Location = new System.Drawing.Point(12, 486);
            this.btnHits.Name = "btnHits";
            this.btnHits.Size = new System.Drawing.Size(219, 56);
            this.btnHits.TabIndex = 17;
            this.btnHits.Text = "Punch Counter";
            this.btnHits.UseVisualStyleBackColor = false;
            this.btnHits.Click += new System.EventHandler(this.btnHits_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1365, 589);
            this.Controls.Add(this.btnHits);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrtData);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.txbAvg);
            this.Controls.Add(this.btnAccelZ);
            this.Controls.Add(this.btnAccelY);
            this.Controls.Add(this.btnAccelX);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnHeart);
            this.Controls.Add(this.btnRead);
            this.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnHeart;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnAccelX;
        private System.Windows.Forms.Button btnAccelY;
        private System.Windows.Forms.Button btnAccelZ;
        private System.Windows.Forms.TextBox txbAvg;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btnHits;
    }
}

