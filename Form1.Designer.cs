
namespace Xiaos
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbxUserCode = new System.Windows.Forms.TextBox();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFps = new System.Windows.Forms.TextBox();
            this.tbxRoomPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbxMouseParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUserCode
            // 
            this.tbxUserCode.Location = new System.Drawing.Point(12, 12);
            this.tbxUserCode.Name = "tbxUserCode";
            this.tbxUserCode.Size = new System.Drawing.Size(310, 21);
            this.tbxUserCode.TabIndex = 0;
            // 
            // lbxLog
            // 
            this.lbxLog.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbxLog.ItemHeight = 20;
            this.lbxLog.Location = new System.Drawing.Point(12, 355);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(310, 164);
            this.lbxLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FPS  参数";
            // 
            // tbxFps
            // 
            this.tbxFps.Location = new System.Drawing.Point(112, 29);
            this.tbxFps.Name = "tbxFps";
            this.tbxFps.Size = new System.Drawing.Size(143, 26);
            this.tbxFps.TabIndex = 3;
            this.tbxFps.Text = "20";
            // 
            // tbxRoomPwd
            // 
            this.tbxRoomPwd.Location = new System.Drawing.Point(112, 64);
            this.tbxRoomPwd.Name = "tbxRoomPwd";
            this.tbxRoomPwd.Size = new System.Drawing.Size(143, 26);
            this.tbxRoomPwd.TabIndex = 5;
            this.tbxRoomPwd.Text = "1212";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "房 间 密 码";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxMouseParam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbxRoomPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxFps);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxMouseParam
            // 
            this.tbxMouseParam.Location = new System.Drawing.Point(112, 96);
            this.tbxMouseParam.Name = "tbxMouseParam";
            this.tbxMouseParam.Size = new System.Drawing.Size(143, 26);
            this.tbxMouseParam.TabIndex = 8;
            this.tbxMouseParam.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "鼠标下移参数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.tbxUserCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 590);
            this.MinimumSize = new System.Drawing.Size(350, 590);
            this.Name = "Form1";
            this.Text = "Xiaos--闲暇之作";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbxUserCode;
        public System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFps;
        private System.Windows.Forms.TextBox tbxRoomPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxMouseParam;
        private System.Windows.Forms.Label label3;
    }
}

