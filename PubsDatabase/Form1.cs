using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PubsDatabase
{
    public partial class Form1 : Form
    {
        //SqlConnection c = new SqlConnection("Data Source=CEIT2551204X035\\LOCAL;Initial Catalog=pubs;Integrated Security=True");


        
        SqlConnection c = new SqlConnection("Data Source = pubs.cg4pyjwjv4wq.us-east-1.rds.amazonaws.com; Initial Catalog = pubs; Persist Security Info=True;User ID = pubsuser; Password=E5YWoYmQZ37THsy9");
        public Form1()
        {
            InitializeComponent();
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pubsDataSet1.TITLE' table. You can move, or remove it, as needed.
            this.tITLETableAdapter.Fill(this.pubsDataSet1.TITLE);
            // TODO: This line of code loads data into the 'pubsDataSet1.STORE' table. You can move, or remove it, as needed.
            this.sTORETableAdapter.Fill(this.pubsDataSet1.STORE);
            // TODO: This line of code loads data into the 'pubsDataSet1.PUBLISHER' table. You can move, or remove it, as needed.
            this.pUBLISHERTableAdapter.Fill(this.pubsDataSet1.PUBLISHER);
            // TODO: This line of code loads data into the 'pubsDataSet1.AUTHOR' table. You can move, or remove it, as needed.
            this.aUTHORTableAdapter.Fill(this.pubsDataSet1.AUTHOR); 
        }


        /// 
        /// Search author
        /// 
        private void authorSubmit_Click(object sender, EventArgs e)
        {
           // using (c)
            //{
                c.Open();
                String aID = authorID.Text;
                String aFname = authorFirstName.Text;
                String aLname = authorLastName.Text;
                String auPhone = authorPhoneNumber.Text;
                String filter = "";

                if (aID != "")
                {
                    filter = filter + "au_ID LIKE '" + aID + "%' AND ";
                }

                if (aFname != "")
                {
                    filter = filter + "first_name LIKE '" + aFname + "%' AND ";
                }

                if (aLname != "")
                {
                    filter = filter + "last_name LIKE '" + aLname + "%' AND ";
                }

                if (auPhone != "")
                {
                    filter = filter + "phone LIKE '" + auPhone + "%' AND ";
                }

                if (authorAddress.Text != "")
                {
                    filter = filter + "address LIKE '" + authorAddress.Text + "%' AND ";
                }

                if (authorCity.Text != "")
                {
                    filter = filter + "city LIKE '" + authorCity.Text + "%' AND ";
                }

                if (authorState.Text != "")
                {
                    filter = filter + "state LIKE '" + authorState.Text + "%' AND ";
                }

                if (authorZip.Text != "")
                {
                    filter = filter + "zip LIKE '" + authorZip.Text + "%' AND ";
                }
                if (contractCheckbox.Checked && authorInclude.Checked)
                {
                    filter = filter + "contract = 1 AND ";
                }
                else if (!contractCheckbox.Checked && authorInclude.Checked)
                {
                    filter = filter + "contract = 0 AND ";
                }

                if (filter.Length > 0)
                {
                    String finalFilter = filter.Remove(filter.Length - 4, 3);
                    SqlDataAdapter a = new SqlDataAdapter("Select * From AUTHOR Where " + finalFilter, c);
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
                else if (filter.Length == 0)
                {
                    SqlDataAdapter a = new SqlDataAdapter("Select * From AUTHOR", c);
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridView1.DataSource = t;
                }
                c.Close();
            //}
           /* c.Open();
            String aID = authorID.Text;
            String aFname = authorFirstName.Text;
            String aLname = authorLastName.Text;
            String auPhone = authorPhoneNumber.Text;
            String filter = "";

            if (aID != "")
            {
                filter = filter + "au_ID LIKE '" + aID + "%' AND ";
            }

            if (aFname != "")
            {
                filter = filter + "first_name LIKE '" + aFname + "%' AND ";
            }

            if (aLname != "")
            {
                filter = filter + "last_name LIKE '" + aLname + "%' AND ";
            }

            if (auPhone != "")
            {
                filter = filter + "phone LIKE '" + auPhone + "%' AND ";
            }

            if(authorAddress.Text != "")
            {
                filter = filter + "address LIKE '" + authorAddress.Text + "%' AND ";
            }

            if(authorCity.Text != "")
            {
                filter = filter + "city LIKE '" + authorCity.Text + "%' AND ";
            }

            if(authorState.Text != "")
            {
                filter = filter + "state LIKE '" + authorState.Text + "%' AND ";
            }

            if (authorZip.Text != "")
            {
                filter = filter + "zip LIKE '" + authorZip.Text + "%' AND ";
            }
            if (contractCheckbox.Checked && authorInclude.Checked)
            {
                filter = filter + "contract = 1 AND ";
            }else if(!contractCheckbox.Checked && authorInclude.Checked)
            {
                filter = filter + "contract = 0 AND ";
            }

            if (filter.Length > 0)
            {
                String finalFilter = filter.Remove(filter.Length - 4, 3);
                SqlDataAdapter a = new SqlDataAdapter("Select * From AUTHOR Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            } else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From AUTHOR", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
            c.Close();
            */
        }

        /// 
        /// Add author
        /// 
        private void addAuthor_Click(object sender, EventArgs e)
        {
            c.Open();
            if (authorFirstName.Text != "" && authorLastName.Text != "" && authorID.Text != "" && authorPhoneNumber.Text != "" && authorZip.Text != "")
            {
                pubsDataSet1.AUTHORRow newAuthor = pubsDataSet1.AUTHOR.NewAUTHORRow();
                newAuthor.first_name = authorFirstName.Text;
                newAuthor.last_name = authorLastName.Text;
                newAuthor.au_id = authorID.Text;
                newAuthor.address = authorAddress.Text;
                newAuthor.phone = authorPhoneNumber.Text;
                newAuthor.city = authorCity.Text;
                newAuthor.state = authorState.Text;
                newAuthor.zip = authorZip.Text;
                newAuthor.contract = contractCheckbox.Checked;

                

                this.pubsDataSet1.AUTHOR.Rows.Add(newAuthor);
                this.aUTHORTableAdapter.Update(this.pubsDataSet1.AUTHOR);
                SqlDataAdapter a = new SqlDataAdapter("Select * From author", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
                c.Close();
            }
            else
            {
                MessageBox.Show(string.Format("One or more text fields are empty that are required to add a new author. The required text fields are:\nAuthor ID\nFirst Name\nLast Name\nPhone Number\nZip Code"));
            }
        }

        ///
        /// Delete author
        /// 
        private void deleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                //using (c)
                //{
                    c.Open();
                    if (authorID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from author where au_id = '" + authorID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From author", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView1.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Author ID text field must have a value in order to delete an author."));
                    }
                //}
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Author ID not found. Please enter a valid Author ID to delete."));
            }



        }

        ///
        /// Clear all author fields
        /// 
        private void authorClear_Click(object sender, EventArgs e)
        {
            if (authorID.Text != ""){authorID.Text = "";}

            if (authorFirstName.Text != ""){authorFirstName.Text = "";}

            if (authorLastName.Text != ""){authorLastName.Text = "";}

            if (authorPhoneNumber.Text != ""){authorPhoneNumber.Text = "";}

            if (authorAddress.Text != ""){authorAddress.Text = "";}

            if (authorCity.Text != ""){authorCity.Text = "";}

            if (authorState.Text != ""){authorState.Text = "";}

            if (authorZip.Text != ""){authorZip.Text = "";}

            if (contractCheckbox.Checked){contractCheckbox.Checked = false;}

            if (authorInclude.Checked) { authorInclude.Checked = false; }


        }

        ///
        /// Search publishers
        ///
        private void pubSubmit_Click(object sender, EventArgs e)
        {
            c.Open();
            String publisherName = pubName.Text;
            String publisherID = pubID.Text;
            String publisherCity = pubCity.Text;
            String publisherState = pubState.Text;
            String publisherCountry = pubCountry.Text;
            String filter = "";

            if (publisherName != "")
            {
                filter = filter + "publisher_name LIKE '" + publisherName + "%' AND ";
            }

            if (publisherID != "")
            {
                filter = filter + "pub_id LIKE '" + publisherID + "%' AND ";
            }

            if (publisherCity != "")
            {
                filter = filter + "city LIKE '" + publisherCity + "%' AND ";
            }
            if (publisherState != "")
            {
                filter = filter + "state LIKE '" + publisherState + "%' AND ";
            }
            if (publisherCountry != "")
            {
                filter = filter + "country LIKE '" + publisherCountry + "%' AND ";
            }

            if (filter.Length > 0)
            {
                String finalFilter = filter.Remove(filter.Length - 4, 3);
                SqlDataAdapter a = new SqlDataAdapter("Select * From PUBLISHER Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView2.DataSource = t;
            }
            else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From PUBLISHER", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView2.DataSource = t;
            }
            c.Close();
        }

        /// 
        /// Add publisher
        /// 
        private void pubAdd_Click(object sender, EventArgs e)
        {
            string id = pubID.Text;
            bool check = true;
            foreach(char c in id)
            {
                if(c < '0' || c > '9')
                {
                    check = false;
                }
            }
            if (pubID.Text.Length == 4 && pubID.Text.StartsWith("99") && check)
            {
                pubsDataSet1.PUBLISHERRow newPublisher = pubsDataSet1.PUBLISHER.NewPUBLISHERRow();
                newPublisher.pub_id = pubID.Text;
                newPublisher.publisher_name = pubName.Text;
                newPublisher.city = pubCity.Text;
                newPublisher.state = pubState.Text;
                newPublisher.country = pubCountry.Text;
                newPublisher.public_relationship_info = null;
                newPublisher.logo = null;
                this.pubsDataSet1.PUBLISHER.Rows.Add(newPublisher);
                this.pUBLISHERTableAdapter.Update(this.pubsDataSet1.PUBLISHER);
            }
            else
            {
                MessageBox.Show(string.Format("The following required text field to add a new publisher is empty:\nPublisher ID\n\nThe Publisher ID must be a 4-digit code starting with 99."));
            }
        }

        /// 
        /// Delete publisher
        ///
        private void pubDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //using (c)
                //{
                    c.Open();
                    if (pubID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from publisher where pub_id = '" + pubID.Text + "'", c))
                        {
                            Console.Write("HERE");
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From publisher", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView2.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Publisher ID text field must have a value in order to delete a publisher."));
                    }

                //}
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Please enter a valid Publisher ID to delete a publisher."));
            }



        }

        /// 
        /// Clear all publisher fields
        /// 
        private void pubClear_Click(object sender, EventArgs e)
        {
            if (pubName.Text != ""){pubName.Text = "";}

            if(pubID.Text != ""){pubID.Text = "";}

            if(pubCity.Text != ""){pubCity.Text = "";}

            if(pubState.Text != ""){pubState.Text = "";}

            if(pubCountry.Text != ""){pubCountry.Text = "";}
        }

        /// 
        /// Search stores
        /// 
        private void storeSubmit_Click(object sender, EventArgs e)
        {
            c.Open();
            String storesName = storeName.Text;
            String storesID = storeID.Text;
            String storesAddress = storeAddress.Text;
            String storesCity = storeCity.Text;
            String storesState = storeState.Text;
            String storesZip = storeZipCode.Text;
            String storesPromotion = storePromotion.Text;
            String filter = "";

            if (storesName != "")
            {
                if (storesName.Contains("'"))
                {
                    storesName = storesName.Replace("'", "''");
                }
                filter = filter + "store_name LIKE '" + storesName + "%' AND ";
            }

            if (storesID != "")
            {
                filter = filter + "stor_id LIKE '" + storesID + "%' AND ";
            }
            if (storesAddress != "")
            {
                filter = filter + "store_address LIKE '" + storesAddress + "%' AND ";
            }

            if (storesCity != "")
            {
                filter = filter + "city LIKE '" + storesCity + "%' AND ";
            }
            if (storesState != "")
            {
                filter = filter + "state LIKE '" + storesState + "%' AND ";
            }
            if (storesZip != "")
            {
                filter = filter + "zip LIKE '" + storesZip + "%' AND ";
            }
            if (storesPromotion != "")
            {
                filter = filter + "promotion_id LIKE '" + storesPromotion + "%' AND ";
            }

            if (filter.Length > 0)
            {
                String finalFilter = filter.Remove(filter.Length - 4, 3);
                SqlDataAdapter a = new SqlDataAdapter("Select * From store Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView3.DataSource = t;
            }
            else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From store", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView3.DataSource = t;
            }
            c.Close();
        }

        ///
        /// Add store
        /// 
        private void storeAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (char c in storeID.Text)
            {
                if (c < '0' || c > '9')
                {
                    check = false;
                }
            }
            if (check && storeID.Text.Length == 4)
            {
           // pubsDataSet.storesRow newStore = pubsDataSet.stores.NewstoresRow();
            pubsDataSet1.STORERow newStore = pubsDataSet1.STORE.NewSTORERow();
            newStore.stor_id = storeID.Text;
            newStore.store_name = storeName.Text;
            newStore.store_address = storeAddress.Text;
            newStore.city = storeCity.Text;
            newStore.state = storeState.Text;
            newStore.zip = storeZipCode.Text;
            if(storePromotion.Text != "")
                {
                    bool check2 = true;
                    foreach (char c in storePromotion.Text)
                    {
                        if (c < '0' || c > '9')
                        {
                            check2 = false;
                        }
                    }
                    if (check2)
                    {   
                        newStore.promotion_id = int.Parse(storePromotion.Text);
                    }
                }
            
            this.pubsDataSet1.STORE.Rows.Add(newStore);
            this.sTORETableAdapter.Update(this.pubsDataSet1.STORE);
            }else
            {
                MessageBox.Show(string.Format("The following required text field to add a new store is empty:\nStore ID\n\nThe Store ID must be a 4-digit code."));
            }
        }

        /// 
        /// Delete store
        /// 
        private void storeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //using (c)
                //{
                    c.Open();
                    if (storeID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from store where stor_id = '" + storeID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From store", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView3.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Store ID text field must have a value in order to delete a store."));
                    }

                //}
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        ///
        /// Clear all store fields
        /// 
        private void storeClear_Click(object sender, EventArgs e)
        {
            if(storeName.Text != ""){storeName.Text = "";}

            if(storeID.Text != ""){storeID.Text = "";}

            if(storeAddress.Text != ""){storeAddress.Text = "";}

            if(storeCity.Text != ""){storeCity.Text = "";}

            if(storeState.Text != ""){storeState.Text = "";}

            if(storeZipCode.Text != ""){storeZipCode.Text = "";}

            if(storePromotion.Text != ""){ storePromotion.Text = ""; }
        }

        /// 
        /// Search titles
        ///
        private void titleSubmit_Click(object sender, EventArgs e)
        {
            c.Open();
            String filter = "";

            if (titleID.Text != "")
            {
                filter = filter + "title_id LIKE '" + titleID.Text + "%' AND ";
            }

            if (title.Text != "")
            {
                filter = filter + "title_name LIKE '" + title.Text + "%' AND ";
            }

            if (genre.Text != "")
            {
                filter = filter + "type LIKE '" + genre.Text + "%' AND ";
            }
            if (titlePubID.Text != "")
            {
                filter = filter + "pub_id LIKE '" + titlePubID.Text + "%' AND ";
            }
            if (datePublished.Text != "")
            {
                filter = filter + "publication_date LIKE '" + datePublished.Text + "%' AND ";
            }
            /*
            if (titleAuthorFName.Text != "")
            {
                filter = filter + "country LIKE '" + titleAuthorFName.Text + "%' AND ";
            }
            if (titleAuthorLName.Text != "")
            {
                filter = filter + "country LIKE '" + titleAuthorLName.Text + "%' AND ";
            }
            */

            if (filter.Length > 0)
            {
                String finalFilter = filter.Remove(filter.Length - 4, 3);
                SqlDataAdapter a = new SqlDataAdapter("Select * From title Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView4.DataSource = t;
            }
            else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From title", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView4.DataSource = t;
            }
            c.Close();

        }

        ///
        /// Add titles
        /// 
        private void titleAdd_Click(object sender, EventArgs e)
        {
            //c.Open();
            bool pubIDCheck = true;
            foreach (char c in titlePubID.Text)
            {
                if (c < '0' || c > '9')
                {
                    pubIDCheck = false;
                }
            }
            if (pubIDCheck && title.Text != "" && titleID.Text != "" && genre.Text != "")
            {
                String filter = "";
                String cols = "";
                String dt = "";

                if (titleID.Text != "")
                {
                    cols += "title_id, ";
                    filter = filter + "'" + titleID.Text + "', ";
                }

                if (title.Text != "")
                {
                    cols += "title_name, ";
                    filter = filter + "'" + title.Text + "', ";
                }

                if (genre.Text != "")
                {
                    cols += "type, ";
                    filter = filter + "'" + genre.Text + "', ";
                }
                if (titlePubID.Text != "")
                {
                    cols += "pub_id, ";
                    filter = filter + "'" + titlePubID.Text + "', ";
                }
                if (datePublished.Text != "")
                {
                    cols += "publication_date, ";
                    dt = "'" + datePublished.Text + "'";
                }
                String finalFilter = filter.Remove(filter.Length - 2, 2);
                String finalCols = cols.Remove(cols.Length - 2, 2);

                
                c.Open();
                if(datePublished.Text == "")
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO title (" + finalCols + ") values (" + finalFilter + ")", c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO title (" + finalCols + ") values (" + finalFilter + ", convert(datetime, " + dt + ", 1))", c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                
                SqlDataAdapter a = new SqlDataAdapter("Select * From title", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView4.DataSource = t;
                c.Close();
                
            }
            else
            {
                MessageBox.Show(string.Format("One or more of the following required text fields to add a new title are empty:\nTitle ID\nTitle Name\nGenre"));
            }



        }

        /// 
        /// Delete titles
        /// 
        private void titleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //using (c)
                //{
                    c.Open();
                    if (titleID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from title where title_id = '" + titleID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From title", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView4.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Title ID text field must have a value in order to delete a title."));
                    }

                //}
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        /// 
        /// Clear all fields in titles
        /// 
        private void titleClear_Click(object sender, EventArgs e)
        {
            if(titleID.Text != ""){titleID.Text = "";}

            if(title.Text != ""){title.Text = "";}

            if(genre.Text != ""){genre.Text = "";}

            if (titlePubID.Text != ""){titlePubID.Text = "";}
            
            if(datePublished.Text != ""){datePublished.Text = "";}
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f2 = new Form2(this.dataGridView1.CurrentRow.Cells[2].Value.ToString(), this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
           
            f2.ShowDialog();
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form3 f3 = new Form3(this.dataGridView4.CurrentRow.Cells[1].Value.ToString(), this.dataGridView4.CurrentRow.Cells[0].Value.ToString(), this.dataGridView4.CurrentRow.Cells[2].Value.ToString());
            f3.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f2 = new Form2(this.dataGridView1.CurrentRow.Cells[2].Value.ToString(), this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            f2.ShowDialog();
        }


    }
}
