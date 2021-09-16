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
    
    public partial class delete : Form
    {
        List<student> Students = new List<student>();
     
        public delete()
        {
            InitializeComponent();
            //use event handeler on delete.designer
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            del_button.Enabled = false;
            this.Text = "processing...";
            string id = del_box.Text;
            bool exists = Students.Any(x =>x.id== id);

            if (exists)
            {
                
                Students.RemoveAll(x => x.id == id);
                

                Thread t = new Thread(() =>
                {
                    TextWriter text = new StreamWriter("db.txt");
                    text.Write(""); //prepareing the txt for new data (clearing the txt)
                    text.Close();

                    foreach (var new_students in Students)
                    {
                        TextWriter txt = new StreamWriter("db.txt", true); //prepare the .txt replacing
                        // store the data
                        txt.Write((Environment.NewLine) + new_students.id + "," + new_students.matric + "," + new_students.name); 
                        txt.Close();
                    }

                  
                });
                t.Start();
                t.Join();// for the thread to finish
                del_button.Enabled = true;
                this.Text = "delete";
                MessageBox.Show(id + "Deleted", "Deleted");

            }
            else {
                MessageBox.Show("id not found","Not Found");
                del_button.Enabled = true;
                    this.Text = "delete";
            }
        }

        private void delete_Load(object sender, EventArgs e)
        {
            // read the text file line by line
            del_button.Enabled = false;
            this.Text = "processing...";


            Task collectdata=Task.Run(() =>
            {
                
                string[] lines = File.ReadAllLines("db.txt");
                foreach (string data in lines)
                {   
                    // split the data by comma line by line
                    char spearator = ',';
                    String[] test = data.Split(spearator);
                    //to skip empty line
                    try
                    {
                        Students.Add(new student { id = test[0], matric = test[1], name = test[2] });
                    }
                    catch { }
                }
            });

            collectdata.GetAwaiter().OnCompleted(() =>
            {
                del_button.Enabled = true;
                this.Text = "delete";
            });


        }
    }
}
