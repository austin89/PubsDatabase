namespace PubsDatabase
{
    partial class Form1
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
            System.Windows.Forms.Label au_idLabel;
            System.Windows.Forms.Label au_fnameLabel;
            System.Windows.Forms.Label au_lnameLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label authorCityLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label pubCityLabel;
            System.Windows.Forms.Label pubIDLabel;
            System.Windows.Forms.Label pubNameLabel;
            System.Windows.Forms.Label pubCountryLabel;
            System.Windows.Forms.Label pubStateLabel;
            System.Windows.Forms.Label storeStateLabel;
            System.Windows.Forms.Label stoerCityLabel;
            System.Windows.Forms.Label storeAddressLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label storeNameLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label titleIDLabel;
            System.Windows.Forms.Label datePublishedLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pubsTabControl = new System.Windows.Forms.TabControl();
            this.authorsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.authorInclude = new System.Windows.Forms.CheckBox();
            this.authorClear = new System.Windows.Forms.Button();
            this.contractCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteAuthor = new System.Windows.Forms.Button();
            this.addAuthor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.authorZipLabel = new System.Windows.Forms.Label();
            this.authorZip = new System.Windows.Forms.TextBox();
            this.authorAddress = new System.Windows.Forms.TextBox();
            this.authorCity = new System.Windows.Forms.TextBox();
            this.authorState = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.authorPhoneNumber = new System.Windows.Forms.TextBox();
            this.authorID = new System.Windows.Forms.TextBox();
            this.authorFirstName = new System.Windows.Forms.TextBox();
            this.authorLastName = new System.Windows.Forms.TextBox();
            this.authorSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aufnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubsDataSet = new PubsDatabase.pubsDataSet();
            this.publishersTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pubClear = new System.Windows.Forms.Button();
            this.pubDelete = new System.Windows.Forms.Button();
            this.pubAdd = new System.Windows.Forms.Button();
            this.pubSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pubState = new System.Windows.Forms.TextBox();
            this.pubCountry = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pubName = new System.Windows.Forms.TextBox();
            this.pubID = new System.Windows.Forms.TextBox();
            this.pubCity = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pubidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.pr_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.storeClear = new System.Windows.Forms.Button();
            this.storeDelete = new System.Windows.Forms.Button();
            this.storeAdd = new System.Windows.Forms.Button();
            this.storeSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.storeCity = new System.Windows.Forms.TextBox();
            this.storeState = new System.Windows.Forms.TextBox();
            this.storeZipCode = new System.Windows.Forms.TextBox();
            this.storeZip = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.storeName = new System.Windows.Forms.TextBox();
            this.storeID = new System.Windows.Forms.TextBox();
            this.storeAddress = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.storidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titlesTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.titleView = new System.Windows.Forms.Button();
            this.titleClear = new System.Windows.Forms.Button();
            this.titleDelete = new System.Windows.Forms.Button();
            this.titleAdd = new System.Windows.Forms.Button();
            this.titleSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.datePublished = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.titlePubIDLabel = new System.Windows.Forms.Label();
            this.titleID = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.titlePubID = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.titleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.royaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ytdsalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.authorsTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.authorsTableAdapter();
            this.tableAdapterManager = new PubsDatabase.pubsDataSetTableAdapters.TableAdapterManager();
            this.publisherinfoTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.publisherinfoTableAdapter();
            this.storesTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.storesTableAdapter();
            this.titlesTableAdapter = new PubsDatabase.pubsDataSetTableAdapters.titlesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            au_idLabel = new System.Windows.Forms.Label();
            au_fnameLabel = new System.Windows.Forms.Label();
            au_lnameLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            authorCityLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            pubCityLabel = new System.Windows.Forms.Label();
            pubIDLabel = new System.Windows.Forms.Label();
            pubNameLabel = new System.Windows.Forms.Label();
            pubCountryLabel = new System.Windows.Forms.Label();
            pubStateLabel = new System.Windows.Forms.Label();
            storeStateLabel = new System.Windows.Forms.Label();
            stoerCityLabel = new System.Windows.Forms.Label();
            storeAddressLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            storeNameLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            titleIDLabel = new System.Windows.Forms.Label();
            datePublishedLabel = new System.Windows.Forms.Label();
            this.pubsTabControl.SuspendLayout();
            this.authorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).BeginInit();
            this.publishersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherinfoBindingSource)).BeginInit();
            this.storesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            this.titlesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).BeginInit();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // au_idLabel
            // 
            au_idLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            au_idLabel.AutoSize = true;
            au_idLabel.Location = new System.Drawing.Point(3, 6);
            au_idLabel.Name = "au_idLabel";
            au_idLabel.Size = new System.Drawing.Size(55, 13);
            au_idLabel.TabIndex = 0;
            au_idLabel.Text = "Author ID:";
            // 
            // au_fnameLabel
            // 
            au_fnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            au_fnameLabel.AutoSize = true;
            au_fnameLabel.Location = new System.Drawing.Point(3, 32);
            au_fnameLabel.Name = "au_fnameLabel";
            au_fnameLabel.Size = new System.Drawing.Size(60, 13);
            au_fnameLabel.TabIndex = 2;
            au_fnameLabel.Text = "First Name:";
            // 
            // au_lnameLabel
            // 
            au_lnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            au_lnameLabel.AutoSize = true;
            au_lnameLabel.Location = new System.Drawing.Point(3, 58);
            au_lnameLabel.Name = "au_lnameLabel";
            au_lnameLabel.Size = new System.Drawing.Size(61, 13);
            au_lnameLabel.TabIndex = 4;
            au_lnameLabel.Text = "Last Name:";
            // 
            // stateLabel
            // 
            stateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(3, 58);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 4;
            stateLabel.Text = "State:";
            // 
            // authorCityLabel
            // 
            authorCityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            authorCityLabel.AutoSize = true;
            authorCityLabel.Location = new System.Drawing.Point(3, 32);
            authorCityLabel.Name = "authorCityLabel";
            authorCityLabel.Size = new System.Drawing.Size(27, 13);
            authorCityLabel.TabIndex = 2;
            authorCityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(3, 6);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // pubCityLabel
            // 
            pubCityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pubCityLabel.AutoSize = true;
            pubCityLabel.Location = new System.Drawing.Point(3, 58);
            pubCityLabel.Name = "pubCityLabel";
            pubCityLabel.Size = new System.Drawing.Size(27, 13);
            pubCityLabel.TabIndex = 4;
            pubCityLabel.Text = "City:";
            // 
            // pubIDLabel
            // 
            pubIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pubIDLabel.AutoSize = true;
            pubIDLabel.Location = new System.Drawing.Point(3, 32);
            pubIDLabel.Name = "pubIDLabel";
            pubIDLabel.Size = new System.Drawing.Size(67, 13);
            pubIDLabel.TabIndex = 2;
            pubIDLabel.Text = "Publisher ID:";
            // 
            // pubNameLabel
            // 
            pubNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pubNameLabel.AutoSize = true;
            pubNameLabel.Location = new System.Drawing.Point(3, 6);
            pubNameLabel.Name = "pubNameLabel";
            pubNameLabel.Size = new System.Drawing.Size(81, 13);
            pubNameLabel.TabIndex = 0;
            pubNameLabel.Text = "PublisherName:";
            // 
            // pubCountryLabel
            // 
            pubCountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pubCountryLabel.AutoSize = true;
            pubCountryLabel.Location = new System.Drawing.Point(3, 34);
            pubCountryLabel.Name = "pubCountryLabel";
            pubCountryLabel.Size = new System.Drawing.Size(46, 13);
            pubCountryLabel.TabIndex = 2;
            pubCountryLabel.Text = "Country:";
            // 
            // pubStateLabel
            // 
            pubStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pubStateLabel.AutoSize = true;
            pubStateLabel.Location = new System.Drawing.Point(3, 6);
            pubStateLabel.Name = "pubStateLabel";
            pubStateLabel.Size = new System.Drawing.Size(35, 13);
            pubStateLabel.TabIndex = 0;
            pubStateLabel.Text = "State:";
            // 
            // storeStateLabel
            // 
            storeStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            storeStateLabel.AutoSize = true;
            storeStateLabel.Location = new System.Drawing.Point(3, 32);
            storeStateLabel.Name = "storeStateLabel";
            storeStateLabel.Size = new System.Drawing.Size(35, 13);
            storeStateLabel.TabIndex = 2;
            storeStateLabel.Text = "State:";
            // 
            // stoerCityLabel
            // 
            stoerCityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            stoerCityLabel.AutoSize = true;
            stoerCityLabel.Location = new System.Drawing.Point(3, 6);
            stoerCityLabel.Name = "stoerCityLabel";
            stoerCityLabel.Size = new System.Drawing.Size(27, 13);
            stoerCityLabel.TabIndex = 0;
            stoerCityLabel.Text = "City:";
            // 
            // storeAddressLabel
            // 
            storeAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            storeAddressLabel.AutoSize = true;
            storeAddressLabel.Location = new System.Drawing.Point(3, 58);
            storeAddressLabel.Name = "storeAddressLabel";
            storeAddressLabel.Size = new System.Drawing.Size(48, 13);
            storeAddressLabel.TabIndex = 4;
            storeAddressLabel.Text = "Address:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            storeIDLabel.AutoSize = true;
            storeIDLabel.Location = new System.Drawing.Point(3, 32);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(49, 13);
            storeIDLabel.TabIndex = 2;
            storeIDLabel.Text = "Store ID:";
            // 
            // storeNameLabel
            // 
            storeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            storeNameLabel.AutoSize = true;
            storeNameLabel.Location = new System.Drawing.Point(3, 6);
            storeNameLabel.Name = "storeNameLabel";
            storeNameLabel.Size = new System.Drawing.Size(66, 13);
            storeNameLabel.TabIndex = 0;
            storeNameLabel.Text = "Store Name:";
            // 
            // genreLabel
            // 
            genreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(3, 58);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 4;
            genreLabel.Text = "Genre:";
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(3, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            // 
            // titleIDLabel
            // 
            titleIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            titleIDLabel.AutoSize = true;
            titleIDLabel.Location = new System.Drawing.Point(3, 6);
            titleIDLabel.Name = "titleIDLabel";
            titleIDLabel.Size = new System.Drawing.Size(44, 13);
            titleIDLabel.TabIndex = 0;
            titleIDLabel.Text = "Title ID:";
            // 
            // datePublishedLabel
            // 
            datePublishedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            datePublishedLabel.AutoSize = true;
            datePublishedLabel.Location = new System.Drawing.Point(3, 6);
            datePublishedLabel.Name = "datePublishedLabel";
            datePublishedLabel.Size = new System.Drawing.Size(82, 13);
            datePublishedLabel.TabIndex = 0;
            datePublishedLabel.Text = "Date Published:";
            // 
            // pubsTabControl
            // 
            this.pubsTabControl.Controls.Add(this.authorsTab);
            this.pubsTabControl.Controls.Add(this.publishersTab);
            this.pubsTabControl.Controls.Add(this.storesTab);
            this.pubsTabControl.Controls.Add(this.titlesTab);
            this.pubsTabControl.Controls.Add(this.searchTab);
            this.pubsTabControl.Location = new System.Drawing.Point(12, 12);
            this.pubsTabControl.Name = "pubsTabControl";
            this.pubsTabControl.SelectedIndex = 0;
            this.pubsTabControl.Size = new System.Drawing.Size(646, 421);
            this.pubsTabControl.TabIndex = 0;
            // 
            // authorsTab
            // 
            this.authorsTab.Controls.Add(this.splitContainer1);
            this.authorsTab.Location = new System.Drawing.Point(4, 22);
            this.authorsTab.Name = "authorsTab";
            this.authorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.authorsTab.Size = new System.Drawing.Size(638, 395);
            this.authorsTab.TabIndex = 0;
            this.authorsTab.Text = "Authors";
            this.authorsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.authorInclude);
            this.splitContainer1.Panel1.Controls.Add(this.authorClear);
            this.splitContainer1.Panel1.Controls.Add(this.contractCheckbox);
            this.splitContainer1.Panel1.Controls.Add(this.deleteAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.addAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.authorSubmit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(632, 389);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // authorInclude
            // 
            this.authorInclude.AutoSize = true;
            this.authorInclude.Location = new System.Drawing.Point(520, 30);
            this.authorInclude.Name = "authorInclude";
            this.authorInclude.Size = new System.Drawing.Size(107, 17);
            this.authorInclude.TabIndex = 14;
            this.authorInclude.Text = "Include in search";
            this.authorInclude.UseVisualStyleBackColor = true;
            // 
            // authorClear
            // 
            this.authorClear.Location = new System.Drawing.Point(380, 142);
            this.authorClear.Name = "authorClear";
            this.authorClear.Size = new System.Drawing.Size(75, 23);
            this.authorClear.TabIndex = 13;
            this.authorClear.Text = "Clear";
            this.authorClear.UseVisualStyleBackColor = true;
            this.authorClear.Click += new System.EventHandler(this.authorClear_Click);
            // 
            // contractCheckbox
            // 
            this.contractCheckbox.AutoSize = true;
            this.contractCheckbox.Location = new System.Drawing.Point(520, 9);
            this.contractCheckbox.Name = "contractCheckbox";
            this.contractCheckbox.Size = new System.Drawing.Size(66, 17);
            this.contractCheckbox.TabIndex = 12;
            this.contractCheckbox.Text = "Contract";
            this.contractCheckbox.UseVisualStyleBackColor = true;
            // 
            // deleteAuthor
            // 
            this.deleteAuthor.Location = new System.Drawing.Point(165, 142);
            this.deleteAuthor.Name = "deleteAuthor";
            this.deleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.deleteAuthor.TabIndex = 11;
            this.deleteAuthor.Text = "Delete";
            this.deleteAuthor.UseVisualStyleBackColor = true;
            this.deleteAuthor.Click += new System.EventHandler(this.deleteAuthor_Click);
            // 
            // addAuthor
            // 
            this.addAuthor.Location = new System.Drawing.Point(84, 142);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(75, 23);
            this.addAuthor.TabIndex = 10;
            this.addAuthor.Text = "Add";
            this.addAuthor.UseVisualStyleBackColor = true;
            this.addAuthor.Click += new System.EventHandler(this.addAuthor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.authorZipLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(stateLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(authorCityLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(addressLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.authorZip, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.authorAddress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.authorCity, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.authorState, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(241, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(214, 106);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // authorZipLabel
            // 
            this.authorZipLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorZipLabel.AutoSize = true;
            this.authorZipLabel.Location = new System.Drawing.Point(3, 85);
            this.authorZipLabel.Name = "authorZipLabel";
            this.authorZipLabel.Size = new System.Drawing.Size(53, 13);
            this.authorZipLabel.TabIndex = 9;
            this.authorZipLabel.Text = "Zip Code:";
            // 
            // authorZip
            // 
            this.authorZip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorZip.Location = new System.Drawing.Point(62, 82);
            this.authorZip.Name = "authorZip";
            this.authorZip.Size = new System.Drawing.Size(100, 20);
            this.authorZip.TabIndex = 10;
            // 
            // authorAddress
            // 
            this.authorAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorAddress.Location = new System.Drawing.Point(62, 3);
            this.authorAddress.Name = "authorAddress";
            this.authorAddress.Size = new System.Drawing.Size(100, 20);
            this.authorAddress.TabIndex = 11;
            // 
            // authorCity
            // 
            this.authorCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorCity.Location = new System.Drawing.Point(62, 29);
            this.authorCity.Name = "authorCity";
            this.authorCity.Size = new System.Drawing.Size(100, 20);
            this.authorCity.TabIndex = 12;
            // 
            // authorState
            // 
            this.authorState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorState.Location = new System.Drawing.Point(62, 55);
            this.authorState.Name = "authorState";
            this.authorState.Size = new System.Drawing.Size(100, 20);
            this.authorState.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.phoneLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(au_lnameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(au_fnameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(au_idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorPhoneNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.authorID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.authorFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.authorLastName, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 106);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(3, 85);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // authorPhoneNumber
            // 
            this.authorPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorPhoneNumber.Location = new System.Drawing.Point(90, 82);
            this.authorPhoneNumber.Name = "authorPhoneNumber";
            this.authorPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.authorPhoneNumber.TabIndex = 10;
            // 
            // authorID
            // 
            this.authorID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorID.Location = new System.Drawing.Point(90, 3);
            this.authorID.Name = "authorID";
            this.authorID.Size = new System.Drawing.Size(100, 20);
            this.authorID.TabIndex = 11;
            // 
            // authorFirstName
            // 
            this.authorFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorFirstName.Location = new System.Drawing.Point(90, 29);
            this.authorFirstName.Name = "authorFirstName";
            this.authorFirstName.Size = new System.Drawing.Size(100, 20);
            this.authorFirstName.TabIndex = 12;
            // 
            // authorLastName
            // 
            this.authorLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorLastName.Location = new System.Drawing.Point(90, 55);
            this.authorLastName.Name = "authorLastName";
            this.authorLastName.Size = new System.Drawing.Size(100, 20);
            this.authorLastName.TabIndex = 13;
            // 
            // authorSubmit
            // 
            this.authorSubmit.Location = new System.Drawing.Point(3, 142);
            this.authorSubmit.Name = "authorSubmit";
            this.authorSubmit.Size = new System.Drawing.Size(75, 23);
            this.authorSubmit.TabIndex = 6;
            this.authorSubmit.Text = "Search";
            this.authorSubmit.UseVisualStyleBackColor = true;
            this.authorSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auidDataGridViewTextBoxColumn,
            this.aulnameDataGridViewTextBoxColumn,
            this.aufnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.contractDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.authorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(626, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // auidDataGridViewTextBoxColumn
            // 
            this.auidDataGridViewTextBoxColumn.DataPropertyName = "au_id";
            this.auidDataGridViewTextBoxColumn.HeaderText = "au_id";
            this.auidDataGridViewTextBoxColumn.Name = "auidDataGridViewTextBoxColumn";
            this.auidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aulnameDataGridViewTextBoxColumn
            // 
            this.aulnameDataGridViewTextBoxColumn.DataPropertyName = "au_lname";
            this.aulnameDataGridViewTextBoxColumn.HeaderText = "au_lname";
            this.aulnameDataGridViewTextBoxColumn.Name = "aulnameDataGridViewTextBoxColumn";
            this.aulnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aufnameDataGridViewTextBoxColumn
            // 
            this.aufnameDataGridViewTextBoxColumn.DataPropertyName = "au_fname";
            this.aufnameDataGridViewTextBoxColumn.HeaderText = "au_fname";
            this.aufnameDataGridViewTextBoxColumn.Name = "aufnameDataGridViewTextBoxColumn";
            this.aufnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractDataGridViewCheckBoxColumn
            // 
            this.contractDataGridViewCheckBoxColumn.DataPropertyName = "contract";
            this.contractDataGridViewCheckBoxColumn.HeaderText = "contract";
            this.contractDataGridViewCheckBoxColumn.Name = "contractDataGridViewCheckBoxColumn";
            this.contractDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.pubsDataSet;
            // 
            // pubsDataSet
            // 
            this.pubsDataSet.DataSetName = "pubsDataSet";
            this.pubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersTab
            // 
            this.publishersTab.Controls.Add(this.splitContainer2);
            this.publishersTab.Location = new System.Drawing.Point(4, 22);
            this.publishersTab.Name = "publishersTab";
            this.publishersTab.Padding = new System.Windows.Forms.Padding(3);
            this.publishersTab.Size = new System.Drawing.Size(638, 395);
            this.publishersTab.TabIndex = 1;
            this.publishersTab.Text = "Publishers";
            this.publishersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pubClear);
            this.splitContainer2.Panel1.Controls.Add(this.pubDelete);
            this.splitContainer2.Panel1.Controls.Add(this.pubAdd);
            this.splitContainer2.Panel1.Controls.Add(this.pubSubmit);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(632, 389);
            this.splitContainer2.SplitterDistance = 210;
            this.splitContainer2.TabIndex = 0;
            // 
            // pubClear
            // 
            this.pubClear.Location = new System.Drawing.Point(409, 117);
            this.pubClear.Name = "pubClear";
            this.pubClear.Size = new System.Drawing.Size(75, 23);
            this.pubClear.TabIndex = 14;
            this.pubClear.Text = "Clear";
            this.pubClear.UseVisualStyleBackColor = true;
            this.pubClear.Click += new System.EventHandler(this.pubClear_Click);
            // 
            // pubDelete
            // 
            this.pubDelete.Location = new System.Drawing.Point(281, 118);
            this.pubDelete.Name = "pubDelete";
            this.pubDelete.Size = new System.Drawing.Size(75, 23);
            this.pubDelete.TabIndex = 13;
            this.pubDelete.Text = "Delete";
            this.pubDelete.UseVisualStyleBackColor = true;
            this.pubDelete.Click += new System.EventHandler(this.pubDelete_Click);
            // 
            // pubAdd
            // 
            this.pubAdd.Location = new System.Drawing.Point(139, 118);
            this.pubAdd.Name = "pubAdd";
            this.pubAdd.Size = new System.Drawing.Size(75, 23);
            this.pubAdd.TabIndex = 12;
            this.pubAdd.Text = "Add";
            this.pubAdd.UseVisualStyleBackColor = true;
            this.pubAdd.Click += new System.EventHandler(this.pubAdd_Click);
            // 
            // pubSubmit
            // 
            this.pubSubmit.Location = new System.Drawing.Point(9, 118);
            this.pubSubmit.Name = "pubSubmit";
            this.pubSubmit.Size = new System.Drawing.Size(75, 23);
            this.pubSubmit.TabIndex = 11;
            this.pubSubmit.Text = "Submit";
            this.pubSubmit.UseVisualStyleBackColor = true;
            this.pubSubmit.Click += new System.EventHandler(this.pubSubmit_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(pubCountryLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(pubStateLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pubState, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pubCountry, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(214, 55);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // pubState
            // 
            this.pubState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pubState.Location = new System.Drawing.Point(55, 3);
            this.pubState.Name = "pubState";
            this.pubState.Size = new System.Drawing.Size(100, 20);
            this.pubState.TabIndex = 3;
            // 
            // pubCountry
            // 
            this.pubCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pubCountry.Location = new System.Drawing.Point(55, 30);
            this.pubCountry.Name = "pubCountry";
            this.pubCountry.Size = new System.Drawing.Size(100, 20);
            this.pubCountry.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(pubCityLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(pubIDLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(pubNameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pubName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pubID, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pubCity, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 78);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // pubName
            // 
            this.pubName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pubName.Location = new System.Drawing.Point(90, 3);
            this.pubName.Name = "pubName";
            this.pubName.Size = new System.Drawing.Size(100, 20);
            this.pubName.TabIndex = 5;
            // 
            // pubID
            // 
            this.pubID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pubID.Location = new System.Drawing.Point(90, 29);
            this.pubID.Name = "pubID";
            this.pubID.Size = new System.Drawing.Size(100, 20);
            this.pubID.TabIndex = 6;
            // 
            // pubCity
            // 
            this.pubCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pubCity.Location = new System.Drawing.Point(90, 55);
            this.pubCity.Name = "pubCity";
            this.pubCity.Size = new System.Drawing.Size(100, 20);
            this.pubCity.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pubidDataGridViewTextBoxColumn,
            this.pubnameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn1,
            this.stateDataGridViewTextBoxColumn1,
            this.countryDataGridViewTextBoxColumn,
            this.logo,
            this.pr_info});
            this.dataGridView2.DataSource = this.publisherinfoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 45;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(626, 169);
            this.dataGridView2.TabIndex = 0;
            // 
            // pubidDataGridViewTextBoxColumn
            // 
            this.pubidDataGridViewTextBoxColumn.DataPropertyName = "pub_id";
            this.pubidDataGridViewTextBoxColumn.HeaderText = "pub_id";
            this.pubidDataGridViewTextBoxColumn.Name = "pubidDataGridViewTextBoxColumn";
            // 
            // pubnameDataGridViewTextBoxColumn
            // 
            this.pubnameDataGridViewTextBoxColumn.DataPropertyName = "pub_name";
            this.pubnameDataGridViewTextBoxColumn.HeaderText = "pub_name";
            this.pubnameDataGridViewTextBoxColumn.Name = "pubnameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            this.stateDataGridViewTextBoxColumn1.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn1.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // logo
            // 
            this.logo.DataPropertyName = "logo";
            this.logo.HeaderText = "logo";
            this.logo.Name = "logo";
            // 
            // pr_info
            // 
            this.pr_info.DataPropertyName = "pr_info";
            this.pr_info.HeaderText = "pr_info";
            this.pr_info.Name = "pr_info";
            // 
            // publisherinfoBindingSource
            // 
            this.publisherinfoBindingSource.DataMember = "publisherinfo";
            this.publisherinfoBindingSource.DataSource = this.pubsDataSet;
            // 
            // storesTab
            // 
            this.storesTab.Controls.Add(this.splitContainer3);
            this.storesTab.Location = new System.Drawing.Point(4, 22);
            this.storesTab.Name = "storesTab";
            this.storesTab.Padding = new System.Windows.Forms.Padding(3);
            this.storesTab.Size = new System.Drawing.Size(638, 395);
            this.storesTab.TabIndex = 2;
            this.storesTab.Text = "Stores";
            this.storesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.storeClear);
            this.splitContainer3.Panel1.Controls.Add(this.storeDelete);
            this.splitContainer3.Panel1.Controls.Add(this.storeAdd);
            this.splitContainer3.Panel1.Controls.Add(this.storeSubmit);
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer3.Size = new System.Drawing.Size(632, 389);
            this.splitContainer3.SplitterDistance = 210;
            this.splitContainer3.TabIndex = 0;
            // 
            // storeClear
            // 
            this.storeClear.Location = new System.Drawing.Point(407, 106);
            this.storeClear.Name = "storeClear";
            this.storeClear.Size = new System.Drawing.Size(75, 23);
            this.storeClear.TabIndex = 16;
            this.storeClear.Text = "Clear";
            this.storeClear.UseVisualStyleBackColor = true;
            this.storeClear.Click += new System.EventHandler(this.storeClear_Click);
            // 
            // storeDelete
            // 
            this.storeDelete.Location = new System.Drawing.Point(289, 107);
            this.storeDelete.Name = "storeDelete";
            this.storeDelete.Size = new System.Drawing.Size(75, 23);
            this.storeDelete.TabIndex = 15;
            this.storeDelete.Text = "Delete";
            this.storeDelete.UseVisualStyleBackColor = true;
            this.storeDelete.Click += new System.EventHandler(this.storeDelete_Click);
            // 
            // storeAdd
            // 
            this.storeAdd.Location = new System.Drawing.Point(140, 107);
            this.storeAdd.Name = "storeAdd";
            this.storeAdd.Size = new System.Drawing.Size(75, 23);
            this.storeAdd.TabIndex = 14;
            this.storeAdd.Text = "Add";
            this.storeAdd.UseVisualStyleBackColor = true;
            this.storeAdd.Click += new System.EventHandler(this.storeAdd_Click);
            // 
            // storeSubmit
            // 
            this.storeSubmit.Location = new System.Drawing.Point(10, 108);
            this.storeSubmit.Name = "storeSubmit";
            this.storeSubmit.Size = new System.Drawing.Size(75, 23);
            this.storeSubmit.TabIndex = 13;
            this.storeSubmit.Text = "Submit";
            this.storeSubmit.UseVisualStyleBackColor = true;
            this.storeSubmit.Click += new System.EventHandler(this.storeSubmit_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(storeStateLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(stoerCityLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.storeCity, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.storeState, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.storeZipCode, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.storeZip, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(227, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(214, 78);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // storeCity
            // 
            this.storeCity.Location = new System.Drawing.Point(62, 3);
            this.storeCity.Name = "storeCity";
            this.storeCity.Size = new System.Drawing.Size(100, 20);
            this.storeCity.TabIndex = 3;
            // 
            // storeState
            // 
            this.storeState.Location = new System.Drawing.Point(62, 29);
            this.storeState.Name = "storeState";
            this.storeState.Size = new System.Drawing.Size(100, 20);
            this.storeState.TabIndex = 4;
            // 
            // storeZipCode
            // 
            this.storeZipCode.Location = new System.Drawing.Point(62, 55);
            this.storeZipCode.Name = "storeZipCode";
            this.storeZipCode.Size = new System.Drawing.Size(100, 20);
            this.storeZipCode.TabIndex = 5;
            // 
            // storeZip
            // 
            this.storeZip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.storeZip.AutoSize = true;
            this.storeZip.Location = new System.Drawing.Point(3, 58);
            this.storeZip.Name = "storeZip";
            this.storeZip.Size = new System.Drawing.Size(53, 13);
            this.storeZip.TabIndex = 6;
            this.storeZip.Text = "Zip Code:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(storeAddressLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(storeIDLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(storeNameLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.storeName, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.storeID, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.storeAddress, 1, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(214, 78);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // storeName
            // 
            this.storeName.Location = new System.Drawing.Point(75, 3);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(100, 20);
            this.storeName.TabIndex = 5;
            // 
            // storeID
            // 
            this.storeID.Location = new System.Drawing.Point(75, 29);
            this.storeID.Name = "storeID";
            this.storeID.Size = new System.Drawing.Size(100, 20);
            this.storeID.TabIndex = 6;
            // 
            // storeAddress
            // 
            this.storeAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.storeAddress.Location = new System.Drawing.Point(75, 55);
            this.storeAddress.Name = "storeAddress";
            this.storeAddress.Size = new System.Drawing.Size(100, 20);
            this.storeAddress.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storidDataGridViewTextBoxColumn,
            this.stornameDataGridViewTextBoxColumn,
            this.storaddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn2,
            this.stateDataGridViewTextBoxColumn2,
            this.zipDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.storesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(626, 168);
            this.dataGridView3.TabIndex = 0;
            // 
            // storidDataGridViewTextBoxColumn
            // 
            this.storidDataGridViewTextBoxColumn.DataPropertyName = "stor_id";
            this.storidDataGridViewTextBoxColumn.HeaderText = "stor_id";
            this.storidDataGridViewTextBoxColumn.Name = "storidDataGridViewTextBoxColumn";
            // 
            // stornameDataGridViewTextBoxColumn
            // 
            this.stornameDataGridViewTextBoxColumn.DataPropertyName = "stor_name";
            this.stornameDataGridViewTextBoxColumn.HeaderText = "stor_name";
            this.stornameDataGridViewTextBoxColumn.Name = "stornameDataGridViewTextBoxColumn";
            // 
            // storaddressDataGridViewTextBoxColumn
            // 
            this.storaddressDataGridViewTextBoxColumn.DataPropertyName = "stor_address";
            this.storaddressDataGridViewTextBoxColumn.HeaderText = "stor_address";
            this.storaddressDataGridViewTextBoxColumn.Name = "storaddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn2
            // 
            this.cityDataGridViewTextBoxColumn2.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn2.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn2.Name = "cityDataGridViewTextBoxColumn2";
            // 
            // stateDataGridViewTextBoxColumn2
            // 
            this.stateDataGridViewTextBoxColumn2.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn2.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn2.Name = "stateDataGridViewTextBoxColumn2";
            // 
            // zipDataGridViewTextBoxColumn1
            // 
            this.zipDataGridViewTextBoxColumn1.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn1.HeaderText = "zip";
            this.zipDataGridViewTextBoxColumn1.Name = "zipDataGridViewTextBoxColumn1";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "stores";
            this.storesBindingSource.DataSource = this.pubsDataSet;
            // 
            // titlesTab
            // 
            this.titlesTab.Controls.Add(this.splitContainer4);
            this.titlesTab.Location = new System.Drawing.Point(4, 22);
            this.titlesTab.Name = "titlesTab";
            this.titlesTab.Padding = new System.Windows.Forms.Padding(3);
            this.titlesTab.Size = new System.Drawing.Size(638, 395);
            this.titlesTab.TabIndex = 3;
            this.titlesTab.Text = "Titles";
            this.titlesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.titleView);
            this.splitContainer4.Panel1.Controls.Add(this.titleClear);
            this.splitContainer4.Panel1.Controls.Add(this.titleDelete);
            this.splitContainer4.Panel1.Controls.Add(this.titleAdd);
            this.splitContainer4.Panel1.Controls.Add(this.titleSubmit);
            this.splitContainer4.Panel1.Controls.Add(this.tableLayoutPanel7);
            this.splitContainer4.Panel1.Controls.Add(this.tableLayoutPanel8);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer4.Size = new System.Drawing.Size(632, 389);
            this.splitContainer4.SplitterDistance = 210;
            this.splitContainer4.TabIndex = 0;
            // 
            // titleView
            // 
            this.titleView.Location = new System.Drawing.Point(172, 140);
            this.titleView.Name = "titleView";
            this.titleView.Size = new System.Drawing.Size(75, 23);
            this.titleView.TabIndex = 19;
            this.titleView.Text = "View";
            this.titleView.UseVisualStyleBackColor = true;
            // 
            // titleClear
            // 
            this.titleClear.Location = new System.Drawing.Point(366, 140);
            this.titleClear.Name = "titleClear";
            this.titleClear.Size = new System.Drawing.Size(75, 23);
            this.titleClear.TabIndex = 18;
            this.titleClear.Text = "Clear";
            this.titleClear.UseVisualStyleBackColor = true;
            this.titleClear.Click += new System.EventHandler(this.titleClear_Click);
            // 
            // titleDelete
            // 
            this.titleDelete.Location = new System.Drawing.Point(253, 140);
            this.titleDelete.Name = "titleDelete";
            this.titleDelete.Size = new System.Drawing.Size(75, 23);
            this.titleDelete.TabIndex = 17;
            this.titleDelete.Text = "Delete";
            this.titleDelete.UseVisualStyleBackColor = true;
            this.titleDelete.Click += new System.EventHandler(this.titleDelete_Click);
            // 
            // titleAdd
            // 
            this.titleAdd.Location = new System.Drawing.Point(91, 140);
            this.titleAdd.Name = "titleAdd";
            this.titleAdd.Size = new System.Drawing.Size(75, 23);
            this.titleAdd.TabIndex = 16;
            this.titleAdd.Text = "Add";
            this.titleAdd.UseVisualStyleBackColor = true;
            this.titleAdd.Click += new System.EventHandler(this.titleAdd_Click);
            // 
            // titleSubmit
            // 
            this.titleSubmit.Location = new System.Drawing.Point(10, 140);
            this.titleSubmit.Name = "titleSubmit";
            this.titleSubmit.Size = new System.Drawing.Size(75, 23);
            this.titleSubmit.TabIndex = 15;
            this.titleSubmit.Text = "Submit";
            this.titleSubmit.UseVisualStyleBackColor = true;
            this.titleSubmit.Click += new System.EventHandler(this.titleSubmit_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(datePublishedLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.datePublished, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(227, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(214, 23);
            this.tableLayoutPanel7.TabIndex = 14;
            // 
            // datePublished
            // 
            this.datePublished.Location = new System.Drawing.Point(91, 3);
            this.datePublished.Name = "datePublished";
            this.datePublished.Size = new System.Drawing.Size(100, 20);
            this.datePublished.TabIndex = 10;
            this.datePublished.Text = "MM/DD/YY";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.titlePubIDLabel, 0, 3);
            this.tableLayoutPanel8.Controls.Add(genreLabel, 0, 2);
            this.tableLayoutPanel8.Controls.Add(titleLabel, 0, 1);
            this.tableLayoutPanel8.Controls.Add(titleIDLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.titleID, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.title, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.genre, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.titlePubID, 1, 3);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(214, 106);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // titlePubIDLabel
            // 
            this.titlePubIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titlePubIDLabel.AutoSize = true;
            this.titlePubIDLabel.Location = new System.Drawing.Point(3, 85);
            this.titlePubIDLabel.Name = "titlePubIDLabel";
            this.titlePubIDLabel.Size = new System.Drawing.Size(67, 13);
            this.titlePubIDLabel.TabIndex = 9;
            this.titlePubIDLabel.Text = "Publisher ID:";
            // 
            // titleID
            // 
            this.titleID.Location = new System.Drawing.Point(76, 3);
            this.titleID.Name = "titleID";
            this.titleID.Size = new System.Drawing.Size(100, 20);
            this.titleID.TabIndex = 10;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(76, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 11;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(76, 55);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 20);
            this.genre.TabIndex = 12;
            // 
            // titlePubID
            // 
            this.titlePubID.Location = new System.Drawing.Point(76, 81);
            this.titlePubID.Name = "titlePubID";
            this.titlePubID.Size = new System.Drawing.Size(100, 20);
            this.titlePubID.TabIndex = 13;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleidDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.pubidDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.advanceDataGridViewTextBoxColumn,
            this.royaltyDataGridViewTextBoxColumn,
            this.ytdsalesDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.pubdateDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.titlesBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(626, 168);
            this.dataGridView4.TabIndex = 0;
            // 
            // titleidDataGridViewTextBoxColumn
            // 
            this.titleidDataGridViewTextBoxColumn.DataPropertyName = "title_id";
            this.titleidDataGridViewTextBoxColumn.HeaderText = "title_id";
            this.titleidDataGridViewTextBoxColumn.Name = "titleidDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // pubidDataGridViewTextBoxColumn1
            // 
            this.pubidDataGridViewTextBoxColumn1.DataPropertyName = "pub_id";
            this.pubidDataGridViewTextBoxColumn1.HeaderText = "pub_id";
            this.pubidDataGridViewTextBoxColumn1.Name = "pubidDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // advanceDataGridViewTextBoxColumn
            // 
            this.advanceDataGridViewTextBoxColumn.DataPropertyName = "advance";
            this.advanceDataGridViewTextBoxColumn.HeaderText = "advance";
            this.advanceDataGridViewTextBoxColumn.Name = "advanceDataGridViewTextBoxColumn";
            // 
            // royaltyDataGridViewTextBoxColumn
            // 
            this.royaltyDataGridViewTextBoxColumn.DataPropertyName = "royalty";
            this.royaltyDataGridViewTextBoxColumn.HeaderText = "royalty";
            this.royaltyDataGridViewTextBoxColumn.Name = "royaltyDataGridViewTextBoxColumn";
            // 
            // ytdsalesDataGridViewTextBoxColumn
            // 
            this.ytdsalesDataGridViewTextBoxColumn.DataPropertyName = "ytd_sales";
            this.ytdsalesDataGridViewTextBoxColumn.HeaderText = "ytd_sales";
            this.ytdsalesDataGridViewTextBoxColumn.Name = "ytdsalesDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // pubdateDataGridViewTextBoxColumn
            // 
            this.pubdateDataGridViewTextBoxColumn.DataPropertyName = "pubdate";
            this.pubdateDataGridViewTextBoxColumn.HeaderText = "pubdate";
            this.pubdateDataGridViewTextBoxColumn.Name = "pubdateDataGridViewTextBoxColumn";
            // 
            // titlesBindingSource
            // 
            this.titlesBindingSource.DataMember = "titles";
            this.titlesBindingSource.DataSource = this.pubsDataSet;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.splitContainer5);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(638, 395);
            this.searchTab.TabIndex = 4;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer5.Size = new System.Drawing.Size(632, 389);
            this.splitContainer5.SplitterDistance = 210;
            this.splitContainer5.TabIndex = 0;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.discountsTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.publisherinfoTableAdapter = this.publisherinfoTableAdapter;
            this.tableAdapterManager.royschedTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.storesTableAdapter = null;
            this.tableAdapterManager.titleauthorTableAdapter = null;
            this.tableAdapterManager.TitleInfoTableAdapter = null;
            this.tableAdapterManager.titlesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PubsDatabase.pubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publisherinfoTableAdapter
            // 
            this.publisherinfoTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // titlesTableAdapter
            // 
            this.titlesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Double-click cell text to show titles by this author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 445);
            this.Controls.Add(this.pubsTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pubsTabControl.ResumeLayout(false);
            this.authorsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubsDataSet)).EndInit();
            this.publishersTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherinfoBindingSource)).EndInit();
            this.storesTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            this.titlesTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesBindingSource)).EndInit();
            this.searchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pubsTabControl;
        private System.Windows.Forms.TabPage authorsTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage publishersTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage storesTab;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabPage titlesTab;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private pubsDataSet pubsDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private pubsDataSetTableAdapters.authorsTableAdapter authorsTableAdapter;
        private pubsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private pubsDataSetTableAdapters.publisherinfoTableAdapter publisherinfoTableAdapter;
        private System.Windows.Forms.BindingSource publisherinfoBindingSource;
        private System.Windows.Forms.Button authorSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn auidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aufnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contractDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label authorZipLabel;
        private System.Windows.Forms.TextBox authorZip;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox authorPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox pubState;
        private System.Windows.Forms.TextBox pubCountry;
        private System.Windows.Forms.TextBox pubName;
        private System.Windows.Forms.TextBox pubID;
        private System.Windows.Forms.TextBox pubCity;
        private System.Windows.Forms.TextBox authorAddress;
        private System.Windows.Forms.TextBox authorCity;
        private System.Windows.Forms.TextBox authorState;
        private System.Windows.Forms.TextBox authorID;
        private System.Windows.Forms.TextBox authorFirstName;
        private System.Windows.Forms.TextBox authorLastName;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private pubsDataSetTableAdapters.storesTableAdapter storesTableAdapter;
        private System.Windows.Forms.Button pubSubmit;
        private System.Windows.Forms.Button storeSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox storeCity;
        private System.Windows.Forms.TextBox storeState;
        private System.Windows.Forms.TextBox storeZipCode;
        private System.Windows.Forms.Label storeZip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox storeName;
        private System.Windows.Forms.TextBox storeID;
        private System.Windows.Forms.TextBox storeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn storidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource titlesBindingSource;
        private pubsDataSetTableAdapters.titlesTableAdapter titlesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox datePublished;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label titlePubIDLabel;
        private System.Windows.Forms.TextBox titleID;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.TextBox titlePubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn royaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ytdsalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button titleSubmit;
        private System.Windows.Forms.Button addAuthor;
        private System.Windows.Forms.CheckBox contractCheckbox;
        private System.Windows.Forms.Button deleteAuthor;
        private System.Windows.Forms.Button pubDelete;
        private System.Windows.Forms.Button pubAdd;
        private System.Windows.Forms.Button storeDelete;
        private System.Windows.Forms.Button storeAdd;
        private System.Windows.Forms.Button titleDelete;
        private System.Windows.Forms.Button titleAdd;
        private System.Windows.Forms.Button authorClear;
        private System.Windows.Forms.Button pubClear;
        private System.Windows.Forms.Button storeClear;
        private System.Windows.Forms.Button titleClear;
        private System.Windows.Forms.CheckBox authorInclude;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_info;
        private System.Windows.Forms.Button titleView;
        private System.Windows.Forms.Label label1;
    }
}

