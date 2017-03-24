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
    }
}
