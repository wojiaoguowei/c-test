using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo_datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "学号";
            dataGridView1.Columns[1].Name = "姓名";
            dataGridView1.Columns[2].Name = "性别";
            dataGridView1.Columns[3].Name = "手机号";

            object[] row = { 1, "张三", "男", 15904045295 };
            object[] row1 = { 1, "张三", "男", 15904045295 };
            dataGridView1.Rows.Add(row);
            dataGridView1.Rows.Add(row1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = new string[4];
            row[0] = "1";
            row[1] = "1";
            row[2] = "1";
            row[3] = "1";

            dataGridView1.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                object id = dataGridView1[0, i].Value;
                object name = dataGridView1[1, i].Value;
                object sex = dataGridView1.Rows[i].Cells[2].Value;
                object phone = dataGridView1.Rows[i].Cells[3].Value; ;

                Console.WriteLine("{0}, {1}, {2}, {3}", id, name, sex, phone);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //删除

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                //手机号
                string str = e.FormattedValue.ToString();
                if(str.Length != 11)
                {
                    MessageBox.Show("必须为11位!", "Error");
                    e.Cancel = true;
                    return;
                }

                foreach(char ch in str)
                {
                    if(ch < '0' || ch > '9')
                    {
                        MessageBox.Show("必须为数字!", "Error");
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }
    }
}
