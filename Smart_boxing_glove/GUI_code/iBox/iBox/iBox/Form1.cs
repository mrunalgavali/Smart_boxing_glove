
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Data.SQLite;

namespace iBox
{
    public partial class Form1 : Form
    {
        //define variables
        OpenFileDialog openFile = new OpenFileDialog();
        Boolean fileRead = false;
        string[] fileData;
        string fileComma;
        float[] importVals;
        float[] tempVals;
        float[] xVals;
        float[] yVals;
        float[] zVals;
        float[] heartVals;

        int xPunchCount = 0;
        int yPunchCount = 0;
        int zPunchCount = 0;

        float maxTemp;
        float minTemp;
        float avgTemp;

        float maxHeart;
        float minHeart;
        float avgHeart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)//Allows if an appropriate file is selected
            {
                fileRead = true;//Lets the system know a file has been selected so other functions can be used
                fileData = File.ReadAllLines(openFile.FileName);//Read data from file selected from dialog box
                fileComma = string.Join(",", fileData);//joins all items in fileData by comma
                importVals = Array.ConvertAll(fileComma.Split(','), float.Parse);//Splits all items into an array by comma
                int j = 0;//initialise count variable
                heartVals = new float[importVals.Length / 5];//initialise array for heart values
                tempVals = new float[importVals.Length / 5];//initialise array for temp values
                xVals = new float[importVals.Length / 5];//initialise array for x values
                yVals = new float[importVals.Length / 5];//initialise array for y values
                zVals = new float[importVals.Length / 5];//initialise array for z values

                //loop assigns values for temp, x, y and z to their own arrays from the importVals array
                for (int i = 0; i < importVals.Length; i += 5)
                {
                    heartVals[j] = importVals[i];
                    tempVals[j] = importVals[i + 1];
                    xVals[j] = importVals[i + 2];
                    yVals[j] = importVals[i + 3];
                    zVals[j] = importVals[i + 4];
                    j++;
                }
                //loop checks if the accelerometer values have gone high enough to indicate a punch and adds to variable if it has
                for (int i = 0; i < xVals.Length; i++)
                {
                    if (xVals[i] > 0.1)
                    {
                        xPunchCount++;
                    }
                    if (yVals[i] > 0.15)
                    {
                        yPunchCount++;
                    }
                    if (zVals[i] > 0.6)
                    {
                        zPunchCount++;
                    }
                }



            }


        }

        private void btnHeart_Click(object sender, EventArgs e)
        {


            if (fileRead == true)
            {
                txbData.Clear();
                txbAvg.Clear();
                maxHeart = heartVals[0];
                minHeart = heartVals[0];
                avgHeart = 0;

                foreach (var item in heartVals)//writes all items to text box
                {
                    AppendTextBox(item.ToString());
                }

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < heartVals.Length; i++)
                {
                    // this.chrtData.
                    this.chrtData.Series["Data"].Points.AddXY(i + 1, heartVals[i]);
                }

                for (int j = 0; j < heartVals.Length; j++)
                {
                    if (heartVals[j] > maxHeart)
                    {
                        maxHeart = heartVals[j];

                    }

                }

                for (int j = 0; j < heartVals.Length; j++)
                {
                    if (heartVals[j] < minHeart)
                    {
                        minHeart = heartVals[j];

                    }

                }

                for (int j = 0; j < heartVals.Length; j++)
                {
                    avgHeart += heartVals[j];

                }
                avgHeart = avgHeart / heartVals.Length;
                avgHeart = (float)Math.Round(avgHeart);

                AddTextBox("Maximum Heart Rate: " + maxHeart.ToString());
                AddTextBox("Minimum Heart Rate: " + minHeart.ToString());
                AddTextBox("Average Heart Rate: " + avgHeart.ToString());


            }

            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }
        }


        private void btnAccelX_Click(object sender, EventArgs e)
        {
            if (fileRead == true)//error checking if a file has been read in yet 
            {
                txbData.Clear();
                txbAvg.Clear();

                foreach (var item in xVals)//writes all items to text box
                {
                    AppendTextBox(item.ToString());
                }

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < xVals.Length; i++)
                {
                    // this.chrtData.
                    this.chrtData.Series["Data"].Points.AddXY(i + 1, xVals[i]);
                }
            }
            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }
        }

        private void bntAccelY_Click(object sender, EventArgs e)
        {
            if (fileRead == true)//error checking if a file has been read in yet
            {
                txbData.Clear();
                txbAvg.Clear();

                foreach (var item in yVals)//writes all items to text box
                {
                    AppendTextBox(item.ToString());
                }

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < yVals.Length; i++)
                {
                    // this.chrtData.
                    this.chrtData.Series["Data"].Points.AddXY(i + 1, yVals[i]);
                }
            }
            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }
        }

        private void btnAccelZ_Click(object sender, EventArgs e)
        {
            if (fileRead == true)//error checking if a file has been read in yet
            {
                txbData.Clear();
                txbAvg.Clear();

                foreach (var item in zVals)//writes all items to text box
                {
                    AppendTextBox(item.ToString());
                }

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < zVals.Length; i++)
                {
                    // this.chrtData.
                    this.chrtData.Series["Data"].Points.AddXY(i + 1, zVals[i]);
                }
            }
            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (fileRead == true)//error checking if a file has been read in yet
            {
                txbData.Clear();
                txbAvg.Clear();
                maxTemp = tempVals[0];
                minTemp = tempVals[0];
                avgTemp = 0;

                foreach (var item in tempVals)//writes all items to text box
                {
                    AppendTextBox(item.ToString());
                }

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < tempVals.Length; i++)
                {
                    // this.chrtData.
                    this.chrtData.Series["Data"].Points.AddXY(i + 1, tempVals[i]);
                }

                for (int j = 0; j < tempVals.Length; j++)
                {
                    if (tempVals[j] > maxTemp)
                    {
                        maxTemp = tempVals[j];

                    }

                }

                for (int j = 0; j < tempVals.Length; j++)
                {
                    if (tempVals[j] < minTemp)
                    {
                        minTemp = tempVals[j];

                    }

                }

                for (int j = 0; j < tempVals.Length; j++)
                {
                    avgTemp += tempVals[j];

                }
                avgTemp = avgTemp / tempVals.Length;
                avgTemp = (float)Math.Round(avgTemp);

                AddTextBox("Maximum Skin Temperature: " + maxTemp.ToString());
                AddTextBox("Minimum Skin Temperature: " + minTemp.ToString());
                AddTextBox("Average Skin Temperature: " + avgTemp.ToString());
            }
            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }
        }

        public void AppendTextBox(string value) //allows text to be added from any source
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txbData.Text += value + "\r\n";

        }

        public void AddTextBox(string value) //allows text to be added from any source
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AddTextBox), new object[] { value });
                return;
            }
            txbAvg.Text += value + "\r\n";

        }



       

        /*
        private void btnHits_Click(object sender, EventArgs e)
        {
            if (fileRead == true)//error checking if a file has been read in yet
            {
                txbData.Clear();
                txbAvg.Clear();

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                AppendTextBox("Hits detected on X: " + xPunchCount.ToString());
                AppendTextBox("Hits detected on Y: " + yPunchCount.ToString());
                AppendTextBox("Hits detected on Z: " + zPunchCount.ToString());
            }
            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }
        }

        */
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void btnHits_Click_1(object sender, EventArgs e)
        {
            if (fileRead == true)//error checking if a file has been read in yet
            {
                txbData.Clear();
                txbAvg.Clear();

                foreach (var series in chrtData.Series)//Clears the graph
                {
                    series.Points.Clear();
                }

                AppendTextBox("Hits detected on X: " + xPunchCount.ToString());
                AppendTextBox("Hits detected on Y: " + yPunchCount.ToString());
                AppendTextBox("Hits detected on Z: " + zPunchCount.ToString());
            }
            else
            {
                MessageBox.Show("Please read in a file before using this function");

            }

        }
    }
}





     

       
