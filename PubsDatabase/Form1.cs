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
        SqlConnection c = new SqlConnection("Data Source=CEIT2551204X035\\LOCAL;Initial Catalog=pubs;Integrated Security=True");
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
            // TODO: This line of code loads data into the 'pubsDataSet.titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.pubsDataSet.titles);

            // TODO: This line of code loads data into the 'pubsDataSet.stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.pubsDataSet.stores);

            // TODO: This line of code loads data into the 'pubsDataSet.publishers' table. You can move, or remove it, as needed.
            this.publisherinfoTableAdapter.Fill(this.pubsDataSet.publisherinfo);

            // TODO: This line of code loads data into the 'pubsDataSet.authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.pubsDataSet.authors);
        }


        /// 
        /// Search author
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
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
                filter = filter + "au_fname LIKE '" + aFname + "%' AND ";
            }

            if (aLname != "")
            {
                filter = filter + "au_lname LIKE '" + aLname + "%' AND ";
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
                SqlDataAdapter a = new SqlDataAdapter("Select * From authors Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            } else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From authors", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView1.DataSource = t;
            }
            c.Close();
        }

        /// 
        /// Add author
        /// 
        private void addAuthor_Click(object sender, EventArgs e)
        {
            if (authorFirstName.Text != "" && authorLastName.Text != "" && authorID.Text != "" && authorPhoneNumber.Text != "" && authorZip.Text != "")
            {
                pubsDataSet.authorsRow newAuthor = pubsDataSet.authors.NewauthorsRow();
                newAuthor.au_fname = authorFirstName.Text;
                newAuthor.au_lname = authorLastName.Text;
                newAuthor.au_id = authorID.Text;
                newAuthor.address = authorAddress.Text;
                newAuthor.phone = authorPhoneNumber.Text;
                newAuthor.city = authorCity.Text;
                newAuthor.state = authorState.Text;
                newAuthor.zip = authorZip.Text;
                newAuthor.contract = contractCheckbox.Checked;

                this.pubsDataSet.authors.Rows.Add(newAuthor);
                this.authorsTableAdapter.Update(this.pubsDataSet.authors);
                SqlDataAdapter a = new SqlDataAdapter("Select * From authors", c);
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
                using (c)
                {
                    c.Open();
                    if (authorID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from authors where au_id = '" + authorID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From authors", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView1.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Author ID text field must have a value in order to delete an author."));
                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
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
                filter = filter + "pub_name LIKE '" + publisherName + "%' AND ";
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
                SqlDataAdapter a = new SqlDataAdapter("Select * From publisherinfo Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView2.DataSource = t;
            }
            else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From publisherinfo", c);
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
            //if ()
            //{
            pubsDataSet.publisherinfoRow newPublisher = pubsDataSet.publisherinfo.NewpublisherinfoRow();
            newPublisher.pub_id = pubID.Text;
            newPublisher.pub_name = pubName.Text;
            newPublisher.city = pubCity.Text;
            newPublisher.state = pubState.Text;
            newPublisher.country = pubCountry.Text;
            this.pubsDataSet.publisherinfo.Rows.Add(newPublisher);
            this.publisherinfoTableAdapter.Update(this.pubsDataSet.publisherinfo);
            //}
            //else
            //{

            //}
        }

        /// 
        /// Delete publisher
        ///
        private void pubDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (c)
                {
                    c.Open();
                    if (pubID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from publishers where pub_id = '" + pubID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From publishers", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView2.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Publisher ID text field must have a value in order to delete a publisher."));
                    }

                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
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
            String filter = "";

            if (storesName != "")
            {
                if (storesName.Contains("'"))
                {
                    storesName = storesName.Replace("'", "''");
                }
                filter = filter + "stor_name LIKE '" + storesName + "%' AND ";
            }

            if (storesID != "")
            {
                filter = filter + "stor_id LIKE '" + storesID + "%' AND ";
            }
            if (storesAddress != "")
            {
                filter = filter + "stor_address LIKE '" + storesAddress + "%' AND ";
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

            if (filter.Length > 0)
            {
                String finalFilter = filter.Remove(filter.Length - 4, 3);
                SqlDataAdapter a = new SqlDataAdapter("Select * From stores Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView3.DataSource = t;
            }
            else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From stores", c);
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
            //if ()
            //{
            pubsDataSet.storesRow newStore = pubsDataSet.stores.NewstoresRow();
            newStore.stor_id = storeID.Text;
            newStore.stor_name = storeName.Text;
            newStore.stor_address = storeAddress.Text;
            newStore.city = storeCity.Text;
            newStore.state = storeState.Text;
            newStore.zip = storeZipCode.Text;
            this.pubsDataSet.stores.Rows.Add(newStore);
            this.storesTableAdapter.Update(this.pubsDataSet.stores);
            //}
            //else
            //{

            //}
        }

        /// 
        /// Delete store
        /// 
        private void storeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (c)
                {
                    c.Open();
                    if (storeID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from stores where stor_id = '" + storeID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From stores", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView3.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Store ID text field must have a value in order to delete a store."));
                    }

                }
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
                filter = filter + "title LIKE '" + title.Text + "%' AND ";
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
                filter = filter + "pubDate LIKE '" + datePublished.Text + "%' AND ";
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
                SqlDataAdapter a = new SqlDataAdapter("Select * From titles Where " + finalFilter, c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView4.DataSource = t;
            }
            else if (filter.Length == 0)
            {
                SqlDataAdapter a = new SqlDataAdapter("Select * From titles", c);
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
                cols += "title, ";
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
            if ( datePublished.Text != "")
            {
                cols += "pubdate, ";
                dt = "'" + datePublished.Text + "'";
            }
            String finalFilter = filter.Remove(filter.Length - 2, 2);
            String finalCols = cols.Remove(cols.Length - 2, 2);

            using (c)
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO titles (" + finalCols + ") values (" + finalFilter + ", convert(datetime, " + dt + ", 1))", c))
                {
                    cmd.ExecuteNonQuery();
                }
                SqlDataAdapter a = new SqlDataAdapter("Select * From titles", c);
                DataTable t = new DataTable();
                a.Fill(t);
                dataGridView4.DataSource = t;
                c.Close();
            }

        }

        /// 
        /// Delete titles
        /// 
        private void titleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (c)
                {
                    c.Open();
                    if (titleID.Text != "")
                    {
                        using (SqlCommand com = new SqlCommand("Delete from titles where title_id = '" + titleID.Text + "'", c))
                        {
                            com.ExecuteNonQuery();
                        }
                        SqlDataAdapter a = new SqlDataAdapter("Select * From titles", c);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        dataGridView4.DataSource = t;
                        c.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("The Title ID text field must have a value in order to delete a title."));
                    }

                }
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
    }
}
