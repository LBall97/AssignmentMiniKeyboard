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
using System.Timers;

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Str_KeyStrokes;
        string FileName = "";
        int ClickCount = -1;
        bool FirstVisit = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtDisplay.Focus();
            if (FileName == "")
            {
                saveToolStripMenuItem.Enabled = false;
            }
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
            
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton7.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton7.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("7");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton7.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton7.Items[i].ToString());
                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
                
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton8.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton8.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("8");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton8.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton8.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton9.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton9.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("9");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton9.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton9.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton4.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton4.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("4");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton4.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton4.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton5.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton5.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("5");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton5.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton5.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton6.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton6.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("6");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton6.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton6.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton1.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton1.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("1");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton1.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton1.Items[i].ToString());

                    if (i == 10)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton2.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton2.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("2");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton2.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton2.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButton3.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton3.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
                TxtKeyStrokes.AppendText("7");
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButton3.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton3.Items[i].ToString());

                    if (i == 8)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnStar_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButtonStar.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonStar.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButtonStar.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonStar.Items[i].ToString());

                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                LstBoxMain.Items.Clear();
                ClickCount++;
                for (int i = 0; i < LstBoxButtonHash.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonHash.Items[i].ToString());
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                FirstVisit = false;
                IntervalTimer.Enabled = true;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButtonHash.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonHash.Items[i].ToString());

                    if (i == 4)
                    {
                        i = 0;
                    }
                }
                TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString());
                IntervalTimer.Enabled = true;

            }
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText(TxtWordBuilder.Text + " ");
            Str_KeyStrokes = "";
            TxtWordBuilder.Clear();
            ClickCount = -1;
            FirstVisit = true;
            TxtDisplay.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText("\n");
            TxtDisplay.Focus();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = My_Dialogs.InputBox("Please enter a valid file name");
            StreamWriter OutputStream = File.CreateText(FilePath + FileName);
            saveToolStripMenuItem.Enabled = true;

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;

            if (FileName == "")
            {
                SaveFileDialog SaveDirectory = new SaveFileDialog();
                SaveDirectory.InitialDirectory = "C:\\";
                
                if (SaveDirectory.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter OutputStream = File.CreateText(SaveDirectory.FileName);
                    OutputStream.Write(TxtDisplay.Text);
                    FileName = SaveDirectory.FileName;
                    OutputStream.Close();
                    
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter OutputStream = File.CreateText(FilePath + FileName);
            OutputStream.Write(TxtDisplay.Text);
            OutputStream.Close();
        }

        private void WithinTimer_Tick(object sender, EventArgs e)
        {
        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        { 
            ClickCount = -1;
            FirstVisit = true;
            LstBoxMain.Items.Clear();
            IntervalTimer.Enabled = false;
        }
    }
}
