using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Str_KeyStrokes;

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
            TxtWordBuilder.AppendText(".");
            Str_KeyStrokes = "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText("a");
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
        }
    }
}
