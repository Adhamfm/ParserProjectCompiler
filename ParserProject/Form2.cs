using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserProject
{
    public partial class Form2 : Form
    {
        private Form1 mainForm = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            // mylist = mainForm.SortedList();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

            //drawTest(root);
            //drawTest(root2);
        }
        
        

    }
}
