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
        int i = 1;

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
            string[] SelectedChar = new string[7];
            int count = 0;
            SelectedChar[0] = ".";
            SelectedChar[1] = "~";
            SelectedChar[2] = "\"";
            SelectedChar[3] = "7";
            SelectedChar[4] = "'";
            SelectedChar[5] = ":";
            SelectedChar[6] = ";";

            count++;
            TxtWordBuilder.AppendText(SelectedChar[count-1]);
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
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("d");
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("g");
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("j");
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("m");
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("p");
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("t");
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("x");
        }

        private void BtnStar_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("*");
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("#");
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
            i++;
           
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
    }
}
