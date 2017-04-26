﻿using System;
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "7");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "8");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "9");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "4");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "5");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "6");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "1");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "2");
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
                TxtKeyStrokes.AppendText(TxtKeyStrokes.Text + "7");
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

            }
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText(TxtWordBuilder.Text + " ");
            Str_KeyStrokes = "";
            TxtWordBuilder.Clear();
            ClickCount = -1;
            FirstVisit = true;
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
            
            ClickCount = -1;
            FirstVisit = true;
            WithinTimer.Enabled = false;
        }
    }
}
