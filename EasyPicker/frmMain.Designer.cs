namespace EasyPicker {
    partial class frmMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSpawn = new System.Windows.Forms.Button();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpawn);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "随机";
            // 
            // btnSpawn
            // 
            this.btnSpawn.Location = new System.Drawing.Point(177, 24);
            this.btnSpawn.Name = "btnSpawn";
            this.btnSpawn.Size = new System.Drawing.Size(51, 24);
            this.btnSpawn.TabIndex = 5;
            this.btnSpawn.Text = "生成";
            this.btnSpawn.UseVisualStyleBackColor = true;
            this.btnSpawn.Click += new System.EventHandler(this.btnSpawn_Click);
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtE.Location = new System.Drawing.Point(130, 25);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(25, 23);
            this.txtE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(107, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "~";
            // 
            // txtS
            // 
            this.txtS.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtS.Location = new System.Drawing.Point(76, 25);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(25, 23);
            this.txtS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "简易说明：随机区块的选号是在一定范围内随机生成（首次启动后会在当前目录创建配置文件，可根据配置文件修改默认值）\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "范围";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(148, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designed by mkpoli\r\n";
            // 
            // lblOut
            // 
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOut.Location = new System.Drawing.Point(12, 151);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(258, 30);
            this.lblOut.TabIndex = 6;
            this.lblOut.Text = "00";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(11, 190);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(258, 38);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "（无）";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "修改配置文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "简易点名器 Ver 1.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpawn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button1;
    }
}

