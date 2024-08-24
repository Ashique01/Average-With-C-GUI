using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FrmStorage : Form
    {

        int age;
        string name;
        double salary;

        public FrmStorage()
        {
            InitializeComponent();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            

            age = 25;
            name = "Ashique";
            salary = 25000.45;

            MessageBox.Show("Your name is: " +name);
            MessageBox.Show("Your age is: " + age.ToString());
            MessageBox.Show("Your salary is: " + salary.ToString());
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is: " + name);
        }
    }
}
