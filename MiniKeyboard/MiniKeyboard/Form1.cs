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
using System.Timers;

namespace MiniKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Str_KeyStrokes;  //Global variables
        string FileName = "";
        int ClickCount = -1;
        bool FirstVisit = true; 
        SaveFileDialog SaveDirectory = new SaveFileDialog(); //enables save menu for save as

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1483, 1397); //Sets size of form
            TxtDisplay.Focus(); //Puts cursor in main text box so that the user can see where text will be entered
            if (FileName == "") 
            {
                saveToolStripMenuItem.Enabled = false; //if there is no file name the save function will not be available
            }

        }

        private void BtnMode_Click(object sender, EventArgs e)
        {
            if (TxtMode.Text == "Multi-Press")
            {
                TxtMode.Text = "Prediction"; //changes to prediction mode
            }
            else
            {
                TxtMode.Text = "Multi-Press";
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            IntervalTimer.Enabled = false;
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton7.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton7.Items[i].ToString()); //adds items from button list to the main list
                }
                IntervalTimer.Enabled = true; //starts time check between button presses
                TxtKeyStrokes.AppendText("7"); //adds key stroke to a text box which is then added to the variable
                Str_KeyStrokes = TxtKeyStrokes.Text;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1); //removes previous character from the word builder
                for (int i = 0; i < LstBoxButton7.Items.Count; i++) 
                {
                    LstBoxMain.Items.Add(LstBoxButton7.Items[i].ToString()); //adds items from button list to main list

                }

                IntervalTimer.Enabled = true; //enables time check

            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            IntervalTimer.Enabled = false;
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton8.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton8.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton9.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton9.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton4.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton4.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton5.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton5.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton6.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton6.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton1.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton1.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton2.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton2.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButton3.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButton3.Items[i].ToString());
                }
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
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnStar_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButtonStar.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonStar.Items[i].ToString());
                }
                IntervalTimer.Enabled = true;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButtonStar.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonStar.Items[i].ToString());
                }
                IntervalTimer.Enabled = true;
            }
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            if (FirstVisit == true)
            {
                ClickCount++;
                for (int i = 0; i < LstBoxButtonHash.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonHash.Items[i].ToString());
                }
                IntervalTimer.Enabled = true;
            }
            else
            {
                ClickCount++;
                TxtWordBuilder.Text = TxtWordBuilder.Text.Remove(TxtWordBuilder.Text.Length - 1);
                for (int i = 0; i < LstBoxButtonHash.Items.Count; i++)
                {
                    LstBoxMain.Items.Add(LstBoxButtonHash.Items[i].ToString());
                }
                IntervalTimer.Enabled = true;

            }
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText(TxtWordBuilder.Text + " "); //adds word to the display and adds a space inbetween
            Str_KeyStrokes = ""; //emptys keystrokes variable
            TxtWordBuilder.Clear(); //clears the word builder
            ClickCount = -1; //resets the amount of clicks/index of list
            FirstVisit = true; //enables first visit again as a new word will be created
            TxtDisplay.Focus(); //sets cursor on display once again
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtDisplay.AppendText("\n"); //new line
            TxtDisplay.Focus();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true; //enables save function once save as has been carried out
            
                SaveDirectory.InitialDirectory = "C:\\"; //allows the user to select a place to save the file and name the file

                if (SaveDirectory.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter OutputStream = File.CreateText(SaveDirectory.FileName); //creates a text file with the FileName
                }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;

            if (FileName == "")
            {
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
            StreamWriter OutputStream = File.CreateText(SaveDirectory.FileName);
            OutputStream.Write(TxtDisplay.Text);
            FileName = SaveDirectory.FileName;
            OutputStream.Close();
        }

        private void WithinTimer_Tick(object sender, EventArgs e)
        {
        } //obsolete timer that if removed would cause an error.

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            TxtWordBuilder.AppendText(LstBoxMain.Items[ClickCount].ToString()); //timer for what occurs once Interval is met
            ClickCount = -1;
            FirstVisit = true;
            LstBoxMain.Items.Clear();
            IntervalTimer.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string LineOfText;
            OpenFileDialog OpenFile = new OpenFileDialog();

            OpenFile.InitialDirectory = "C:\\";
            if (OpenFile.ShowDialog() == DialogResult.OK) //Opens a previously saved text file
            {
                StreamReader InputStream = File.OpenText(OpenFile.FileName);
                LineOfText = InputStream.ReadLine();
                while (LineOfText != null)
                {
                    TxtDisplay.AppendText(LineOfText + Environment.NewLine);
                    LineOfText = InputStream.ReadLine();
                }
                InputStream.Close();
            }
        }
    }
}
