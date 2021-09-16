using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment
{
    public class student {

        public string id;
        public string matric;
        public string name;
        
    }
    public partial class find : Form
    {
        List<student> students = new List<student>();
        public find()
        {
            InitializeComponent();
            //use event handeler on find.designer
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void find_TextChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
           
            string name = find_box.Text;
            find_button.Enabled = false;
            this.Text = "processing...";

            Task find = Task.Run(() =>
            {
                List<student> selectedstudents = students.Where(x => x.name == name).ToList();
                var message = new StringBuilder();
                if (selectedstudents.Count == 0)
                {
                    MessageBox.Show("No such name here", "Result");
                }
                else
                {
                    foreach (var selected in selectedstudents)
                    {
                        message.AppendLine("Id: " + selected.id + "  Name: " + selected.name + "  Matric No: " + selected.matric);
                    }
                    MessageBox.Show("Found: \n \n" + message.ToString(), "Result");
                }
            });
            find.GetAwaiter().OnCompleted(() =>
            {
                find_button.Enabled = true;
                this.Text = "find";
            });

        }

        private void find_Load(object sender, EventArgs e)
        {
            find_button.Enabled = false;
            this.Text = "processing...";
            Task findall = Task.Run(() =>
            {
               
                // read the text file line by line
                string[] lines = File.ReadAllLines("db.txt");


                foreach (string data in lines)
                {
                    // split the data by comma line by line
                    char spearator = ',';
                    String[] test = data.Split(spearator);
                    //to skip empty line
                    try
                    {
                        students.Add(new student { id = test[0], matric = test[1], name = test[2] });
                    }
                    catch { }
                }

            });

            findall.GetAwaiter().OnCompleted(() =>
            {
                find_button.Enabled = true;
                this.Text = "find";
            });


        }
    }
}
