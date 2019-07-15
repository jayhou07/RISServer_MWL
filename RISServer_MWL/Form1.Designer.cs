namespace RISServer_MWL
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Modality");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tCit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tCdt = new System.Windows.Forms.TextBox();
            this.tCalledTitle = new System.Windows.Forms.Label();
            this.tIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlog = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 30);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tCit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tCdt);
            this.tabPage1.Controls.Add(this.tCalledTitle);
            this.tabPage1.Controls.Add(this.tIP);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tPort);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Props";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tCit
            // 
            this.tCit.Location = new System.Drawing.Point(164, 166);
            this.tCit.Name = "tCit";
            this.tCit.Size = new System.Drawing.Size(148, 25);
            this.tCit.TabIndex = 9;
            this.tCit.Text = "ClientSideSCU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CallingTitle:";
            // 
            // tCdt
            // 
            this.tCdt.Location = new System.Drawing.Point(164, 121);
            this.tCdt.Name = "tCdt";
            this.tCdt.Size = new System.Drawing.Size(148, 25);
            this.tCdt.TabIndex = 7;
            this.tCdt.Text = "RisServer";
            // 
            // tCalledTitle
            // 
            this.tCalledTitle.AutoSize = true;
            this.tCalledTitle.Location = new System.Drawing.Point(31, 131);
            this.tCalledTitle.Name = "tCalledTitle";
            this.tCalledTitle.Size = new System.Drawing.Size(103, 15);
            this.tCalledTitle.TabIndex = 6;
            this.tCalledTitle.Text = "CalledTitle:";
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(164, 38);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(148, 25);
            this.tIP.TabIndex = 5;
            this.tIP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP:";
            // 
            // tPort
            // 
            this.tPort.Location = new System.Drawing.Point(164, 81);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(148, 25);
            this.tPort.TabIndex = 3;
            this.tPort.Text = "104";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 3);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "节点3";
            treeNode3.Text = "Modality";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(300, 254);
            this.treeView1.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(300, 3);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(748, 294);
            this.dgv.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(388, 21);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(488, 21);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log:";
            // 
            // tlog
            // 
            this.tlog.Location = new System.Drawing.Point(38, 387);
            this.tlog.Name = "tlog";
            this.tlog.Size = new System.Drawing.Size(1044, 349);
            this.tlog.TabIndex = 5;
            this.tlog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 764);
            this.Controls.Add(this.tlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RisServer_MWL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tCdt;
        private System.Windows.Forms.Label tCalledTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tCit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tlog;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

