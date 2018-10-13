namespace PubsDatabase
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.authorFNameBox = new System.Windows.Forms.TextBox();
            this.authorLNameBox = new System.Windows.Forms.TextBox();
            this.authorIDBox = new System.Windows.Forms.TextBox();
            this.titleInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new PubsDatabase.pubsDataSet();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.authorsTableAdapter();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlesTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.titlesTableAdapter();
            this.titleInfoTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.TitleInfoTableAdapter();
            this.tableAdapterManager = new PubsDatabase.pubsDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.auFNameLabel = new System.Windows.Forms.Label();
            this.auLastNameLabel = new System.Windows.Forms.Label();
            this.auIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.titleInfoDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(911, 228);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
            // 
            // authorFNameBox
            // 
            this.authorFNameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorFNameBox.Location = new System.Drawing.Point(110, 29);
            this.authorFNameBox.Name = "authorFNameBox";
            this.authorFNameBox.ReadOnly = true;
            this.authorFNameBox.Size = new System.Drawing.Size(100, 20);
            this.authorFNameBox.TabIndex = 0;
            // 
            // authorLNameBox
            // 
            this.authorLNameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorLNameBox.Location = new System.Drawing.Point(110, 3);
            this.authorLNameBox.Name = "authorLNameBox";
            this.authorLNameBox.ReadOnly = true;
            this.authorLNameBox.Size = new System.Drawing.Size(100, 20);
            this.authorLNameBox.TabIndex = 1;
            // 
            // authorIDBox
            // 
            this.authorIDBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorIDBox.Location = new System.Drawing.Point(110, 56);
            this.authorIDBox.Name = "authorIDBox";
            this.authorIDBox.ReadOnly = true;
            this.authorIDBox.Size = new System.Drawing.Size(100, 20);
            this.authorIDBox.TabIndex = 2;
            // 
            // titleInfoDataGridView
            // 
            this.titleInfoDataGridView.AllowUserToAddRows = false;
            this.titleInfoDataGridView.AllowUserToDeleteRows = false;
            this.titleInfoDataGridView.AutoGenerateColumns = false;
            this.titleInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.titleInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.titleInfoDataGridView.DataSource = this.titleInfoBindingSource;
            this.titleInfoDataGridView.Location = new System.Drawing.Point(3, 15);
            this.titleInfoDataGridView.Name = "titleInfoDataGridView";
            this.titleInfoDataGridView.ReadOnly = true;
            this.titleInfoDataGridView.Size = new System.Drawing.Size(589, 201);
            this.titleInfoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn1.HeaderText = "title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "title_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn3.HeaderText = "type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pub_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "pub_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pubdate";
            this.dataGridViewTextBoxColumn5.HeaderText = "pubdate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ytd_sales";
            this.dataGridViewTextBoxColumn6.HeaderText = "ytd_sales";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "royalty";
            this.dataGridViewTextBoxColumn7.HeaderText = "royalty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "advance";
            this.dataGridViewTextBoxColumn8.HeaderText = "advance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn9.HeaderText = "price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn10.HeaderText = "notes";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "au_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "au_id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // titleInfoBindingSource
            // 
            this.titleInfoBindingSource.DataMember = "TitleInfo";
            this.titleInfoBindingSource.DataSource = this.pubsDataSet;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.pubsDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "titles";
            this.titlesBindingSource.DataSource = this.pubsDataSet;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // titleInfoTableAdapter
            // 
            this.titleInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.discountsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.publisherinfoTableAdapter = null;
            this.tableAdapterManager.royschedTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.storesTableAdapter = null;
            this.tableAdapterManager.titleauthorTableAdapter = null;
            this.tableAdapterManager.TitleInfoTableAdapter = this.titleInfoTableAdapter;
            this.tableAdapterManager.titlesTableAdapter = this.titlesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PubsDatabase.pubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.69884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.30116F));
            this.tableLayoutPanel1.Controls.Add(this.authorFNameBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.authorLNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.auFNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.auLastNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.auIDLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.authorIDBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 81);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // auFNameLabel
            // 
            this.auFNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auFNameLabel.AutoSize = true;
            this.auFNameLabel.Location = new System.Drawing.Point(3, 6);
            this.auFNameLabel.Name = "auFNameLabel";
            this.auFNameLabel.Size = new System.Drawing.Size(94, 13);
            this.auFNameLabel.TabIndex = 3;
            this.auFNameLabel.Text = "Author First Name:";
            // 
            // auLastNameLabel
            // 
            this.auLastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auLastNameLabel.AutoSize = true;
            this.auLastNameLabel.Location = new System.Drawing.Point(3, 32);
            this.auLastNameLabel.Name = "auLastNameLabel";
            this.auLastNameLabel.Size = new System.Drawing.Size(95, 13);
            this.auLastNameLabel.TabIndex = 4;
            this.auLastNameLabel.Text = "Author Last Name:";
            // 
            // auIDLabel
            // 
            this.auIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.auIDLabel.AutoSize = true;
            this.auIDLabel.Location = new System.Drawing.Point(3, 60);
            this.auIDLabel.Name = "auIDLabel";
            this.auIDLabel.Size = new System.Drawing.Size(55, 13);
            this.auIDLabel.TabIndex = 5;
            this.auIDLabel.Text = "Author ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 228);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Titles by Author";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private pubsDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private pubsDataSetTableAdapters.titlesTableAdapter titlesTableAdapter;
        private System.Windows.Forms.BindingSource titleInfoBindingSource;
        private pubsDataSetTableAdapters.TitleInfoTableAdapter titleInfoTableAdapter;
        private pubsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox authorFNameBox;
        public System.Windows.Forms.TextBox authorLNameBox;
        public System.Windows.Forms.TextBox authorIDBox;
        private System.Windows.Forms.DataGridView titleInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label auFNameLabel;
        private System.Windows.Forms.Label auLastNameLabel;
        private System.Windows.Forms.Label auIDLabel;
    }
}