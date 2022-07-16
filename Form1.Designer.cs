using System;
using System.Windows.Forms;

namespace jingziqi
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.规则ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成就ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBoxBunifuItachi1 = new ItachiUIBunifu.PictureBoxBunifuItachi();
            this.menuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(226, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 87);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(323, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 87);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip2.BackgroundImage")));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.规则ToolStripMenuItem1,
            this.说明ToolStripMenuItem1,
            this.版本ToolStripMenuItem,
            this.成就ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(745, 25);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "菜单";
            // 
            // 规则ToolStripMenuItem1
            // 
            this.规则ToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.规则ToolStripMenuItem1.Name = "规则ToolStripMenuItem1";
            this.规则ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.规则ToolStripMenuItem1.Text = "规则";
            this.规则ToolStripMenuItem1.Click += new System.EventHandler(this.规则ToolStripMenuItem1_Click);
            // 
            // 说明ToolStripMenuItem1
            // 
            this.说明ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.说明ToolStripMenuItem1.Name = "说明ToolStripMenuItem1";
            this.说明ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.说明ToolStripMenuItem1.Text = "说明";
            this.说明ToolStripMenuItem1.Click += new System.EventHandler(this.说明ToolStripMenuItem1_Click);
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.版本ToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.版本ToolStripMenuItem.Text = "版本";
            this.版本ToolStripMenuItem.Click += new System.EventHandler(this.版本ToolStripMenuItem_Click);
            // 
            // 成就ToolStripMenuItem
            // 
            this.成就ToolStripMenuItem.ForeColor = System.Drawing.Color.Aqua;
            this.成就ToolStripMenuItem.Name = "成就ToolStripMenuItem";
            this.成就ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.成就ToolStripMenuItem.Text = "成就";
            this.成就ToolStripMenuItem.Click += new System.EventHandler(this.成就ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem2.Text = "123";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(420, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 87);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(226, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 87);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(323, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 87);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Aqua;
            this.button6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(420, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 87);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(226, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 87);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(323, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 87);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(420, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 87);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(276, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "现在轮到A方选择";
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.Font = new System.Drawing.Font("隶书", 19F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(689, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 73);
            this.button10.TabIndex = 14;
            this.button10.Text = "美图";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.Font = new System.Drawing.Font("隶书", 19F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(689, 79);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 73);
            this.button11.TabIndex = 15;
            this.button11.Text = "鸡汤";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.Font = new System.Drawing.Font("隶书", 13.5F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(689, 158);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 73);
            this.button12.TabIndex = 16;
            this.button12.Text = "加强锁屏";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.Font = new System.Drawing.Font("隶书", 13.5F, System.Drawing.FontStyle.Bold);
            this.button13.Location = new System.Drawing.Point(689, 237);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 73);
            this.button13.TabIndex = 17;
            this.button13.Text = "免费会员";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // pictureBoxBunifuItachi1
            // 
            this.pictureBoxBunifuItachi1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureBoxBunifuItachi1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pictureBoxBunifuItachi1.BorderColor2 = System.Drawing.Color.HotPink;
            this.pictureBoxBunifuItachi1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pictureBoxBunifuItachi1.BorderSize = 2;
            this.pictureBoxBunifuItachi1.GradientAngle = 50F;
            this.pictureBoxBunifuItachi1.Image = global::jingziqi.Properties.Resources.stop;
            this.pictureBoxBunifuItachi1.Location = new System.Drawing.Point(654, 0);
            this.pictureBoxBunifuItachi1.Name = "pictureBoxBunifuItachi1";
            this.pictureBoxBunifuItachi1.Size = new System.Drawing.Size(29, 29);
            this.pictureBoxBunifuItachi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBunifuItachi1.TabIndex = 18;
            this.pictureBoxBunifuItachi1.TabStop = false;
            this.pictureBoxBunifuItachi1.Click += new System.EventHandler(this.pictureBoxBunifuItachi1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 420);
            this.Controls.Add(this.pictureBoxBunifuItachi1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "九宫格小游戏";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBunifuItachi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 规则ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private ToolStripMenuItem 版本ToolStripMenuItem;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private ItachiUIBunifu.PictureBoxBunifuItachi pictureBoxBunifuItachi1;
        private ToolStripMenuItem 成就ToolStripMenuItem;
    }
}

