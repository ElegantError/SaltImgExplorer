namespace SaltImageExplorer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LVImages = new System.Windows.Forms.ListView();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.pb_Mask = new System.Windows.Forms.PictureBox();
            this.pb_Overlay = new System.Windows.Forms.PictureBox();
            this.pb_Salt = new System.Windows.Forms.PictureBox();
            this.pb_NotSalt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_PlotEm = new System.Windows.Forms.Button();
            this.btn_LoadImages = new System.Windows.Forms.Button();
            this.tb_ImgDir = new System.Windows.Forms.TextBox();
            this.tb_MaskDir = new System.Windows.Forms.TextBox();
            this.tb_NumOfImgs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Overlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Salt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NotSalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LVImages
            // 
            this.LVImages.Location = new System.Drawing.Point(12, 12);
            this.LVImages.Name = "LVImages";
            this.LVImages.Size = new System.Drawing.Size(289, 535);
            this.LVImages.TabIndex = 0;
            this.LVImages.UseCompatibleStateImageBehavior = false;
            this.LVImages.SelectedIndexChanged += new System.EventHandler(this.LVImages_SelectedIndexChanged);
            this.LVImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LVImages_MouseClick);
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(344, 45);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(202, 202);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 1;
            this.pb_Image.TabStop = false;
            // 
            // pb_Mask
            // 
            this.pb_Mask.Location = new System.Drawing.Point(609, 45);
            this.pb_Mask.Name = "pb_Mask";
            this.pb_Mask.Size = new System.Drawing.Size(202, 202);
            this.pb_Mask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mask.TabIndex = 2;
            this.pb_Mask.TabStop = false;
            // 
            // pb_Overlay
            // 
            this.pb_Overlay.Location = new System.Drawing.Point(851, 45);
            this.pb_Overlay.Name = "pb_Overlay";
            this.pb_Overlay.Size = new System.Drawing.Size(202, 202);
            this.pb_Overlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Overlay.TabIndex = 3;
            this.pb_Overlay.TabStop = false;
            // 
            // pb_Salt
            // 
            this.pb_Salt.Location = new System.Drawing.Point(344, 294);
            this.pb_Salt.Name = "pb_Salt";
            this.pb_Salt.Size = new System.Drawing.Size(202, 202);
            this.pb_Salt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Salt.TabIndex = 4;
            this.pb_Salt.TabStop = false;
            // 
            // pb_NotSalt
            // 
            this.pb_NotSalt.Location = new System.Drawing.Point(609, 294);
            this.pb_NotSalt.Name = "pb_NotSalt";
            this.pb_NotSalt.Size = new System.Drawing.Size(202, 202);
            this.pb_NotSalt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NotSalt.TabIndex = 5;
            this.pb_NotSalt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Overlay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Not salt";
            // 
            // lb_Result
            // 
            this.lb_Result.FormattingEnabled = true;
            this.lb_Result.ItemHeight = 16;
            this.lb_Result.Location = new System.Drawing.Point(851, 294);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(311, 212);
            this.lb_Result.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(344, 552);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(818, 412);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // btn_PlotEm
            // 
            this.btn_PlotEm.Location = new System.Drawing.Point(1208, 924);
            this.btn_PlotEm.Name = "btn_PlotEm";
            this.btn_PlotEm.Size = new System.Drawing.Size(75, 23);
            this.btn_PlotEm.TabIndex = 13;
            this.btn_PlotEm.Text = "PlotEm";
            this.btn_PlotEm.UseVisualStyleBackColor = true;
            this.btn_PlotEm.Click += new System.EventHandler(this.btn_PlotEm_Click);
            // 
            // btn_LoadImages
            // 
            this.btn_LoadImages.Location = new System.Drawing.Point(226, 680);
            this.btn_LoadImages.Name = "btn_LoadImages";
            this.btn_LoadImages.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadImages.TabIndex = 14;
            this.btn_LoadImages.Text = "Load";
            this.btn_LoadImages.UseVisualStyleBackColor = true;
            this.btn_LoadImages.Click += new System.EventHandler(this.btn_LoadImages_Click);
            // 
            // tb_ImgDir
            // 
            this.tb_ImgDir.Location = new System.Drawing.Point(12, 571);
            this.tb_ImgDir.Name = "tb_ImgDir";
            this.tb_ImgDir.Size = new System.Drawing.Size(289, 22);
            this.tb_ImgDir.TabIndex = 15;
            this.tb_ImgDir.Text = "C:\\Research\\MachineLearning\\Salt\\train\\images";
            // 
            // tb_MaskDir
            // 
            this.tb_MaskDir.Location = new System.Drawing.Point(12, 620);
            this.tb_MaskDir.Name = "tb_MaskDir";
            this.tb_MaskDir.Size = new System.Drawing.Size(289, 22);
            this.tb_MaskDir.TabIndex = 16;
            this.tb_MaskDir.Text = "C:\\Research\\MachineLearning\\Salt\\train\\masks";
            // 
            // tb_NumOfImgs
            // 
            this.tb_NumOfImgs.Location = new System.Drawing.Point(12, 681);
            this.tb_NumOfImgs.Name = "tb_NumOfImgs";
            this.tb_NumOfImgs.Size = new System.Drawing.Size(128, 22);
            this.tb_NumOfImgs.TabIndex = 17;
            this.tb_NumOfImgs.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Img Dir:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mask Dir:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 661);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Num of imgs to load:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(848, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Variance Inspector";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 706);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "(Value < 0 => load all)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 976);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_NumOfImgs);
            this.Controls.Add(this.tb_MaskDir);
            this.Controls.Add(this.tb_ImgDir);
            this.Controls.Add(this.btn_LoadImages);
            this.Controls.Add(this.btn_PlotEm);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_NotSalt);
            this.Controls.Add(this.pb_Salt);
            this.Controls.Add(this.pb_Overlay);
            this.Controls.Add(this.pb_Mask);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.LVImages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Overlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Salt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NotSalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVImages;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.PictureBox pb_Mask;
        private System.Windows.Forms.PictureBox pb_Overlay;
        private System.Windows.Forms.PictureBox pb_Salt;
        private System.Windows.Forms.PictureBox pb_NotSalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_Result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_PlotEm;
        private System.Windows.Forms.Button btn_LoadImages;
        private System.Windows.Forms.TextBox tb_ImgDir;
        private System.Windows.Forms.TextBox tb_MaskDir;
        private System.Windows.Forms.TextBox tb_NumOfImgs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

