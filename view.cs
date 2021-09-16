using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();

        }

        private void viewdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void view_Load(object sender, EventArgs e)
        {   // read the text file line by line

            Task viewall = Task.Run(() =>
            {
            string[] lines = File.ReadAllLines("db.txt");

            foreach (string data in lines)
            {
                // split the data by comma line by line
                char spearator = ',';
                String[] test = data.Split(spearator);
                // to skip empty lines
                try
                {
                    this.dataGridView1.Rows.Add(test[0], test[1], test[2]);
                }
                catch { };
            }

            });
        }
    }
}
