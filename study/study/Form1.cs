using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            string name = checkedListBox1.Items[index].ToString();
            MessageBox.Show(name);
            MessageBox.Show(index.ToString());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //combobox默认值
            comboBox1.SelectedIndex = 0;

            //给linklabel赋值
            //超级链接 0开始，4个字符
            linkLabel1.Links.Add(0, 4, @"http://www.baidu.com");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString();
            Process.Start("firefox.exe", url);
        }
    }
}
