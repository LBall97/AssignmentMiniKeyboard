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
using MyDialogs;

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Str_KeyStrokes;
        string FilePath = Directory.GetCurrentDirectory() + "\\";
        string FileName;
        int ClickCount = -1;
        int IntIntervalRequired = 500;
        bool FirstVisit = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            if (TxtMode.Text == "Multi-Press")
            {
                TxtMode.Text = "Prediction";
            }
            else
            {
                TxtMode.Text = "Multi-Press";
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            WithinTimer.Enabled = false;
            Timer1.Enabled = false;
            if (FirstVisit == true)
            {
                ClickCount++;
                LstBoxMain.Items.Clear();
                for (int i = 0; i < LstBoxButton7.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton7.Items[i].ToString());
                }
                
                Timer1.Enabled = true;
            }
            else
            {
                WithinTimer.Enabled = true;
                ClickCount++;
            }
            Str_KeyStrokes = "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "a";
            SelectedChar[1] = "b";
            SelectedChar[2] = "c";
            SelectedChar[3] = "8";
            SelectedChar[4] = "A";
            SelectedChar[5] = "B";
            SelectedChar[6] = "C";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count-1]);
            Str_KeyStrokes = "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "d";
            SelectedChar[1] = "e";
            SelectedChar[2] = "f";
            SelectedChar[3] = "9";
            SelectedChar[4] = "D";
            SelectedChar[5] = "E";
            SelectedChar[6] = "F";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "9";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "g";
            SelectedChar[1] = "h";
            SelectedChar[2] = "i";
            SelectedChar[3] = "4";
            SelectedChar[4] = "G";
            SelectedChar[5] = "H";
            SelectedChar[6] = "I";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "j";
            SelectedChar[1] = "k";
            SelectedChar[2] = "l";
            SelectedChar[3] = "5";
            SelectedChar[4] = "J";
            SelectedChar[5] = "K";
            SelectedChar[6] = "L";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "m";
            SelectedChar[1] = "n";
            SelectedChar[2] = "o";
            SelectedChar[3] = "6";
            SelectedChar[4] = "M";
            SelectedChar[5] = "N";
            SelectedChar[6] = "O";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "6";
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[9];
            int count = 0;
            SelectedChar[0] = "p";
            SelectedChar[1] = "q";
            SelectedChar[2] = "r";
            SelectedChar[3] = "s";
            SelectedChar[4] = "1";
            SelectedChar[5] = "P";
            SelectedChar[6] = "Q";
            SelectedChar[7] = "R";
            SelectedChar[8] = "S";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "t";
            SelectedChar[1] = "u";
            SelectedChar[2] = "v";
            SelectedChar[3] = "2";
            SelectedChar[4] = "T";
            SelectedChar[5] = "U";
            SelectedChar[6] = "V";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "x";
            SelectedChar[1] = "y";
            SelectedChar[2] = "z";
            SelectedChar[3] = "3";
            SelectedChar[4] = "X";
            SelectedChar[5] = "Y";
            SelectedChar[6] = "Z";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
            Str_KeyStrokes = "3";
        }

        private void BtnStar_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[3];
            int count = 0;
            SelectedChar[0] = "*";
            SelectedChar[1] = "-";
            SelectedChar[2] = "_";
           

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = "#";
            SelectedChar[1] = "-";
            SelectedChar[2] = "_";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count - 1]);
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText(TxtWordBuilder.Text + " ");
            Str_KeyStrokes = "";
            TxtWordBuilder.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText("\n");
            
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = My_Dialogs.InputBox("Please enter a valid file name");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = My_Dialogs.InputBox("Please enter a valid file name");
            StreamWriter OutputStream = File.CreateText(FilePath + FileName);
            for (int i = 1; i < 10; i++)
            {
                OutputStream.WriteLine();
            }
            OutputStream.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter OutputStream = File.CreateText(FilePath + FileName);
            OutputStream.Write(TxtDisplay.Text);
            OutputStream.Close();
        }

        private void WithinTimer_Tick(object sender, EventArgs e)
        {

            WithinTimer.Interval = IntIntervalRequired;
            TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
            Timer1.Enabled = false;
            WithinTimer.Enabled = false;
            
            
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
            WithinTimer.Enabled = false;
            ClickCount = -1;
            FirstVisit = true;
            
        }
    }
}
