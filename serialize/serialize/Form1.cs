/*转载地址:https://www.cnblogs.com/shang201215019/p/7907655.html*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.IO;




namespace serialize
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }


        public static void Serial()
        {
            //序列化对象
            Student one = new Student()
            { ID = 1, Name = "武松", Age = 250, Sex = "男" };


            //序列化
            string jsonData = JsonConvert.SerializeObject(one);


            FileStream nFile = new FileStream("jsonTest.txt", FileMode.CreateNew | FileMode.Truncate);
            StreamWriter writer = new StreamWriter(nFile);
            writer.Write(jsonData);
            writer.Close();    //写到文件


            Console.WriteLine(jsonData);  //显示结果
            Console.ReadLine();
        }



        public static void DiserialData()
        {
            FileStream file = new FileStream("jsonTest.txt", FileMode.Open);
            StreamReader sr = new StreamReader(file);


            string readJson = sr.ReadToEnd();   //从文件读出来


            Student descJsonStu = JsonConvert.DeserializeObject<Student>(readJson);//反序列化


            Console.WriteLine(descJsonStu.ID);
            Console.WriteLine(descJsonStu.Name);
            Console.WriteLine(descJsonStu.Age);
            Console.WriteLine(descJsonStu.Sex);


            Console.ReadLine();


        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////序列化对象
            //Student one = new Student()
            //{ ID = 1, Name = "武松", Age = 250, Sex = "男" };

            ////序列化
            //string jsonData = JsonConvert.SerializeObject(one);

            //Console.WriteLine(jsonData);  //显示结果
            //Console.ReadLine();

            ////反序列化对象
            //string str = "{\"ID\":2,\"Name\":\"鲁智深\",\"Age\":230,\"Sex\":\"男\"}";

            ////反序列化
            //Student two = JsonConvert.DeserializeObject<Student>(str);

            //Console.WriteLine(
            //       string.Format("学生信息  ID:{0},姓名:{1},年龄:{2},性别:{3}",
            //       two.ID, two.Name, two.Age, two.Sex));//显示结果
            //Console.ReadLine();

            serialize.Student.Serial();
            serialize.Student.DiserialData();
        }
    }
}
