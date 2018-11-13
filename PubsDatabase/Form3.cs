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
    public partial class Form3 : Form
    {
        public Form3(string title, string titleID, string type)
        {
           
            InitializeComponent();
            titleBox.Text = title;
            titleIDBox.Text = titleID;
            typeBox.Text = type;
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pubsDataSet.AuthorInfo' table. You can move, or remove it, as needed.
            try
            {
                this.authorInfoTableAdapter.FillBy(this.pubsDataSet.AuthorInfo, this.titleIDBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
