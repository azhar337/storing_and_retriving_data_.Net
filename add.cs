using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nancy.Json;
using System.Threading;

namespace assigment
{ 
   
   
    public partial class Add : Form
    {
        object[] student = new object[3];
        private int myid; 
        public Add()
        {

            
            InitializeComponent();
            submit.Click += Submit_Click;


        }
       
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void menu_Click(object sender, EventArgs e)
        {
            
        }

        private void matric_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {   //getting the current id number from the id.txt

           
            StreamReader sr = new StreamReader("id.txt");
            string line = sr.ReadLine();
            sr.Close();
            //convert the current id to int and store inpublic variable
            Int32.TryParse(line, out myid);
            //display the current mctid 
            idbox.Text = "MCT"+myid.ToString();
           

    }
        private void Submit_Click(object sender, EventArgs e)
        {
            // if input availability
            if (!String.IsNullOrEmpty(matricbox.Text) && !String.IsNullOrEmpty(namebox.Text))
            {
                //get the detail from the user input. check the validity of matric onlly number
                if (Int32.TryParse(matricbox.Text, out int matirc))
                {
                    myid = myid + 1; // add id on click

                    // store latest id on id.txt
                    TextWriter id = new StreamWriter("id.txt");
                    string this_id = myid.ToString();
                    id.Write(this_id);
                    id.Close();


                    var name = namebox.Text;
                    TextWriter txt = new StreamWriter("db.txt", true); //prepare the .txt not replacing but adding 

                    // store in array format and serilize to make deserialization easier
                    //student[0] = "MCT" + this_id;
                    // student[1] = matirc;
                    // student[2] = name;
                    // string er = new JavaScriptSerializer().Serialize(student);
                    txt.Write((Environment.NewLine) + "MCT" + this_id + "," + matirc + "," + name); // store the data
                    txt.Close();
                    MessageBox.Show("Successfully added data with MCT" + this_id, "Success"); //pop up

                    //on update process
                    idbox.Text = "MCT" + this_id;
                    matricbox.Text = null;
                    namebox.Text = null;
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("please enter valid matric number", "error");
                    matricbox.Text = null;
                }

            }
            else {

                if (String.IsNullOrEmpty(matricbox.Text))
                {
                    MessageBox.Show("please enter matric number", "error");
                }
                else if (String.IsNullOrEmpty(namebox.Text))
                {

                    MessageBox.Show("please enter name", "error");
                }
                else {

                    MessageBox.Show("Some Error occured", "error");
                    this.Close();

                } 
                    
            
            
            }
            
        }

        private void idbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
