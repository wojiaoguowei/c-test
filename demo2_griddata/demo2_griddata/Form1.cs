using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo2_griddata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //多文档
            frmChild child = new frmChild();
            child.MdiParent = this;
            child.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先获取当前激活子窗体
            Form frm = this.ActiveMdiChild;
            //关闭激活窗体
            frm.Close();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
