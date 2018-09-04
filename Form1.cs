using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SaltImageExplorer
{

    public delegate void sProcess(string imageKey);
    public delegate double valProcess(Bitmap img1, Bitmap mask, Func<float, bool> condition);
    public partial class Form1 : Form
    {
        ImageList imgs;
        string trainDir = @"C:\Research\MachineLearning\Salt\train\images";
        string maskDir = @"C:\Research\MachineLearning\Salt\train\masks";
        sProcess saltProcesses;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string dir = @"C:\Research\MachineLearning\Salt\train\images";
            //LoadImages(dir, -600, new Size(64,64));
            saltProcesses = new sProcess(LoadImageAndMask);
            saltProcesses += ShowNotSalt;
            saltProcesses += ShowSalt;
            saltProcesses += DoStats;


        }

        //Load images into imagelist
        private void LoadImages(string DirPath, int MaxNumberToLoad, Size ThumbnailSize)
        {
            DirectoryInfo di = new DirectoryInfo(DirPath);

            imgs = new ImageList();
            FileInfo[] pics = di.GetFiles("*.png");
            int Num = pics.Count();

            //Figure out how many images to load (MaxNumberToLoad < 0 will load all)
            if ((pics.Count() > MaxNumberToLoad) && (MaxNumberToLoad >= 0))
                Num = MaxNumberToLoad;

            for (int i = 0; i < Num; i++)
            {
                Image tmpImg = Bitmap.FromFile(pics[i].FullName);
                string tmpName = pics[i].Name;
                imgs.Images.Add(tmpName, tmpImg);
            }
            imgs.ImageSize = ThumbnailSize;
            LVImages.LargeImageList = imgs;
            
            foreach (string k in imgs.Images.Keys)
            {
                var listViewItem = LVImages.Items.Add(k);
                listViewItem.ImageKey = k;
            }
            
            
        }

        private void LVImages_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void LVImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVImages.SelectedIndices.Count > 0)
            {
                int iSelected = LVImages.SelectedIndices[0];
                if (iSelected >= 0)
                {
                    Console.WriteLine(LVImages.Items[iSelected].ImageKey);
                    //LoadImageAndMask(LVImages.Items[iSelected].ImageKey);
                    saltProcesses(LVImages.Items[iSelected].ImageKey);
                }
            }
        }

        private void LoadImageAndMask(string ImageKey)
        {
            pb_Image.ImageLocation = trainDir + "\\" + ImageKey;
            pb_Mask.ImageLocation = maskDir + "\\" + ImageKey;
        }

        private void ShowSalt(string ImageKey)
        {
            //Image img = Bitmap.FromFile(trainDir + "\\" + ImageKey);
            //Graphics g = Graphics.FromImage(img);
            Bitmap img1 = (Bitmap)Bitmap.FromFile(trainDir + "\\" + ImageKey);
            Bitmap mask = (Bitmap)Bitmap.FromFile(maskDir + "\\" + ImageKey);
            Bitmap res = ProcessImg(img1, mask, x => x > .5);


            pb_Salt.Image = (Image)res;
        }

        private void ShowNotSalt(string ImageKey)
        {
            Bitmap img1 = (Bitmap)Bitmap.FromFile(trainDir + "\\" + ImageKey);
            Bitmap mask = (Bitmap)Bitmap.FromFile(maskDir + "\\" + ImageKey);
            Bitmap res = ProcessImg(img1, mask, x => x < .5);


            pb_NotSalt.Image = (Image)res;
        }

        private void ShowOverlay(string ImageKey)
        {
            //pb_Overlay;
        }

        public void DoStats(string ImageKey) 
        {
            Bitmap img1 = (Bitmap)Bitmap.FromFile(trainDir + "\\" + ImageKey);
            Bitmap mask = (Bitmap)Bitmap.FromFile(maskDir + "\\" + ImageKey);
            //Bitmap res = ProcessImg(img1, mask, x => x < .5);
            double NotSaltVariance = getVariance(img1, mask, x => x < .5);
            double SaltVariance = getVariance(img1, mask, x => x > .5);
            lb_Result.Items.Add(String.Format("NotSalt: {0}, Salt: {1} | {2}", Math.Round(NotSaltVariance,4), Math.Round(SaltVariance,4), ImageKey));
        }

        public double getVariance(Bitmap img1, Bitmap mask, Func<float, bool> conditionToUse)
        {
            double result = 0;
            List<double> vals = new List<double>();
            int h = img1.Height;
            int w = img1.Width;
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    if (conditionToUse(mask.GetPixel(x, y).GetBrightness()))
                        vals.Add(Convert.ToDouble(img1.GetPixel(x, y).GetBrightness()));
                }
            }
            result = Variance(vals);

            return result;
        }

        public double Average(List<double> vals)
        {
            double res = 0.0;
            foreach (double x in vals)
                res += x;
            if (vals.Count > 0)
                return res / Convert.ToDouble(vals.Count);
            else
                return 0.0;
        }

        public double Variance(List<double> vals)
        {
            double avg = Average(vals);
            double res = 0;
            foreach (double x in vals)
                res += Math.Pow(avg-x, 2.0);

            if (vals.Count > 0)
                return res / Convert.ToDouble(vals.Count);
            else
                return 0.0;
        }

        private Bitmap ProcessImg(Bitmap img1, Bitmap mask, Func<float, bool> conditionToKeep)
        {
            int h = img1.Height;
            int w = img1.Width;
            
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    float val = mask.GetPixel(x, y).GetBrightness();
                    if (conditionToKeep(val))
                    {

                    }
                    else
                    {
                        img1.SetPixel(x, y, Color.Plum);
                    }
                }
            }

            return img1;
        }

        private void btn_PlotEm_Click(object sender, EventArgs e)
        {
            //chart1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            //chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            List<double> saltVars = new List<double>();
            List<double> noSaltVars = new List<double>();
            int NumberWithNoSalt = 0;
            for (int i = 0; i < LVImages.Items.Count; i++)
            {
                string keyName = LVImages.Items[i].ImageKey;
                Bitmap img1 = (Bitmap)Bitmap.FromFile(trainDir + "\\" + keyName);
                Bitmap mask = (Bitmap)Bitmap.FromFile(maskDir + "\\" + keyName);
                //Bitmap res = ProcessImg(img1, mask, x => x < .5);
                double NotSaltVariance = getVariance(img1, mask, x => x < .5);
                double SaltVariance = getVariance(img1, mask, x => x > .5);
                if (SaltVariance > 0)
                {
                    saltVars.Add(SaltVariance);
                    noSaltVars.Add(NotSaltVariance);
                }
                else
                    NumberWithNoSalt += 1;
            }
            chart1.Series[0].Name = "Salt";
            //chart1.Series[1].Name = "NoSalt";
            int NumberOfPositives = 0;
            for (int i = 0; i < saltVars.Count; i++)
            {
                int SGNS = saltVars[i] < noSaltVars[i] ? 1 : 0;
                if (saltVars[i] < noSaltVars[i])
                    NumberOfPositives += 1;
                double ratio = noSaltVars[i]/saltVars[i];
                if(ratio < 30)
                    chart1.Series[0].Points.AddXY(i, ratio);
                //chart1.Series[0].Points.AddXY(i, saltVars[i]);
                //chart1.Series[1].Points.AddXY(i, noSaltVars[i]);
            }
            MessageBox.Show("Number of positives: " + NumberOfPositives.ToString() + ", total: " + saltVars.Count.ToString() + " and Number with no salt: " + NumberWithNoSalt.ToString());

        }

        private void btn_LoadImages_Click(object sender, EventArgs e)
        {
            trainDir = tb_ImgDir.Text;
            maskDir = tb_MaskDir.Text;
            int MaxCount = Convert.ToInt32(tb_NumOfImgs.Text);
            LoadImages(trainDir, MaxCount, new Size(64, 64));
        }

        
    }
}
