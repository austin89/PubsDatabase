namespace PubsDatabase
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.titleIDBox = new System.Windows.Forms.TextBox();
            this.auFNameLabel = new System.Windows.Forms.Label();
            this.auLastNameLabel = new System.Windows.Forms.Label();
            this.auIDLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.pubsDataSet = new PubsDatabase.pubsDataSet();
            this.authorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorInfoTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.AuthorInfoTableAdapter();
            this.tableAdapterManager = new PubsDatabase.pubsDataSetTableAdapters.TableAdapterManager();
            this.authorInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.69884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.30116F));
            this.tableLayoutPanel1.Controls.Add(this.typeBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleIDBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.auFNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.auLastNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.auIDLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 81);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(105, 55);
            this.typeBox.Name = "typeBox";
            this.typeBox.ReadOnly = true;
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 8;
            // 
            // titleIDBox
            // 
            this.titleIDBox.Location = new System.Drawing.Point(105, 29);
            this.titleIDBox.Name = "titleIDBox";
            this.titleIDBox.ReadOnly = true;
            this.titleIDBox.Size = new System.Drawing.Size(100, 20);
            this.titleIDBox.TabIndex = 7;
            // 
            // auFNameLabel
            // 
            this.auFNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auFNameLabel.AutoSize = true;
            this.auFNameLabel.Location = new System.Drawing.Point(3, 6);
            this.auFNameLabel.Name = "auFNameLabel";
            this.auFNameLabel.Size = new System.Drawing.Size(30, 13);
            this.auFNameLabel.TabIndex = 3;
            this.auFNameLabel.Text = "Title:";
            // 
            // auLastNameLabel
            // 
            this.auLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auLastNameLabel.AutoSize = true;
            this.auLastNameLabel.Location = new System.Drawing.Point(3, 32);
            this.auLastNameLabel.Name = "auLastNameLabel";
            this.auLastNameLabel.Size = new System.Drawing.Size(44, 13);
            this.auLastNameLabel.TabIndex = 4;
            this.auLastNameLabel.Text = "Title ID:";
            // 
            // auIDLabel
            // 
            this.auIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auIDLabel.AutoSize = true;
            this.auIDLabel.Location = new System.Drawing.Point(3, 60);
            this.auIDLabel.Name = "auIDLabel";
            this.auIDLabel.Size = new System.Drawing.Size(34, 13);
            this.auIDLabel.TabIndex = 5;
            this.auIDLabel.Text = "Type:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(105, 3);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 6;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorInfoBindingSource
            // 
            this.authorInfoBindingSource.DataMember = "AuthorInfo";
            this.authorInfoBindingSource.DataSource = this.pubsDataSet;
            // 
            // authorInfoTableAdapter
            // 
            this.authorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorInfoTableAdapter = this.authorInfoTableAdapter;
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.discountsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.publisherinfoTableAdapter = null;
            this.tableAdapterManager.royschedTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.storesTableAdapter = null;
            this.tableAdapterManager.titleauthorTableAdapter = null;
            this.tableAdapterManager.TitleInfoTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PubsDatabase.pubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorInfoDataGridView
            // 
            this.authorInfoDataGridView.AutoGenerateColumns = false;
            this.authorInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.authorInfoDataGridView.DataSource = this.authorInfoBindingSource;
            this.authorInfoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.authorInfoDataGridView.Name = "authorInfoDataGridView";
            this.authorInfoDataGridView.Size = new System.Drawing.Size(526, 211);
            this.authorInfoDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "au_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "au_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "au_lname";
            this.dataGridViewTextBoxColumn2.HeaderText = "au_lname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "au_fname";
            this.dataGridViewTextBoxColumn3.HeaderText = "au_fname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn6.HeaderText = "city";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn7.HeaderText = "state";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "zip";
            this.dataGridViewTextBoxColumn8.HeaderText = "zip";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "contract";
            this.dataGridViewCheckBoxColumn1.HeaderText = "contract";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "title_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "title_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.authorInfoDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(804, 217);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 217);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorInfoDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label auFNameLabel;
        private System.Windows.Forms.Label auLastNameLabel;
        private System.Windows.Forms.Label auIDLabel;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource authorInfoBindingSource;
        private pubsDataSetTableAdapters.AuthorInfoTableAdapter authorInfoTableAdapter;
        private pubsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView authorInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox titleIDBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}