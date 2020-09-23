namespace study
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点5", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点6", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点4");
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(203, 477);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(170, 323);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 22);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(170, 370);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 22);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "广东省",
            "广西省",
            "湖南省",
            "湖北省",
            "山东省",
            "陕西省",
            "河南省",
            "河北省"});
            this.comboBox1.Location = new System.Drawing.Point(56, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "label1";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(170, 406);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 22);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "checkBox1";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(702, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "列表1",
            "列表2",
            "列表3"});
            this.listBox1.Location = new System.Drawing.Point(324, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 328);
            this.listBox1.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(61, 228);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(179, 28);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(85, 547);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(154, 28);
            this.numericUpDown1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::study.Properties.Resources._20160515192512776;
            this.pictureBox1.Location = new System.Drawing.Point(94, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "这里是图片");
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::study.Properties.Resources._20160515192512776;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(334, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.toolTip1.SetToolTip(this.button2, "这里是按钮");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(657, 208);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点7";
            treeNode1.Text = "节点7";
            treeNode2.Name = "节点8";
            treeNode2.Text = "节点8";
            treeNode3.Name = "节点5";
            treeNode3.Text = "节点5";
            treeNode4.Name = "节点9";
            treeNode4.Text = "节点9";
            treeNode5.Name = "节点10";
            treeNode5.Text = "节点10";
            treeNode6.Name = "节点6";
            treeNode6.Text = "节点6";
            treeNode7.Name = "节点0";
            treeNode7.Text = "节点0";
            treeNode8.Name = "节点1";
            treeNode8.Text = "节点1";
            treeNode9.Name = "节点2";
            treeNode9.Text = "节点2";
            treeNode10.Name = "节点3";
            treeNode10.Text = "节点3";
            treeNode11.Name = "节点4";
            treeNode11.Text = "节点4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(240, 367);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 731);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

