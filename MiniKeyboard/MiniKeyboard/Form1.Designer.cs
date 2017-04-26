namespace MiniKeyboard
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
            this.components = new System.ComponentModel.Container();
            this.ConfigMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlText = new System.Windows.Forms.Panel();
            this.TxtMode = new System.Windows.Forms.TextBox();
            this.TxtWordBuilder = new System.Windows.Forms.TextBox();
            this.PnlDisplay = new System.Windows.Forms.Panel();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.PnlKeys = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnHash = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.BtnSpace = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnStar = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnMode = new System.Windows.Forms.Button();
            this.WithinTimer = new System.Windows.Forms.Timer(this.components);
            this.LstBoxButton7 = new System.Windows.Forms.ListBox();
            this.LstBoxMain = new System.Windows.Forms.ListBox();
            this.LstBoxButton8 = new System.Windows.Forms.ListBox();
            this.LstBoxButton9 = new System.Windows.Forms.ListBox();
            this.LstBoxButton4 = new System.Windows.Forms.ListBox();
            this.LstBoxButton5 = new System.Windows.Forms.ListBox();
            this.LstBoxButton6 = new System.Windows.Forms.ListBox();
            this.LstBoxButton1 = new System.Windows.Forms.ListBox();
            this.LstBoxButton2 = new System.Windows.Forms.ListBox();
            this.LstBoxButton3 = new System.Windows.Forms.ListBox();
            this.LstBoxButtonStar = new System.Windows.Forms.ListBox();
            this.LstBoxButtonHash = new System.Windows.Forms.ListBox();
            this.TxtKeyStrokes = new System.Windows.Forms.TextBox();
            this.ConfigMenu.SuspendLayout();
            this.PnlText.SuspendLayout();
            this.PnlDisplay.SuspendLayout();
            this.PnlKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigMenu
            // 
            this.ConfigMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ConfigMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.configureToolStripMenuItem});
            this.ConfigMenu.Location = new System.Drawing.Point(0, 0);
            this.ConfigMenu.Name = "ConfigMenu";
            this.ConfigMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.ConfigMenu.Size = new System.Drawing.Size(1451, 49);
            this.ConfigMenu.TabIndex = 0;
            this.ConfigMenu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(75, 45);
            this.FileMenu.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(161, 45);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // PnlText
            // 
            this.PnlText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlText.Controls.Add(this.TxtMode);
            this.PnlText.Controls.Add(this.TxtWordBuilder);
            this.PnlText.Location = new System.Drawing.Point(392, 527);
            this.PnlText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlText.Name = "PnlText";
            this.PnlText.Size = new System.Drawing.Size(596, 73);
            this.PnlText.TabIndex = 2;
            // 
            // TxtMode
            // 
            this.TxtMode.Location = new System.Drawing.Point(424, 5);
            this.TxtMode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtMode.Name = "TxtMode";
            this.TxtMode.ReadOnly = true;
            this.TxtMode.Size = new System.Drawing.Size(153, 38);
            this.TxtMode.TabIndex = 1;
            this.TxtMode.Text = "Multi-Press";
            this.TxtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtWordBuilder
            // 
            this.TxtWordBuilder.Location = new System.Drawing.Point(5, 7);
            this.TxtWordBuilder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtWordBuilder.Name = "TxtWordBuilder";
            this.TxtWordBuilder.Size = new System.Drawing.Size(401, 38);
            this.TxtWordBuilder.TabIndex = 0;
            // 
            // PnlDisplay
            // 
            this.PnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDisplay.Controls.Add(this.TxtDisplay);
            this.PnlDisplay.Location = new System.Drawing.Point(13, 52);
            this.PnlDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlDisplay.Name = "PnlDisplay";
            this.PnlDisplay.Size = new System.Drawing.Size(1410, 467);
            this.PnlDisplay.TabIndex = 3;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(5, 5);
            this.TxtDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(1393, 452);
            this.TxtDisplay.TabIndex = 0;
            // 
            // PnlKeys
            // 
            this.PnlKeys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlKeys.Controls.Add(this.button1);
            this.PnlKeys.Controls.Add(this.BtnHash);
            this.PnlKeys.Controls.Add(this.button13);
            this.PnlKeys.Controls.Add(this.BtnSpace);
            this.PnlKeys.Controls.Add(this.BtnThree);
            this.PnlKeys.Controls.Add(this.BtnStar);
            this.PnlKeys.Controls.Add(this.BtnTwo);
            this.PnlKeys.Controls.Add(this.BtnSix);
            this.PnlKeys.Controls.Add(this.BtnFive);
            this.PnlKeys.Controls.Add(this.BtnFour);
            this.PnlKeys.Controls.Add(this.BtnOne);
            this.PnlKeys.Controls.Add(this.button4);
            this.PnlKeys.Controls.Add(this.BtnNine);
            this.PnlKeys.Controls.Add(this.BtnEight);
            this.PnlKeys.Controls.Add(this.BtnSeven);
            this.PnlKeys.Controls.Add(this.BtnSend);
            this.PnlKeys.Controls.Add(this.BtnPrevious);
            this.PnlKeys.Controls.Add(this.BtnNext);
            this.PnlKeys.Controls.Add(this.BtnMode);
            this.PnlKeys.Location = new System.Drawing.Point(392, 610);
            this.PnlKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlKeys.Name = "PnlKeys";
            this.PnlKeys.Size = new System.Drawing.Size(596, 691);
            this.PnlKeys.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(445, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 124);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnHash
            // 
            this.BtnHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnHash.Location = new System.Drawing.Point(301, 546);
            this.BtnHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnHash.Name = "BtnHash";
            this.BtnHash.Size = new System.Drawing.Size(139, 124);
            this.BtnHash.TabIndex = 10;
            this.BtnHash.Text = "#\r\n000";
            this.BtnHash.UseVisualStyleBackColor = false;
            this.BtnHash.Click += new System.EventHandler(this.BtnHash_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(445, 413);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(139, 258);
            this.button13.TabIndex = 12;
            this.button13.Text = "Enter";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // BtnSpace
            // 
            this.BtnSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSpace.Location = new System.Drawing.Point(157, 546);
            this.BtnSpace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSpace.Name = "BtnSpace";
            this.BtnSpace.Size = new System.Drawing.Size(139, 124);
            this.BtnSpace.TabIndex = 9;
            this.BtnSpace.Text = "000\r\n[ _ ]";
            this.BtnSpace.UseVisualStyleBackColor = false;
            this.BtnSpace.Click += new System.EventHandler(this.BtnSpace_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnThree.Location = new System.Drawing.Point(301, 415);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(139, 124);
            this.BtnThree.TabIndex = 5;
            this.BtnThree.Text = "3\r\nX Y Z";
            this.BtnThree.UseVisualStyleBackColor = false;
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnStar
            // 
            this.BtnStar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnStar.Location = new System.Drawing.Point(13, 546);
            this.BtnStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStar.Name = "BtnStar";
            this.BtnStar.Size = new System.Drawing.Size(139, 124);
            this.BtnStar.TabIndex = 8;
            this.BtnStar.Text = "* - _";
            this.BtnStar.UseVisualStyleBackColor = false;
            this.BtnStar.Click += new System.EventHandler(this.BtnStar_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnTwo.Location = new System.Drawing.Point(157, 415);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(139, 124);
            this.BtnTwo.TabIndex = 6;
            this.BtnTwo.Text = "2\r\nT U V";
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSix.Location = new System.Drawing.Point(301, 281);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(139, 124);
            this.BtnSix.TabIndex = 7;
            this.BtnSix.Text = "6\r\nM N O";
            this.BtnSix.UseVisualStyleBackColor = false;
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnFive.Location = new System.Drawing.Point(157, 281);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(139, 124);
            this.BtnFive.TabIndex = 8;
            this.BtnFive.Text = "5\r\nJ K L";
            this.BtnFive.UseVisualStyleBackColor = false;
            this.BtnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnFour.Location = new System.Drawing.Point(13, 281);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(139, 124);
            this.BtnFour.TabIndex = 11;
            this.BtnFour.Text = "4\r\nG H I";
            this.BtnFour.UseVisualStyleBackColor = false;
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnOne.Location = new System.Drawing.Point(13, 415);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(139, 124);
            this.BtnOne.TabIndex = 9;
            this.BtnOne.Text = "1\r\nP Q R S";
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(445, 150);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 124);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnNine.Location = new System.Drawing.Point(301, 150);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(139, 124);
            this.BtnNine.TabIndex = 6;
            this.BtnNine.Text = "9\r\nD E F";
            this.BtnNine.UseVisualStyleBackColor = false;
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEight.Location = new System.Drawing.Point(157, 150);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(139, 124);
            this.BtnEight.TabIndex = 5;
            this.BtnEight.Text = "8\r\nA B C";
            this.BtnEight.UseVisualStyleBackColor = false;
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSeven.Location = new System.Drawing.Point(13, 150);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(139, 124);
            this.BtnSeven.TabIndex = 4;
            this.BtnSeven.Text = "7\r\n. , \"";
            this.BtnSeven.UseVisualStyleBackColor = false;
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSend.Location = new System.Drawing.Point(445, 14);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(139, 124);
            this.BtnSend.TabIndex = 3;
            this.BtnSend.Text = "Send Predicted";
            this.BtnSend.UseVisualStyleBackColor = false;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnPrevious.Location = new System.Drawing.Point(301, 14);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(139, 124);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnNext.Location = new System.Drawing.Point(157, 14);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(139, 124);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            // 
            // BtnMode
            // 
            this.BtnMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnMode.Location = new System.Drawing.Point(13, 14);
            this.BtnMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMode.Name = "BtnMode";
            this.BtnMode.Size = new System.Drawing.Size(139, 124);
            this.BtnMode.TabIndex = 0;
            this.BtnMode.Text = "Mode";
            this.BtnMode.UseVisualStyleBackColor = false;
            this.BtnMode.Click += new System.EventHandler(this.BtnMode_Click);
            // 
            // WithinTimer
            // 
            this.WithinTimer.Tick += new System.EventHandler(this.WithinTimer_Tick);
            // 
            // LstBoxButton7
            // 
            this.LstBoxButton7.FormattingEnabled = true;
            this.LstBoxButton7.ItemHeight = 31;
            this.LstBoxButton7.Items.AddRange(new object[] {
            ".",
            "~",
            "\"",
            "7",
            "\'",
            ":",
            ";"});
            this.LstBoxButton7.Location = new System.Drawing.Point(1011, 536);
            this.LstBoxButton7.Name = "LstBoxButton7";
            this.LstBoxButton7.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton7.TabIndex = 5;
            // 
            // LstBoxMain
            // 
            this.LstBoxMain.FormattingEnabled = true;
            this.LstBoxMain.ItemHeight = 31;
            this.LstBoxMain.Location = new System.Drawing.Point(13, 534);
            this.LstBoxMain.Name = "LstBoxMain";
            this.LstBoxMain.Size = new System.Drawing.Size(167, 66);
            this.LstBoxMain.TabIndex = 6;
            // 
            // LstBoxButton8
            // 
            this.LstBoxButton8.FormattingEnabled = true;
            this.LstBoxButton8.ItemHeight = 31;
            this.LstBoxButton8.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "8",
            "A",
            "B",
            "C"});
            this.LstBoxButton8.Location = new System.Drawing.Point(1138, 536);
            this.LstBoxButton8.Name = "LstBoxButton8";
            this.LstBoxButton8.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton8.TabIndex = 7;
            // 
            // LstBoxButton9
            // 
            this.LstBoxButton9.FormattingEnabled = true;
            this.LstBoxButton9.ItemHeight = 31;
            this.LstBoxButton9.Items.AddRange(new object[] {
            "d",
            "e",
            "f",
            "9",
            "D",
            "E",
            "F"});
            this.LstBoxButton9.Location = new System.Drawing.Point(1265, 536);
            this.LstBoxButton9.Name = "LstBoxButton9";
            this.LstBoxButton9.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton9.TabIndex = 8;
            // 
            // LstBoxButton4
            // 
            this.LstBoxButton4.FormattingEnabled = true;
            this.LstBoxButton4.ItemHeight = 31;
            this.LstBoxButton4.Items.AddRange(new object[] {
            "g",
            "h",
            "i",
            "4",
            "G",
            "H",
            "I"});
            this.LstBoxButton4.Location = new System.Drawing.Point(1011, 610);
            this.LstBoxButton4.Name = "LstBoxButton4";
            this.LstBoxButton4.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton4.TabIndex = 9;
            // 
            // LstBoxButton5
            // 
            this.LstBoxButton5.FormattingEnabled = true;
            this.LstBoxButton5.ItemHeight = 31;
            this.LstBoxButton5.Items.AddRange(new object[] {
            "j",
            "k",
            "l",
            "5",
            "J",
            "K",
            "L"});
            this.LstBoxButton5.Location = new System.Drawing.Point(1137, 610);
            this.LstBoxButton5.Name = "LstBoxButton5";
            this.LstBoxButton5.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton5.TabIndex = 10;
            // 
            // LstBoxButton6
            // 
            this.LstBoxButton6.FormattingEnabled = true;
            this.LstBoxButton6.ItemHeight = 31;
            this.LstBoxButton6.Items.AddRange(new object[] {
            "m",
            "n",
            "o",
            "6",
            "M",
            "N",
            "O"});
            this.LstBoxButton6.Location = new System.Drawing.Point(1263, 608);
            this.LstBoxButton6.Name = "LstBoxButton6";
            this.LstBoxButton6.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton6.TabIndex = 11;
            // 
            // LstBoxButton1
            // 
            this.LstBoxButton1.FormattingEnabled = true;
            this.LstBoxButton1.ItemHeight = 31;
            this.LstBoxButton1.Items.AddRange(new object[] {
            "p",
            "q",
            "r",
            "s",
            "1",
            "P",
            "Q",
            "R",
            "S"});
            this.LstBoxButton1.Location = new System.Drawing.Point(1011, 683);
            this.LstBoxButton1.Name = "LstBoxButton1";
            this.LstBoxButton1.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton1.TabIndex = 12;
            // 
            // LstBoxButton2
            // 
            this.LstBoxButton2.FormattingEnabled = true;
            this.LstBoxButton2.ItemHeight = 31;
            this.LstBoxButton2.Items.AddRange(new object[] {
            "t",
            "u",
            "v",
            "2",
            "T",
            "U",
            "V"});
            this.LstBoxButton2.Location = new System.Drawing.Point(1138, 682);
            this.LstBoxButton2.Name = "LstBoxButton2";
            this.LstBoxButton2.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton2.TabIndex = 13;
            // 
            // LstBoxButton3
            // 
            this.LstBoxButton3.FormattingEnabled = true;
            this.LstBoxButton3.ItemHeight = 31;
            this.LstBoxButton3.Items.AddRange(new object[] {
            "x",
            "y",
            "z",
            "3",
            "X",
            "Y",
            "Z"});
            this.LstBoxButton3.Location = new System.Drawing.Point(1265, 683);
            this.LstBoxButton3.Name = "LstBoxButton3";
            this.LstBoxButton3.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButton3.TabIndex = 14;
            // 
            // LstBoxButtonStar
            // 
            this.LstBoxButtonStar.FormattingEnabled = true;
            this.LstBoxButtonStar.ItemHeight = 31;
            this.LstBoxButtonStar.Items.AddRange(new object[] {
            "*",
            "-",
            "_"});
            this.LstBoxButtonStar.Location = new System.Drawing.Point(1011, 756);
            this.LstBoxButtonStar.Name = "LstBoxButtonStar";
            this.LstBoxButtonStar.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButtonStar.TabIndex = 15;
            // 
            // LstBoxButtonHash
            // 
            this.LstBoxButtonHash.FormattingEnabled = true;
            this.LstBoxButtonHash.ItemHeight = 31;
            this.LstBoxButtonHash.Items.AddRange(new object[] {
            "#",
            "-",
            "_"});
            this.LstBoxButtonHash.Location = new System.Drawing.Point(1137, 754);
            this.LstBoxButtonHash.Name = "LstBoxButtonHash";
            this.LstBoxButtonHash.Size = new System.Drawing.Size(120, 66);
            this.LstBoxButtonHash.TabIndex = 16;
            // 
            // TxtKeyStrokes
            // 
            this.TxtKeyStrokes.Location = new System.Drawing.Point(1011, 847);
            this.TxtKeyStrokes.Name = "TxtKeyStrokes";
            this.TxtKeyStrokes.Size = new System.Drawing.Size(135, 38);
            this.TxtKeyStrokes.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 1309);
            this.Controls.Add(this.TxtKeyStrokes);
            this.Controls.Add(this.LstBoxButtonHash);
            this.Controls.Add(this.LstBoxButtonStar);
            this.Controls.Add(this.LstBoxButton3);
            this.Controls.Add(this.LstBoxButton2);
            this.Controls.Add(this.LstBoxButton1);
            this.Controls.Add(this.LstBoxButton6);
            this.Controls.Add(this.LstBoxButton5);
            this.Controls.Add(this.LstBoxButton4);
            this.Controls.Add(this.LstBoxButton9);
            this.Controls.Add(this.LstBoxButton8);
            this.Controls.Add(this.LstBoxMain);
            this.Controls.Add(this.LstBoxButton7);
            this.Controls.Add(this.PnlKeys);
            this.Controls.Add(this.PnlDisplay);
            this.Controls.Add(this.PnlText);
            this.Controls.Add(this.ConfigMenu);
            this.MainMenuStrip = this.ConfigMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1483, 1397);
            this.Name = "Form1";
            this.Text = "Mini Keyboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConfigMenu.ResumeLayout(false);
            this.ConfigMenu.PerformLayout();
            this.PnlText.ResumeLayout(false);
            this.PnlText.PerformLayout();
            this.PnlDisplay.ResumeLayout(false);
            this.PnlDisplay.PerformLayout();
            this.PnlKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ConfigMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.Panel PnlText;
        private System.Windows.Forms.TextBox TxtWordBuilder;
        private System.Windows.Forms.Panel PnlDisplay;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Panel PnlKeys;
        private System.Windows.Forms.Button BtnMode;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnHash;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button BtnSpace;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnStar;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.TextBox TxtMode;
        private System.Windows.Forms.Timer WithinTimer;
        private System.Windows.Forms.ListBox LstBoxButton7;
        private System.Windows.Forms.ListBox LstBoxMain;
        private System.Windows.Forms.ListBox LstBoxButton8;
        private System.Windows.Forms.ListBox LstBoxButton9;
        private System.Windows.Forms.ListBox LstBoxButton4;
        private System.Windows.Forms.ListBox LstBoxButton5;
        private System.Windows.Forms.ListBox LstBoxButton6;
        private System.Windows.Forms.ListBox LstBoxButton1;
        private System.Windows.Forms.ListBox LstBoxButton2;
        private System.Windows.Forms.ListBox LstBoxButton3;
        private System.Windows.Forms.ListBox LstBoxButtonStar;
        private System.Windows.Forms.ListBox LstBoxButtonHash;
        private System.Windows.Forms.TextBox TxtKeyStrokes;
    }
}

