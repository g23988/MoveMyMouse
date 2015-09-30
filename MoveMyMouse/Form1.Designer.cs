namespace MoveMyMouse
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckYourMouse = new System.Windows.Forms.Timer(this.components);
            this.changebackcolor = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.secondTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Restartself = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.秒數設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckYourMouse
            // 
            this.CheckYourMouse.Interval = 10000;
            this.CheckYourMouse.Tick += new System.EventHandler(this.CheckYourMouse_Tick);
            // 
            // changebackcolor
            // 
            this.changebackcolor.Enabled = true;
            this.changebackcolor.Interval = 1000;
            this.changebackcolor.Tick += new System.EventHandler(this.changebackcolor_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // secondTimer
            // 
            this.secondTimer.Enabled = true;
            this.secondTimer.Interval = 1000;
            this.secondTimer.Tick += new System.EventHandler(this.secondTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "秒後，移動滑鼠到左下角。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "然後點兩下，再回原本位置。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(54, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "任何動作將會重設timer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Location = new System.Drawing.Point(240, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 23);
            this.panel1.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "我躲在這邊喔";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於ToolStripMenuItem,
            this.秒數設定ToolStripMenuItem,
            this.關閉ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // 秒數設定ToolStripMenuItem
            // 
            this.秒數設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.sToolStripMenuItem1,
            this.sToolStripMenuItem2,
            this.sToolStripMenuItem3});
            this.秒數設定ToolStripMenuItem.Name = "秒數設定ToolStripMenuItem";
            this.秒數設定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.秒數設定ToolStripMenuItem.Text = "秒數設定";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sToolStripMenuItem.Text = "10 s";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.sToolStripMenuItem1.Text = "60 s";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.sToolStripMenuItem1_Click);
            // 
            // sToolStripMenuItem2
            // 
            this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            this.sToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.sToolStripMenuItem2.Text = "180 s";
            this.sToolStripMenuItem2.Click += new System.EventHandler(this.sToolStripMenuItem2_Click);
            // 
            // sToolStripMenuItem3
            // 
            this.sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            this.sToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.sToolStripMenuItem3.Text = "300 s";
            this.sToolStripMenuItem3.Click += new System.EventHandler(this.sToolStripMenuItem3_Click);
            // 
            // 關閉ToolStripMenuItem
            // 
            this.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem";
            this.關閉ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.關閉ToolStripMenuItem.Text = "關閉";
            this.關閉ToolStripMenuItem.Click += new System.EventHandler(this.關閉ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 68);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "求你不要鎖定我的螢幕  v2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CheckYourMouse;
        private System.Windows.Forms.Timer changebackcolor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer secondTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Restartself;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 關閉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 秒數設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
    }
}

