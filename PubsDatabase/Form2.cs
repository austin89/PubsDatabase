using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubsDatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(string fName, string lName, string auID)
        {
            InitializeComponent();
            authorFNameBox.Text = fName;
            authorLNameBox.Text = lName;
            authorIDBox.Text = auID;
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pubsDataSet.TitleInfo' table. You can move, or remove it, as needed.
            
            try
            {
                this.titleInfoTableAdapter.FillBy(this.pubsDataSet.TitleInfo, authorIDBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            // TODO: This line of code loads data into the 'pubsDataSet.titles' table. You can move, or remove it, as needed.
         

        }

      
    }
}
