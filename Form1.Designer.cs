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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(287, 66);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 70);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 選擇抽卡模式ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 選擇抽卡模式ToolStripMenuItem
            // 
            選擇抽卡模式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 標轉版ToolStripMenuItem, 加強版ToolStripMenuItem, 最終版ToolStripMenuItem });
            選擇抽卡模式ToolStripMenuItem.Name = "選擇抽卡模式ToolStripMenuItem";
            選擇抽卡模式ToolStripMenuItem.Size = new Size(91, 20);
            選擇抽卡模式ToolStripMenuItem.Text = "選擇抽卡模式";
            // 
            // 標轉版ToolStripMenuItem
            // 
            標轉版ToolStripMenuItem.Name = "標轉版ToolStripMenuItem";
            標轉版ToolStripMenuItem.Size = new Size(165, 22);
            標轉版ToolStripMenuItem.Text = "menuStandard";
            標轉版ToolStripMenuItem.Click += 標準版ToolStripMenuItem_Click;
            // 
            // 加強版ToolStripMenuItem
            // 
            加強版ToolStripMenuItem.Name = "加強版ToolStripMenuItem";
            加強版ToolStripMenuItem.Size = new Size(165, 22);
            加強版ToolStripMenuItem.Text = "menuGuarantee";
            加強版ToolStripMenuItem.Click += 加強版ToolStripMenuItem_Click;
            // 
            // 最終版ToolStripMenuItem
            // 
            最終版ToolStripMenuItem.Name = "最終版ToolStripMenuItem";
            最終版ToolStripMenuItem.Size = new Size(165, 22);
            最終版ToolStripMenuItem.Text = "menuPity";
            最終版ToolStripMenuItem.Click += 最終版ToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Location = new Point(477, 24);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "lblResult";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
    }
}
