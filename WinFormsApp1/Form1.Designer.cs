namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            色彩ToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            橡皮擦ToolStripMenuItem = new ToolStripMenuItem();
            粗細ToolStripMenuItem = new ToolStripMenuItem();
            粗ToolStripMenuItem = new ToolStripMenuItem();
            中ToolStripMenuItem = new ToolStripMenuItem();
            細ToolStripMenuItem = new ToolStripMenuItem();
            線條ToolStripMenuItem = new ToolStripMenuItem();
            直線ToolStripMenuItem = new ToolStripMenuItem();
            點ToolStripMenuItem = new ToolStripMenuItem();
            長短虛線ToolStripMenuItem = new ToolStripMenuItem();
            長虛線ToolStripMenuItem = new ToolStripMenuItem();
            處存檔案ToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 色彩ToolStripMenuItem, 粗細ToolStripMenuItem, 線條ToolStripMenuItem, 處存檔案ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 色彩ToolStripMenuItem
            // 
            色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blueToolStripMenuItem, greenToolStripMenuItem, redToolStripMenuItem, blackToolStripMenuItem, 橡皮擦ToolStripMenuItem });
            色彩ToolStripMenuItem.Name = "色彩ToolStripMenuItem";
            色彩ToolStripMenuItem.Size = new Size(43, 20);
            色彩ToolStripMenuItem.Text = "色彩";
            色彩ToolStripMenuItem.Click += 色彩ToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(110, 22);
            blueToolStripMenuItem.Text = "blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(110, 22);
            greenToolStripMenuItem.Text = "green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(110, 22);
            redToolStripMenuItem.Text = "red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(110, 22);
            blackToolStripMenuItem.Text = "black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            橡皮擦ToolStripMenuItem.Size = new Size(110, 22);
            橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            橡皮擦ToolStripMenuItem.Click += 橡皮擦ToolStripMenuItem_Click;
            // 
            // 粗細ToolStripMenuItem
            // 
            粗細ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 粗ToolStripMenuItem, 中ToolStripMenuItem, 細ToolStripMenuItem });
            粗細ToolStripMenuItem.Name = "粗細ToolStripMenuItem";
            粗細ToolStripMenuItem.Size = new Size(43, 20);
            粗細ToolStripMenuItem.Text = "粗細";
            粗細ToolStripMenuItem.Click += 粗細ToolStripMenuItem_Click_1;
            // 
            // 粗ToolStripMenuItem
            // 
            粗ToolStripMenuItem.Name = "粗ToolStripMenuItem";
            粗ToolStripMenuItem.Size = new Size(86, 22);
            粗ToolStripMenuItem.Text = "粗";
            粗ToolStripMenuItem.Click += 粗ToolStripMenuItem_Click;
            // 
            // 中ToolStripMenuItem
            // 
            中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            中ToolStripMenuItem.Size = new Size(86, 22);
            中ToolStripMenuItem.Text = "中";
            中ToolStripMenuItem.Click += 中ToolStripMenuItem_Click;
            // 
            // 細ToolStripMenuItem
            // 
            細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            細ToolStripMenuItem.Size = new Size(86, 22);
            細ToolStripMenuItem.Text = "細";
            細ToolStripMenuItem.Click += 細ToolStripMenuItem_Click;
            // 
            // 線條ToolStripMenuItem
            // 
            線條ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 直線ToolStripMenuItem, 點ToolStripMenuItem, 長短虛線ToolStripMenuItem, 長虛線ToolStripMenuItem });
            線條ToolStripMenuItem.Name = "線條ToolStripMenuItem";
            線條ToolStripMenuItem.Size = new Size(43, 20);
            線條ToolStripMenuItem.Text = "線條";
            // 
            // 直線ToolStripMenuItem
            // 
            直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            直線ToolStripMenuItem.Size = new Size(127, 22);
            直線ToolStripMenuItem.Text = "長虛線";
            直線ToolStripMenuItem.Click += 直線ToolStripMenuItem_Click;
            // 
            // 點ToolStripMenuItem
            // 
            點ToolStripMenuItem.Name = "點ToolStripMenuItem";
            點ToolStripMenuItem.Size = new Size(127, 22);
            點ToolStripMenuItem.Text = "點_短虛線";
            點ToolStripMenuItem.Click += 點ToolStripMenuItem_Click;
            // 
            // 長短虛線ToolStripMenuItem
            // 
            長短虛線ToolStripMenuItem.Name = "長短虛線ToolStripMenuItem";
            長短虛線ToolStripMenuItem.Size = new Size(127, 22);
            長短虛線ToolStripMenuItem.Text = "長短虛線";
            長短虛線ToolStripMenuItem.Click += 長短虛線ToolStripMenuItem_Click;
            // 
            // 長虛線ToolStripMenuItem
            // 
            長虛線ToolStripMenuItem.Name = "長虛線ToolStripMenuItem";
            長虛線ToolStripMenuItem.Size = new Size(180, 22);
            長虛線ToolStripMenuItem.Text = "一般";
            長虛線ToolStripMenuItem.Click += 長虛線ToolStripMenuItem_Click;
            // 
            // 處存檔案ToolStripMenuItem
            // 
            處存檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem });
            處存檔案ToolStripMenuItem.Name = "處存檔案ToolStripMenuItem";
            處存檔案ToolStripMenuItem.Size = new Size(43, 20);
            處存檔案ToolStripMenuItem.Text = "檔案";
            處存檔案ToolStripMenuItem.Click += 處存檔案ToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(99, 22);
            saveToolStripMenuItem.Text = "save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(652, 407);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(672, 326);
            button1.Name = "button1";
            button1.Size = new Size(78, 67);
            button1.TabIndex = 2;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 色彩ToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem 粗細ToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem 粗ToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ToolStripMenuItem 細ToolStripMenuItem;
        private ToolStripMenuItem 線條ToolStripMenuItem;
        private ToolStripMenuItem 直線ToolStripMenuItem;
        private ToolStripMenuItem 點ToolStripMenuItem;
        private ToolStripMenuItem 長短虛線ToolStripMenuItem;
        private ToolStripMenuItem 長虛線ToolStripMenuItem;
        private ToolStripMenuItem 處存檔案ToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private Button button1;
    }
}