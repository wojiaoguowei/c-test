using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
           // MessageBox.Show("窗体加载时");
        //}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("窗体关闭时");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击按钮事件");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("读书被选中");
            }
            else
            {
                MessageBox.Show("读书被取消");
            }
        }
    }
}
