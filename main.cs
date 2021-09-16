using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            add.Click += add_Click;
            view.Click += view_Click;
            delete.Click +=delete_Click;
            find.Click += find_Click;

        }
        
 
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        
        private void add_Click(object sender, EventArgs e)
        {
            
                new Add().ShowDialog();
          


        }
        private void view_Click(object sender, EventArgs e)
        {
            
                new view().ShowDialog();
           
        }
        private void delete_Click(object sender, EventArgs e)
        {
            
                new delete().ShowDialog();
           
        }
        private void find_Click(object sender, EventArgs e)
        {
          
                new find().ShowDialog();
           
        }
        private void main_Load(object sender, EventArgs e)
        {

        }

        private void add_Click_1(object sender, EventArgs e)
        {

        }
    }
}
