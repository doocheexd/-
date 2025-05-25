namespace 抽卡模擬器
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
            button1 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            選擇抽卡模式ToolStripMenuItem = new ToolStripMenuItem();
            標轉版ToolStripMenuItem = new ToolStripMenuItem();
            加強版ToolStripMenuItem = new ToolStripMenuItem();
            最終版ToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            buttonResetLog = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 24F);
            button1.Location = new Point(324, 66);
            button1.Name = "button1";
            button1.Size = new Size(143, 108);
            button1.TabIndex = 0;
            button1.Text = "抽卡";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(394, 209);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 選擇抽卡模式ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 選擇抽卡模式ToolStripMenuItem
            // 
            選擇抽卡模式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 標轉版ToolStripMenuItem, 加強版ToolStripMenuItem, 最終版ToolStripMenuItem });
            選擇抽卡模式ToolStripMenuItem.Font = new Font("Microsoft JhengHei UI", 12F);
            選擇抽卡模式ToolStripMenuItem.Name = "選擇抽卡模式ToolStripMenuItem";
            選擇抽卡模式ToolStripMenuItem.Size = new Size(117, 24);
            選擇抽卡模式ToolStripMenuItem.Text = "選擇抽卡模式";
            // 
            // 標轉版ToolStripMenuItem
            // 
            標轉版ToolStripMenuItem.Name = "標轉版ToolStripMenuItem";
            標轉版ToolStripMenuItem.Size = new Size(126, 24);
            標轉版ToolStripMenuItem.Text = "標準版";
            標轉版ToolStripMenuItem.Click += 標準版ToolStripMenuItem_Click;
            // 
            // 加強版ToolStripMenuItem
            // 
            加強版ToolStripMenuItem.Name = "加強版ToolStripMenuItem";
            加強版ToolStripMenuItem.Size = new Size(126, 24);
            加強版ToolStripMenuItem.Text = "加強版";
            加強版ToolStripMenuItem.Click += 加強版ToolStripMenuItem_Click;
            // 
            // 最終版ToolStripMenuItem
            // 
            最終版ToolStripMenuItem.Name = "最終版ToolStripMenuItem";
            最終版ToolStripMenuItem.Size = new Size(126, 24);
            最終版ToolStripMenuItem.Text = "最終版";
            最終版ToolStripMenuItem.Click += 最終版ToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 18F);
            label2.Location = new Point(470, 392);
            label2.Name = "label2";
            label2.Size = new Size(318, 38);
            label2.TabIndex = 0;
            label2.Text = "lblResult";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(470, 298);
            label3.Name = "label3";
            label3.Size = new Size(81, 30);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft JhengHei UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(318, 184);
            listBox1.TabIndex = 4;
            // 
            // buttonResetLog
            // 
            buttonResetLog.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonResetLog.Location = new Point(204, 256);
            buttonResetLog.Name = "buttonResetLog";
            buttonResetLog.Size = new Size(114, 32);
            buttonResetLog.TabIndex = 5;
            buttonResetLog.Text = "清除抽卡紀錄";
            buttonResetLog.UseVisualStyleBackColor = true;
            buttonResetLog.Click += buttonResetLog_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResetLog);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft JhengHei UI", 9F);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "抽卡模擬器";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 選擇抽卡模式ToolStripMenuItem;
        private ToolStripMenuItem 標轉版ToolStripMenuItem;
        private ToolStripMenuItem 加強版ToolStripMenuItem;
        private ToolStripMenuItem 最終版ToolStripMenuItem;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox1;
        private Button buttonResetLog;
    }
}
