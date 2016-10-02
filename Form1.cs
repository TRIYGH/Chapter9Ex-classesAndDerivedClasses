using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classesAndDerivedClasses
{

    public partial class Form1 : Form
    {

        string[] dataArray = new string[99];
        string firstName, lastName, IDNum;
        int counter = 0;

        Person persObj1 = new Person();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            IDNum = textBox3.Text;

            persObj1.FirstName = "John";
            persObj1.LastName = "Smith";
            // can't set ID - it's read only

            textBox1.Text = persObj1.FirstName;
            textBox2.Text = persObj1.LastName;
            textBox3.Text = persObj1.IdNum;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisPerson DisAbObj = new DisPerson();
            DisAbObj.TheDisAb += "***";
            textBox4.Text = DisAbObj.TheDisAb;
        }
    }
}
