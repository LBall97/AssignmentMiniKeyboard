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
            this.ConfigMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlText = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PnlDisplay = new System.Windows.Forms.Panel();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.PnlKeys = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnMode = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnHash = new System.Windows.Forms.Button();
            this.BtnSpace = new System.Windows.Forms.Button();
            this.BtnStar = new System.Windows.Forms.Button();
            this.TxtMode = new System.Windows.Forms.TextBox();
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
            this.ConfigMenu.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.ConfigMenu.Size = new System.Drawing.Size(544, 24);
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
            this.FileMenu.Size = new System.Drawing.Size(37, 22);
            this.FileMenu.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // PnlText
            // 
            this.PnlText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlText.Controls.Add(this.TxtMode);
            this.PnlText.Controls.Add(this.textBox1);
            this.PnlText.Location = new System.Drawing.Point(147, 221);
            this.PnlText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PnlText.Name = "PnlText";
            this.PnlText.Size = new System.Drawing.Size(226, 33);
            this.PnlText.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 0;
            // 
            // PnlDisplay
            // 
            this.PnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDisplay.Controls.Add(this.TxtDisplay);
            this.PnlDisplay.Location = new System.Drawing.Point(5, 22);
            this.PnlDisplay.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PnlDisplay.Name = "PnlDisplay";
            this.PnlDisplay.Size = new System.Drawing.Size(530, 197);
            this.PnlDisplay.TabIndex = 3;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(2, 2);
            this.TxtDisplay.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(525, 192);
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
            this.PnlKeys.Location = new System.Drawing.Point(147, 256);
            this.PnlKeys.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PnlKeys.Name = "PnlKeys";
            this.PnlKeys.Size = new System.Drawing.Size(226, 292);
            this.PnlKeys.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSend.Location = new System.Drawing.Point(167, 6);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(52, 52);
            this.BtnSend.TabIndex = 3;
            this.BtnSend.Text = "Send Predicted";
            this.BtnSend.UseVisualStyleBackColor = false;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnPrevious.Location = new System.Drawing.Point(113, 6);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(52, 52);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnNext.Location = new System.Drawing.Point(59, 6);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(52, 52);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            // 
            // BtnMode
            // 
            this.BtnMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnMode.Location = new System.Drawing.Point(5, 6);
            this.BtnMode.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BtnMode.Name = "BtnMode";
            this.BtnMode.Size = new System.Drawing.Size(52, 52);
            this.BtnMode.TabIndex = 0;
            this.BtnMode.Text = "Mode";
            this.BtnMode.UseVisualStyleBackColor = false;
            this.BtnMode.Click += new System.EventHandler(this.BtnMode_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSeven.Location = new System.Drawing.Point(5, 63);
            this.BtnSeven.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(52, 52);
            this.BtnSeven.TabIndex = 4;
            this.BtnSeven.Text = "7\r\n. , \"";
            this.BtnSeven.UseVisualStyleBackColor = false;
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnEight.Location = new System.Drawing.Point(59, 63);
            this.BtnEight.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(52, 52);
            this.BtnEight.TabIndex = 5;
            this.BtnEight.Text = "8\r\nA B C";
            this.BtnEight.UseVisualStyleBackColor = false;
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnNine.Location = new System.Drawing.Point(113, 63);
            this.BtnNine.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(52, 52);
            this.BtnNine.TabIndex = 6;
            this.BtnNine.Text = "9\r\nD E F";
            this.BtnNine.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(167, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 52);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnOne.Location = new System.Drawing.Point(5, 174);
            this.BtnOne.Margin = new System.Windows.Forms.Padding(1);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(52, 52);
            this.BtnOne.TabIndex = 9;
            this.BtnOne.Text = "1\r\nP Q R S";
            this.BtnOne.UseVisualStyleBackColor = false;
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnFour.Location = new System.Drawing.Point(5, 118);
            this.BtnFour.Margin = new System.Windows.Forms.Padding(1);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(52, 52);
            this.BtnFour.TabIndex = 11;
            this.BtnFour.Text = "4\r\nG H I";
            this.BtnFour.UseVisualStyleBackColor = false;
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnThree.Location = new System.Drawing.Point(113, 174);
            this.BtnThree.Margin = new System.Windows.Forms.Padding(1);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(52, 52);
            this.BtnThree.TabIndex = 5;
            this.BtnThree.Text = "3\r\nX Y Z";
            this.BtnThree.UseVisualStyleBackColor = false;
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnTwo.Location = new System.Drawing.Point(59, 174);
            this.BtnTwo.Margin = new System.Windows.Forms.Padding(1);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(52, 52);
            this.BtnTwo.TabIndex = 6;
            this.BtnTwo.Text = "2\r\nT U V";
            this.BtnTwo.UseVisualStyleBackColor = false;
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSix.Location = new System.Drawing.Point(113, 118);
            this.BtnSix.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(52, 52);
            this.BtnSix.TabIndex = 7;
            this.BtnSix.Text = "6\r\nM N O";
            this.BtnSix.UseVisualStyleBackColor = false;
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnFive.Location = new System.Drawing.Point(59, 118);
            this.BtnFive.Margin = new System.Windows.Forms.Padding(1);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(52, 52);
            this.BtnFive.TabIndex = 8;
            this.BtnFive.Text = "5\r\nJ K L";
            this.BtnFive.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(167, 173);
            this.button13.Margin = new System.Windows.Forms.Padding(1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(52, 108);
            this.button13.TabIndex = 12;
            this.button13.Text = "Enter";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(167, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnHash
            // 
            this.BtnHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnHash.Location = new System.Drawing.Point(113, 229);
            this.BtnHash.Margin = new System.Windows.Forms.Padding(1);
            this.BtnHash.Name = "BtnHash";
            this.BtnHash.Size = new System.Drawing.Size(52, 52);
            this.BtnHash.TabIndex = 10;
            this.BtnHash.Text = "#\r\n000";
            this.BtnHash.UseVisualStyleBackColor = false;
            // 
            // BtnSpace
            // 
            this.BtnSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSpace.Location = new System.Drawing.Point(59, 229);
            this.BtnSpace.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSpace.Name = "BtnSpace";
            this.BtnSpace.Size = new System.Drawing.Size(52, 52);
            this.BtnSpace.TabIndex = 9;
            this.BtnSpace.Text = "000\r\n[ _ ]";
            this.BtnSpace.UseVisualStyleBackColor = false;
            // 
            // BtnStar
            // 
            this.BtnStar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnStar.Location = new System.Drawing.Point(5, 229);
            this.BtnStar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnStar.Name = "BtnStar";
            this.BtnStar.Size = new System.Drawing.Size(52, 52);
            this.BtnStar.TabIndex = 8;
            this.BtnStar.Text = "* - _";
            this.BtnStar.UseVisualStyleBackColor = false;
            // 
            // TxtMode
            // 
            this.TxtMode.Location = new System.Drawing.Point(159, 2);
            this.TxtMode.Name = "TxtMode";
            this.TxtMode.ReadOnly = true;
            this.TxtMode.Size = new System.Drawing.Size(60, 20);
            this.TxtMode.TabIndex = 1;
            this.TxtMode.Text = "Multi-Press";
            this.TxtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 549);
            this.Controls.Add(this.PnlKeys);
            this.Controls.Add(this.PnlDisplay);
            this.Controls.Add(this.PnlText);
            this.Controls.Add(this.ConfigMenu);
            this.MainMenuStrip = this.ConfigMenu;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

