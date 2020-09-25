using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("test", -2, HorizontalAlignment.Left);

            ListViewItem item1 = new ListViewItem("test", 0);

            listView1.Items.Add(item1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
