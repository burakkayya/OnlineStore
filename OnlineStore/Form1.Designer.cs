
namespace OopFinalProject2021
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label103;
            System.Windows.Forms.Label label95;
            System.Windows.Forms.Label label87;
            System.Windows.Forms.Label label75;
            System.Windows.Forms.Label label51;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label33;
            System.Windows.Forms.Label label43;
            System.Windows.Forms.Label label58;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label37;
            System.Windows.Forms.Label label50;
            System.Windows.Forms.Label label63;
            System.Windows.Forms.Label label74;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adlogin = new System.Windows.Forms.TextBox();
            this.sifrelogin = new System.Windows.Forms.TextBox();
            this.signad = new System.Windows.Forms.TextBox();
            this.signsifre = new System.Windows.Forms.TextBox();
            this.GirisDurumuLabel = new System.Windows.Forms.Label();
            this.tarihlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.isimtextbox = new System.Windows.Forms.TextBox();
            this.adrestextBox = new System.Windows.Forms.TextBox();
            this.customerlabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanıcıAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDBDataSet3 = new OopFinalProject2021.SqlDBDataSet3();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDBDataSet = new OopFinalProject2021.SqlDBDataSet();
            this.customersTableAdapter = new OopFinalProject2021.SqlDBDataSetTableAdapters.CustomersTableAdapter();
            this.sqlDBDataSet1 = new OopFinalProject2021.SqlDBDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new OopFinalProject2021.SqlDBDataSet1TableAdapters.CustomerTableAdapter();
            this.customersTableAdapter1 = new OopFinalProject2021.SqlDBDataSet3TableAdapters.CustomersTableAdapter();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDBDataSet4 = new OopFinalProject2021.SqlDBDataSet4();
            this.pRODUCTTableAdapter = new OopFinalProject2021.SqlDBDataSet4TableAdapters.PRODUCTTableAdapter();
            this.SignupBox = new System.Windows.Forms.GroupBox();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new OopFinalProject2021.DataSet1();
            this.booksTableAdapter = new OopFinalProject2021.DataSet1TableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new OopFinalProject2021.DataSet1TableAdapters.TableAdapterManager();
            this.sqlDBDataSet5 = new OopFinalProject2021.SqlDBDataSet5();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter1 = new OopFinalProject2021.SqlDBDataSet5TableAdapters.BooksTableAdapter();
            this.tableAdapterManager1 = new OopFinalProject2021.SqlDBDataSet5TableAdapters.TableAdapterManager();
            this.booksTableAdapter2 = new OopFinalProject2021.DataSet1TableAdapters.BooksTableAdapter();
            this.menupanel = new System.Windows.Forms.Panel();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.totallbl = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.cardInformation = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.paymentType = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label36 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.GroupBox();
            this.informationmail = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.informationaddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.informationname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CartPanel = new System.Windows.Forms.Panel();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button10 = new System.Windows.Forms.Button();
            this.MagazinePanel = new System.Windows.Forms.Panel();
            this.magazinegroupBox6 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.magazinenamelbl6 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.magazinepricelabel6 = new System.Windows.Forms.Label();
            this.typlelabel6 = new System.Windows.Forms.Label();
            this.issuelabel6 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.magazinegroupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.magazinenamelbl5 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.magazinepricelabel5 = new System.Windows.Forms.Label();
            this.typlelabel5 = new System.Windows.Forms.Label();
            this.issuelabel5 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.magazinegroupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.magazinenamelbl4 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.magazinepricelabel4 = new System.Windows.Forms.Label();
            this.typlelabel4 = new System.Windows.Forms.Label();
            this.issuelabel4 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.magazinegroupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.magazinenamelbl3 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.magazinepricelabel3 = new System.Windows.Forms.Label();
            this.typlelabel3 = new System.Windows.Forms.Label();
            this.issuelabel3 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.magazinegroupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.magazinenamelbl2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.magazinepricelabel2 = new System.Windows.Forms.Label();
            this.typlelabel2 = new System.Windows.Forms.Label();
            this.issuelabel2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.magazinegroupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonnn4 = new System.Windows.Forms.Button();
            this.magazinenamelbl1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.magazinepricelabel1 = new System.Windows.Forms.Label();
            this.typlelabel1 = new System.Windows.Forms.Label();
            this.issuelabel1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.bookgroupbox6 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.namelbl6 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pagelbl6 = new System.Windows.Forms.Label();
            this.publisherlbl6 = new System.Windows.Forms.Label();
            this.pricelbl6 = new System.Windows.Forms.Label();
            this.authorlbl6 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.MusicCDbutton = new System.Windows.Forms.Button();
            this.bookgroupbox5 = new System.Windows.Forms.GroupBox();
            this.button20 = new System.Windows.Forms.Button();
            this.namelbl5 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pagelbl5 = new System.Windows.Forms.Label();
            this.publisherlbl5 = new System.Windows.Forms.Label();
            this.pricelbl5 = new System.Windows.Forms.Label();
            this.authorlbl5 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.BooksButton = new System.Windows.Forms.Button();
            this.bookgroupbox4 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.namelbl4 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pagelbl4 = new System.Windows.Forms.Label();
            this.publisherlbl4 = new System.Windows.Forms.Label();
            this.pricelbl4 = new System.Windows.Forms.Label();
            this.authorlbl4 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.MagazineButton = new System.Windows.Forms.Button();
            this.bookgroupbox3 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.namelbl3 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pagelbl3 = new System.Windows.Forms.Label();
            this.publisherlbl3 = new System.Windows.Forms.Label();
            this.pricelbl3 = new System.Windows.Forms.Label();
            this.authorlbl3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.MusicCdPanel = new System.Windows.Forms.Panel();
            this.musicgroupbox6 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.musicname6 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.musicprice6 = new System.Windows.Forms.Label();
            this.singletype6 = new System.Windows.Forms.Label();
            this.Singerlabel6 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.musicgroupbox5 = new System.Windows.Forms.GroupBox();
            this.button14 = new System.Windows.Forms.Button();
            this.musicname5 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.musicprice5 = new System.Windows.Forms.Label();
            this.singletype5 = new System.Windows.Forms.Label();
            this.Singerlabel5 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.musicgroupbox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.musicname4 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.musicprice4 = new System.Windows.Forms.Label();
            this.singletype4 = new System.Windows.Forms.Label();
            this.Singerlabel4 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.musicgroupboxx3 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.musicname3 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.musicprice3 = new System.Windows.Forms.Label();
            this.singletype3 = new System.Windows.Forms.Label();
            this.Singerlabel3 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.musicgroupbox2 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.musicname2 = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.musicprice2 = new System.Windows.Forms.Label();
            this.singletype2 = new System.Windows.Forms.Label();
            this.Singerlabel2 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.musicgroupbox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.musicname1 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.musicprice1 = new System.Windows.Forms.Label();
            this.singletype1 = new System.Windows.Forms.Label();
            this.Singerlabel1 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.bookgroupbox2 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.namelbl2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pagelbl2 = new System.Windows.Forms.Label();
            this.publisherlabel2 = new System.Windows.Forms.Label();
            this.pricelbl2 = new System.Windows.Forms.Label();
            this.authorlbl2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bookgroupbox1 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.namelbl1 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pagelbl1 = new System.Windows.Forms.Label();
            this.publisherlbl1 = new System.Windows.Forms.Label();
            this.pricelbl1 = new System.Windows.Forms.Label();
            this.authorlbl1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.onaybuton = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label103 = new System.Windows.Forms.Label();
            label95 = new System.Windows.Forms.Label();
            label87 = new System.Windows.Forms.Label();
            label75 = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
            label43 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            label50 = new System.Windows.Forms.Label();
            label63 = new System.Windows.Forms.Label();
            label74 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet4)).BeginInit();
            this.SignupBox.SuspendLayout();
            this.LoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.menupanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.cardInformation.SuspendLayout();
            this.paymentType.SuspendLayout();
            this.Information.SuspendLayout();
            this.CartPanel.SuspendLayout();
            this.MagazinePanel.SuspendLayout();
            this.magazinegroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.magazinegroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.magazinegroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.magazinegroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.magazinegroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.magazinegroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.bookgroupbox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.bookgroupbox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.bookgroupbox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.bookgroupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.MusicCdPanel.SuspendLayout();
            this.musicgroupbox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.musicgroupbox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.musicgroupbox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.musicgroupboxx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.musicgroupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.musicgroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.bookgroupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bookgroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(102, 176);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(107, 173);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(49, 17);
            label13.TabIndex = 24;
            label13.Text = "Name:";
            // 
            // label103
            // 
            label103.AutoSize = true;
            label103.Location = new System.Drawing.Point(102, 176);
            label103.Name = "label103";
            label103.Size = new System.Drawing.Size(49, 17);
            label103.TabIndex = 24;
            label103.Text = "Name:";
            // 
            // label95
            // 
            label95.AutoSize = true;
            label95.Location = new System.Drawing.Point(102, 176);
            label95.Name = "label95";
            label95.Size = new System.Drawing.Size(49, 17);
            label95.TabIndex = 24;
            label95.Text = "Name:";
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Location = new System.Drawing.Point(102, 176);
            label87.Name = "label87";
            label87.Size = new System.Drawing.Size(49, 17);
            label87.TabIndex = 24;
            label87.Text = "Name:";
            // 
            // label75
            // 
            label75.AutoSize = true;
            label75.Location = new System.Drawing.Point(102, 176);
            label75.Name = "label75";
            label75.Size = new System.Drawing.Size(49, 17);
            label75.TabIndex = 24;
            label75.Text = "Name:";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new System.Drawing.Point(102, 176);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(49, 17);
            label51.TabIndex = 24;
            label51.Text = "Name:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(102, 176);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(49, 17);
            label17.TabIndex = 24;
            label17.Text = "Name:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(107, 176);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(49, 17);
            label23.TabIndex = 24;
            label23.Text = "Name:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(103, 183);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(49, 17);
            label33.TabIndex = 24;
            label33.Text = "Name:";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new System.Drawing.Point(109, 183);
            label43.Name = "label43";
            label43.Size = new System.Drawing.Size(49, 17);
            label43.TabIndex = 24;
            label43.Text = "Name:";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new System.Drawing.Point(113, 183);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(49, 17);
            label58.TabIndex = 24;
            label58.Text = "Name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(102, 176);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(49, 17);
            label15.TabIndex = 24;
            label15.Text = "Name:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(102, 176);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(49, 17);
            label16.TabIndex = 24;
            label16.Text = "Name:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new System.Drawing.Point(102, 176);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(49, 17);
            label37.TabIndex = 24;
            label37.Text = "Name:";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new System.Drawing.Point(102, 189);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(49, 17);
            label50.TabIndex = 24;
            label50.Text = "Name:";
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Location = new System.Drawing.Point(102, 190);
            label63.Name = "label63";
            label63.Size = new System.Drawing.Size(49, 17);
            label63.TabIndex = 24;
            label63.Text = "Name:";
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new System.Drawing.Point(102, 191);
            label74.Name = "label74";
            label74.Size = new System.Drawing.Size(49, 17);
            label74.TabIndex = 24;
            label74.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(205, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(209, 126);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Şifre";
            // 
            // adlogin
            // 
            this.adlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.adlogin.Location = new System.Drawing.Point(170, 22);
            this.adlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adlogin.Name = "adlogin";
            this.adlogin.Size = new System.Drawing.Size(233, 36);
            this.adlogin.TabIndex = 8;
            this.adlogin.TextChanged += new System.EventHandler(this.adlogin_TextChanged);
            // 
            // sifrelogin
            // 
            this.sifrelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sifrelogin.Location = new System.Drawing.Point(170, 71);
            this.sifrelogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifrelogin.Name = "sifrelogin";
            this.sifrelogin.Size = new System.Drawing.Size(233, 36);
            this.sifrelogin.TabIndex = 9;
            // 
            // signad
            // 
            this.signad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.signad.Location = new System.Drawing.Point(170, 31);
            this.signad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signad.Name = "signad";
            this.signad.Size = new System.Drawing.Size(233, 36);
            this.signad.TabIndex = 10;
            // 
            // signsifre
            // 
            this.signsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.signsifre.Location = new System.Drawing.Point(170, 85);
            this.signsifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signsifre.Name = "signsifre";
            this.signsifre.Size = new System.Drawing.Size(233, 36);
            this.signsifre.TabIndex = 11;
            // 
            // GirisDurumuLabel
            // 
            this.GirisDurumuLabel.AutoSize = true;
            this.GirisDurumuLabel.Location = new System.Drawing.Point(25, 59);
            this.GirisDurumuLabel.Name = "GirisDurumuLabel";
            this.GirisDurumuLabel.Size = new System.Drawing.Size(0, 17);
            this.GirisDurumuLabel.TabIndex = 12;
            // 
            // tarihlabel
            // 
            this.tarihlabel.AutoSize = true;
            this.tarihlabel.Font = new System.Drawing.Font("a song for jennifer", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihlabel.ForeColor = System.Drawing.Color.Black;
            this.tarihlabel.Location = new System.Drawing.Point(76, 204);
            this.tarihlabel.Name = "tarihlabel";
            this.tarihlabel.Size = new System.Drawing.Size(62, 25);
            this.tarihlabel.TabIndex = 13;
            this.tarihlabel.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "İsim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("a song for jennifer", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Adres";
            // 
            // emailtextbox
            // 
            this.emailtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailtextbox.Location = new System.Drawing.Point(170, 143);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(233, 36);
            this.emailtextbox.TabIndex = 17;
            // 
            // isimtextbox
            // 
            this.isimtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.isimtextbox.Location = new System.Drawing.Point(170, 203);
            this.isimtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isimtextbox.Name = "isimtextbox";
            this.isimtextbox.Size = new System.Drawing.Size(233, 36);
            this.isimtextbox.TabIndex = 18;
            // 
            // adrestextBox
            // 
            this.adrestextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.adrestextBox.Location = new System.Drawing.Point(170, 262);
            this.adrestextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adrestextBox.Name = "adrestextBox";
            this.adrestextBox.Size = new System.Drawing.Size(233, 36);
            this.adrestextBox.TabIndex = 19;
            // 
            // customerlabel
            // 
            this.customerlabel.AutoSize = true;
            this.customerlabel.Location = new System.Drawing.Point(39, 409);
            this.customerlabel.Name = "customerlabel";
            this.customerlabel.Size = new System.Drawing.Size(0, 17);
            this.customerlabel.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(227, 391);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 33);
            this.button4.TabIndex = 26;
            this.button4.Text = "Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanıcıAdıDataGridViewTextBoxColumn,
            this.şifreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.CustomerID});
            this.dataGridView1.DataSource = this.customersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 428);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 218);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kullanıcıAdıDataGridViewTextBoxColumn
            // 
            this.kullanıcıAdıDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.HeaderText = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıAdıDataGridViewTextBoxColumn.Name = "kullanıcıAdıDataGridViewTextBoxColumn";
            this.kullanıcıAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // şifreDataGridViewTextBoxColumn
            // 
            this.şifreDataGridViewTextBoxColumn.DataPropertyName = "Şifre";
            this.şifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.şifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.şifreDataGridViewTextBoxColumn.Name = "şifreDataGridViewTextBoxColumn";
            this.şifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "İsim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 125;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.sqlDBDataSet3;
            // 
            // sqlDBDataSet3
            // 
            this.sqlDBDataSet3.DataSetName = "SqlDBDataSet3";
            this.sqlDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.sqlDBDataSet;
            // 
            // sqlDBDataSet
            // 
            this.sqlDBDataSet.DataSetName = "SqlDBDataSet";
            this.sqlDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // sqlDBDataSet1
            // 
            this.sqlDBDataSet1.DataSetName = "SqlDBDataSet1";
            this.sqlDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.sqlDBDataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.sqlDBDataSet4;
            // 
            // sqlDBDataSet4
            // 
            this.sqlDBDataSet4.DataSetName = "SqlDBDataSet4";
            this.sqlDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // SignupBox
            // 
            this.SignupBox.Controls.Add(this.button1);
            this.SignupBox.Controls.Add(this.GirisDurumuLabel);
            this.SignupBox.Controls.Add(this.adrestextBox);
            this.SignupBox.Controls.Add(this.isimtextbox);
            this.SignupBox.Controls.Add(this.emailtextbox);
            this.SignupBox.Controls.Add(this.signsifre);
            this.SignupBox.Controls.Add(this.signad);
            this.SignupBox.Controls.Add(this.label9);
            this.SignupBox.Controls.Add(this.label8);
            this.SignupBox.Controls.Add(this.label7);
            this.SignupBox.Controls.Add(this.label6);
            this.SignupBox.Controls.Add(this.label5);
            this.SignupBox.Location = new System.Drawing.Point(461, 67);
            this.SignupBox.Name = "SignupBox";
            this.SignupBox.Size = new System.Drawing.Size(702, 427);
            this.SignupBox.TabIndex = 29;
            this.SignupBox.TabStop = false;
            this.SignupBox.Text = "Sign Up";
            this.SignupBox.Visible = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.linkLabel1);
            this.LoginBox.Controls.Add(this.tarihlabel);
            this.LoginBox.Controls.Add(this.sifrelogin);
            this.LoginBox.Controls.Add(this.adlogin);
            this.LoginBox.Controls.Add(this.label1);
            this.LoginBox.Controls.Add(this.button2);
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginBox.Location = new System.Drawing.Point(467, 55);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(702, 297);
            this.LoginBox.TabIndex = 30;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(151, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(276, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Are you a new user? Creat account.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.UpdateOrder = OopFinalProject2021.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sqlDBDataSet5
            // 
            this.sqlDBDataSet5.DataSetName = "SqlDBDataSet5";
            this.sqlDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.sqlDBDataSet5;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BooksTableAdapter = this.booksTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = OopFinalProject2021.SqlDBDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksTableAdapter2
            // 
            this.booksTableAdapter2.ClearBeforeFill = true;
            // 
            // menupanel
            // 
            this.menupanel.AutoScroll = true;
            this.menupanel.BackColor = System.Drawing.SystemColors.Info;
            this.menupanel.Controls.Add(this.OrderPanel);
            this.menupanel.Controls.Add(this.CartPanel);
            this.menupanel.Controls.Add(this.button10);
            this.menupanel.Controls.Add(this.MagazinePanel);
            this.menupanel.Controls.Add(this.bookgroupbox6);
            this.menupanel.Controls.Add(this.MusicCDbutton);
            this.menupanel.Controls.Add(this.bookgroupbox5);
            this.menupanel.Controls.Add(this.BooksButton);
            this.menupanel.Controls.Add(this.bookgroupbox4);
            this.menupanel.Controls.Add(this.MagazineButton);
            this.menupanel.Controls.Add(this.bookgroupbox3);
            this.menupanel.Controls.Add(this.MusicCdPanel);
            this.menupanel.Controls.Add(this.bookgroupbox2);
            this.menupanel.Controls.Add(this.bookgroupbox1);
            this.menupanel.Location = new System.Drawing.Point(6, 2);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(1389, 895);
            this.menupanel.TabIndex = 7;
            this.menupanel.Visible = false;
            this.menupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.publisherlbl2_Paint);
            // 
            // OrderPanel
            // 
            this.OrderPanel.AutoScroll = true;
            this.OrderPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.OrderPanel.Controls.Add(this.onaybuton);
            this.OrderPanel.Controls.Add(this.totallbl);
            this.OrderPanel.Controls.Add(this.total);
            this.OrderPanel.Controls.Add(this.cardInformation);
            this.OrderPanel.Controls.Add(this.paymentType);
            this.OrderPanel.Controls.Add(this.Information);
            this.OrderPanel.Location = new System.Drawing.Point(179, 39);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(1125, 756);
            this.OrderPanel.TabIndex = 30;
            this.OrderPanel.Visible = false;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totallbl.ForeColor = System.Drawing.Color.Black;
            this.totallbl.Location = new System.Drawing.Point(634, 394);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(19, 23);
            this.totallbl.TabIndex = 10;
            this.totallbl.Text = "0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.Location = new System.Drawing.Point(509, 394);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(112, 23);
            this.total.TabIndex = 9;
            this.total.Text = "Total Amount";
            // 
            // cardInformation
            // 
            this.cardInformation.Controls.Add(this.textBox8);
            this.cardInformation.Controls.Add(this.label73);
            this.cardInformation.Controls.Add(this.textBox7);
            this.cardInformation.Controls.Add(this.label62);
            this.cardInformation.Controls.Add(this.textBox6);
            this.cardInformation.Controls.Add(this.label53);
            this.cardInformation.Controls.Add(this.textBox5);
            this.cardInformation.Controls.Add(this.label52);
            this.cardInformation.Controls.Add(this.textBox4);
            this.cardInformation.Controls.Add(this.label49);
            this.cardInformation.Location = new System.Drawing.Point(506, 43);
            this.cardInformation.Name = "cardInformation";
            this.cardInformation.Size = new System.Drawing.Size(415, 285);
            this.cardInformation.TabIndex = 2;
            this.cardInformation.TabStop = false;
            this.cardInformation.Text = "Card Information";
            this.cardInformation.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox8.Location = new System.Drawing.Point(125, 162);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(278, 26);
            this.textBox8.TabIndex = 17;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.ForeColor = System.Drawing.Color.Black;
            this.label73.Location = new System.Drawing.Point(13, 168);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(101, 23);
            this.label73.TabIndex = 16;
            this.label73.Text = "Card Owner";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox7.Location = new System.Drawing.Point(125, 119);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 26);
            this.textBox7.TabIndex = 15;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label62.ForeColor = System.Drawing.Color.Black;
            this.label62.Location = new System.Drawing.Point(16, 125);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 23);
            this.label62.TabIndex = 14;
            this.label62.Text = "CVV";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox6.Location = new System.Drawing.Point(190, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 26);
            this.textBox6.TabIndex = 13;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(170, 81);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(14, 20);
            this.label53.TabIndex = 12;
            this.label53.Text = "/";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox5.Location = new System.Drawing.Point(125, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 26);
            this.textBox5.TabIndex = 11;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(12, 81);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(117, 23);
            this.label52.TabIndex = 10;
            this.label52.Text = "Exprition Date";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(125, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 26);
            this.textBox4.TabIndex = 6;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(10, 35);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(110, 23);
            this.label49.TabIndex = 9;
            this.label49.Text = "Card Number";
            // 
            // paymentType
            // 
            this.paymentType.Controls.Add(this.radioButton2);
            this.paymentType.Controls.Add(this.radioButton1);
            this.paymentType.Controls.Add(this.label36);
            this.paymentType.Location = new System.Drawing.Point(44, 360);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(428, 100);
            this.paymentType.TabIndex = 1;
            this.paymentType.TabStop = false;
            this.paymentType.Text = "PaymentType";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(236, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cash";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(52, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Credit Card";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(154, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 20);
            this.label36.TabIndex = 6;
            this.label36.Text = "Choose one";
            // 
            // Information
            // 
            this.Information.Controls.Add(this.informationmail);
            this.Information.Controls.Add(this.label22);
            this.Information.Controls.Add(this.informationaddress);
            this.Information.Controls.Add(this.label18);
            this.Information.Controls.Add(this.informationname);
            this.Information.Controls.Add(this.label4);
            this.Information.Location = new System.Drawing.Point(44, 43);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(428, 285);
            this.Information.TabIndex = 0;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // informationmail
            // 
            this.informationmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.informationmail.Location = new System.Drawing.Point(82, 242);
            this.informationmail.Name = "informationmail";
            this.informationmail.Size = new System.Drawing.Size(223, 26);
            this.informationmail.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(23, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 23);
            this.label22.TabIndex = 4;
            this.label22.Text = "Mail";
            // 
            // informationaddress
            // 
            this.informationaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.informationaddress.Location = new System.Drawing.Point(82, 119);
            this.informationaddress.Multiline = true;
            this.informationaddress.Name = "informationaddress";
            this.informationaddress.Size = new System.Drawing.Size(223, 110);
            this.informationaddress.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(23, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 23);
            this.label18.TabIndex = 2;
            this.label18.Text = "Address";
            // 
            // informationname
            // 
            this.informationname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.informationname.Location = new System.Drawing.Point(82, 48);
            this.informationname.Name = "informationname";
            this.informationname.Size = new System.Drawing.Size(223, 26);
            this.informationname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("a song for jennifer", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // CartPanel
            // 
            this.CartPanel.AutoScroll = true;
            this.CartPanel.BackColor = System.Drawing.Color.Silver;
            this.CartPanel.Controls.Add(this.PlaceOrder);
            this.CartPanel.Controls.Add(this.CancelButton);
            this.CartPanel.Controls.Add(this.RemoveButton);
            this.CartPanel.Controls.Add(this.listView1);
            this.CartPanel.Location = new System.Drawing.Point(194, 34);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(1135, 756);
            this.CartPanel.TabIndex = 29;
            this.CartPanel.Visible = false;
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.PlaceOrder.ForeColor = System.Drawing.Color.Gold;
            this.PlaceOrder.Location = new System.Drawing.Point(485, 369);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(191, 78);
            this.PlaceOrder.TabIndex = 4;
            this.PlaceOrder.Text = "Place Order";
            this.PlaceOrder.UseVisualStyleBackColor = false;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelButton.ForeColor = System.Drawing.Color.Gold;
            this.CancelButton.Location = new System.Drawing.Point(708, 369);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(191, 78);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.RemoveButton.ForeColor = System.Drawing.Color.Gold;
            this.RemoveButton.Location = new System.Drawing.Point(251, 369);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(191, 78);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Select Product To Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(252, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 284);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.MidnightBlue;
            this.button10.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 411);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(173, 88);
            this.button10.TabIndex = 30;
            this.button10.Text = "My Cart";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MagazinePanel
            // 
            this.MagazinePanel.AutoScroll = true;
            this.MagazinePanel.Controls.Add(this.magazinegroupBox6);
            this.MagazinePanel.Controls.Add(this.magazinegroupBox5);
            this.MagazinePanel.Controls.Add(this.magazinegroupBox4);
            this.MagazinePanel.Controls.Add(this.magazinegroupBox3);
            this.MagazinePanel.Controls.Add(this.magazinegroupBox2);
            this.MagazinePanel.Controls.Add(this.magazinegroupBox1);
            this.MagazinePanel.Location = new System.Drawing.Point(200, 26);
            this.MagazinePanel.Name = "MagazinePanel";
            this.MagazinePanel.Size = new System.Drawing.Size(1132, 756);
            this.MagazinePanel.TabIndex = 27;
            this.MagazinePanel.Visible = false;
            // 
            // magazinegroupBox6
            // 
            this.magazinegroupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magazinegroupBox6.Controls.Add(this.button9);
            this.magazinegroupBox6.Controls.Add(this.magazinenamelbl6);
            this.magazinegroupBox6.Controls.Add(label74);
            this.magazinegroupBox6.Controls.Add(this.pictureBox12);
            this.magazinegroupBox6.Controls.Add(this.magazinepricelabel6);
            this.magazinegroupBox6.Controls.Add(this.typlelabel6);
            this.magazinegroupBox6.Controls.Add(this.issuelabel6);
            this.magazinegroupBox6.Controls.Add(this.label78);
            this.magazinegroupBox6.Controls.Add(this.label79);
            this.magazinegroupBox6.Controls.Add(this.label80);
            this.magazinegroupBox6.Location = new System.Drawing.Point(754, 380);
            this.magazinegroupBox6.Name = "magazinegroupBox6";
            this.magazinegroupBox6.Size = new System.Drawing.Size(329, 337);
            this.magazinegroupBox6.TabIndex = 28;
            this.magazinegroupBox6.TabStop = false;
            this.magazinegroupBox6.Visible = false;
            this.magazinegroupBox6.Enter += new System.EventHandler(this.magazinegroupBox6_Enter);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(87, 302);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(151, 29);
            this.button9.TabIndex = 32;
            this.button9.Text = "Sepete Ekle";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // magazinenamelbl6
            // 
            this.magazinenamelbl6.AutoSize = true;
            this.magazinenamelbl6.Location = new System.Drawing.Point(165, 192);
            this.magazinenamelbl6.Name = "magazinenamelbl6";
            this.magazinenamelbl6.Size = new System.Drawing.Size(45, 17);
            this.magazinenamelbl6.TabIndex = 26;
            this.magazinenamelbl6.Text = "Name";
            // 
            // pictureBox12
            // 
            this.pictureBox12.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox12.Image = global::OopFinalProject2021.Properties.Resources.VOGUECOLOR;
            this.pictureBox12.Location = new System.Drawing.Point(94, 7);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(121, 166);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // magazinepricelabel6
            // 
            this.magazinepricelabel6.AutoSize = true;
            this.magazinepricelabel6.Location = new System.Drawing.Point(167, 281);
            this.magazinepricelabel6.Name = "magazinepricelabel6";
            this.magazinepricelabel6.Size = new System.Drawing.Size(45, 17);
            this.magazinepricelabel6.TabIndex = 16;
            this.magazinepricelabel6.Text = "Name";
            // 
            // typlelabel6
            // 
            this.typlelabel6.AutoSize = true;
            this.typlelabel6.Location = new System.Drawing.Point(167, 248);
            this.typlelabel6.Name = "typlelabel6";
            this.typlelabel6.Size = new System.Drawing.Size(45, 17);
            this.typlelabel6.TabIndex = 15;
            this.typlelabel6.Text = "Name";
            // 
            // issuelabel6
            // 
            this.issuelabel6.AutoSize = true;
            this.issuelabel6.Location = new System.Drawing.Point(165, 219);
            this.issuelabel6.Name = "issuelabel6";
            this.issuelabel6.Size = new System.Drawing.Size(45, 17);
            this.issuelabel6.TabIndex = 14;
            this.issuelabel6.Text = "Name";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(102, 281);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(44, 17);
            this.label78.TabIndex = 12;
            this.label78.Text = "Price:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(102, 252);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(44, 17);
            this.label79.TabIndex = 11;
            this.label79.Text = "Type:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(102, 221);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(45, 17);
            this.label80.TabIndex = 10;
            this.label80.Text = "Issue:";
            // 
            // magazinegroupBox5
            // 
            this.magazinegroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magazinegroupBox5.Controls.Add(this.button8);
            this.magazinegroupBox5.Controls.Add(this.magazinenamelbl5);
            this.magazinegroupBox5.Controls.Add(label63);
            this.magazinegroupBox5.Controls.Add(this.pictureBox11);
            this.magazinegroupBox5.Controls.Add(this.magazinepricelabel5);
            this.magazinegroupBox5.Controls.Add(this.typlelabel5);
            this.magazinegroupBox5.Controls.Add(this.issuelabel5);
            this.magazinegroupBox5.Controls.Add(this.label70);
            this.magazinegroupBox5.Controls.Add(this.label71);
            this.magazinegroupBox5.Controls.Add(this.label72);
            this.magazinegroupBox5.Location = new System.Drawing.Point(394, 380);
            this.magazinegroupBox5.Name = "magazinegroupBox5";
            this.magazinegroupBox5.Size = new System.Drawing.Size(329, 337);
            this.magazinegroupBox5.TabIndex = 28;
            this.magazinegroupBox5.TabStop = false;
            this.magazinegroupBox5.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(78, 302);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(151, 29);
            this.button8.TabIndex = 31;
            this.button8.Text = "Sepete Ekle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // magazinenamelbl5
            // 
            this.magazinenamelbl5.AutoSize = true;
            this.magazinenamelbl5.Location = new System.Drawing.Point(165, 191);
            this.magazinenamelbl5.Name = "magazinenamelbl5";
            this.magazinenamelbl5.Size = new System.Drawing.Size(45, 17);
            this.magazinenamelbl5.TabIndex = 26;
            this.magazinenamelbl5.Text = "Name";
            // 
            // pictureBox11
            // 
            this.pictureBox11.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox11.Image = global::OopFinalProject2021.Properties.Resources.AAASmAGAZİNE;
            this.pictureBox11.Location = new System.Drawing.Point(94, 7);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(121, 166);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 21;
            this.pictureBox11.TabStop = false;
            // 
            // magazinepricelabel5
            // 
            this.magazinepricelabel5.AutoSize = true;
            this.magazinepricelabel5.Location = new System.Drawing.Point(167, 280);
            this.magazinepricelabel5.Name = "magazinepricelabel5";
            this.magazinepricelabel5.Size = new System.Drawing.Size(45, 17);
            this.magazinepricelabel5.TabIndex = 16;
            this.magazinepricelabel5.Text = "Name";
            // 
            // typlelabel5
            // 
            this.typlelabel5.AutoSize = true;
            this.typlelabel5.Location = new System.Drawing.Point(167, 247);
            this.typlelabel5.Name = "typlelabel5";
            this.typlelabel5.Size = new System.Drawing.Size(45, 17);
            this.typlelabel5.TabIndex = 15;
            this.typlelabel5.Text = "Name";
            // 
            // issuelabel5
            // 
            this.issuelabel5.AutoSize = true;
            this.issuelabel5.Location = new System.Drawing.Point(165, 218);
            this.issuelabel5.Name = "issuelabel5";
            this.issuelabel5.Size = new System.Drawing.Size(45, 17);
            this.issuelabel5.TabIndex = 14;
            this.issuelabel5.Text = "Name";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(102, 280);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(44, 17);
            this.label70.TabIndex = 12;
            this.label70.Text = "Price:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(102, 251);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(44, 17);
            this.label71.TabIndex = 11;
            this.label71.Text = "Type:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(102, 220);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(45, 17);
            this.label72.TabIndex = 10;
            this.label72.Text = "Issue:";
            // 
            // magazinegroupBox4
            // 
            this.magazinegroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magazinegroupBox4.Controls.Add(this.button7);
            this.magazinegroupBox4.Controls.Add(this.magazinenamelbl4);
            this.magazinegroupBox4.Controls.Add(label50);
            this.magazinegroupBox4.Controls.Add(this.pictureBox10);
            this.magazinegroupBox4.Controls.Add(this.magazinepricelabel4);
            this.magazinegroupBox4.Controls.Add(this.typlelabel4);
            this.magazinegroupBox4.Controls.Add(this.issuelabel4);
            this.magazinegroupBox4.Controls.Add(this.label57);
            this.magazinegroupBox4.Controls.Add(this.label60);
            this.magazinegroupBox4.Controls.Add(this.label61);
            this.magazinegroupBox4.Location = new System.Drawing.Point(25, 380);
            this.magazinegroupBox4.Name = "magazinegroupBox4";
            this.magazinegroupBox4.Size = new System.Drawing.Size(329, 337);
            this.magazinegroupBox4.TabIndex = 28;
            this.magazinegroupBox4.TabStop = false;
            this.magazinegroupBox4.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 29);
            this.button7.TabIndex = 30;
            this.button7.Text = "Sepete Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // magazinenamelbl4
            // 
            this.magazinenamelbl4.AutoSize = true;
            this.magazinenamelbl4.Location = new System.Drawing.Point(165, 190);
            this.magazinenamelbl4.Name = "magazinenamelbl4";
            this.magazinenamelbl4.Size = new System.Drawing.Size(45, 17);
            this.magazinenamelbl4.TabIndex = 26;
            this.magazinenamelbl4.Text = "Name";
            // 
            // pictureBox10
            // 
            this.pictureBox10.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox10.Image = global::OopFinalProject2021.Properties.Resources.sportmagazine;
            this.pictureBox10.Location = new System.Drawing.Point(94, 7);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(121, 166);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // magazinepricelabel4
            // 
            this.magazinepricelabel4.AutoSize = true;
            this.magazinepricelabel4.Location = new System.Drawing.Point(167, 279);
            this.magazinepricelabel4.Name = "magazinepricelabel4";
            this.magazinepricelabel4.Size = new System.Drawing.Size(45, 17);
            this.magazinepricelabel4.TabIndex = 16;
            this.magazinepricelabel4.Text = "Name";
            // 
            // typlelabel4
            // 
            this.typlelabel4.AutoSize = true;
            this.typlelabel4.Location = new System.Drawing.Point(167, 246);
            this.typlelabel4.Name = "typlelabel4";
            this.typlelabel4.Size = new System.Drawing.Size(45, 17);
            this.typlelabel4.TabIndex = 15;
            this.typlelabel4.Text = "Name";
            // 
            // issuelabel4
            // 
            this.issuelabel4.AutoSize = true;
            this.issuelabel4.Location = new System.Drawing.Point(165, 217);
            this.issuelabel4.Name = "issuelabel4";
            this.issuelabel4.Size = new System.Drawing.Size(45, 17);
            this.issuelabel4.TabIndex = 14;
            this.issuelabel4.Text = "Name";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(102, 279);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(44, 17);
            this.label57.TabIndex = 12;
            this.label57.Text = "Price:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(102, 250);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(44, 17);
            this.label60.TabIndex = 11;
            this.label60.Text = "Type:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(102, 219);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(45, 17);
            this.label61.TabIndex = 10;
            this.label61.Text = "Issue:";
            // 
            // magazinegroupBox3
            // 
            this.magazinegroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magazinegroupBox3.Controls.Add(this.button6);
            this.magazinegroupBox3.Controls.Add(this.magazinenamelbl3);
            this.magazinegroupBox3.Controls.Add(label37);
            this.magazinegroupBox3.Controls.Add(this.pictureBox9);
            this.magazinegroupBox3.Controls.Add(this.magazinepricelabel3);
            this.magazinegroupBox3.Controls.Add(this.typlelabel3);
            this.magazinegroupBox3.Controls.Add(this.issuelabel3);
            this.magazinegroupBox3.Controls.Add(this.label46);
            this.magazinegroupBox3.Controls.Add(this.label47);
            this.magazinegroupBox3.Controls.Add(this.label48);
            this.magazinegroupBox3.Location = new System.Drawing.Point(754, 20);
            this.magazinegroupBox3.Name = "magazinegroupBox3";
            this.magazinegroupBox3.Size = new System.Drawing.Size(329, 329);
            this.magazinegroupBox3.TabIndex = 28;
            this.magazinegroupBox3.TabStop = false;
            this.magazinegroupBox3.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(87, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 29);
            this.button6.TabIndex = 29;
            this.button6.Text = "Sepete Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // magazinenamelbl3
            // 
            this.magazinenamelbl3.AutoSize = true;
            this.magazinenamelbl3.Location = new System.Drawing.Point(165, 177);
            this.magazinenamelbl3.Name = "magazinenamelbl3";
            this.magazinenamelbl3.Size = new System.Drawing.Size(45, 17);
            this.magazinenamelbl3.TabIndex = 26;
            this.magazinenamelbl3.Text = "Name";
            // 
            // pictureBox9
            // 
            this.pictureBox9.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox9.Image = global::OopFinalProject2021.Properties.Resources.voguerihanna;
            this.pictureBox9.Location = new System.Drawing.Point(94, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(121, 166);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // magazinepricelabel3
            // 
            this.magazinepricelabel3.AutoSize = true;
            this.magazinepricelabel3.Location = new System.Drawing.Point(167, 266);
            this.magazinepricelabel3.Name = "magazinepricelabel3";
            this.magazinepricelabel3.Size = new System.Drawing.Size(45, 17);
            this.magazinepricelabel3.TabIndex = 16;
            this.magazinepricelabel3.Text = "Name";
            // 
            // typlelabel3
            // 
            this.typlelabel3.AutoSize = true;
            this.typlelabel3.Location = new System.Drawing.Point(167, 233);
            this.typlelabel3.Name = "typlelabel3";
            this.typlelabel3.Size = new System.Drawing.Size(45, 17);
            this.typlelabel3.TabIndex = 15;
            this.typlelabel3.Text = "Name";
            // 
            // issuelabel3
            // 
            this.issuelabel3.AutoSize = true;
            this.issuelabel3.Location = new System.Drawing.Point(165, 204);
            this.issuelabel3.Name = "issuelabel3";
            this.issuelabel3.Size = new System.Drawing.Size(45, 17);
            this.issuelabel3.TabIndex = 14;
            this.issuelabel3.Text = "Name";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(102, 266);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(44, 17);
            this.label46.TabIndex = 12;
            this.label46.Text = "Price:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(102, 237);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 17);
            this.label47.TabIndex = 11;
            this.label47.Text = "Type:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(102, 206);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(45, 17);
            this.label48.TabIndex = 10;
            this.label48.Text = "Issue:";
            // 
            // magazinegroupBox2
            // 
            this.magazinegroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magazinegroupBox2.Controls.Add(this.button5);
            this.magazinegroupBox2.Controls.Add(this.magazinenamelbl2);
            this.magazinegroupBox2.Controls.Add(label16);
            this.magazinegroupBox2.Controls.Add(this.pictureBox8);
            this.magazinegroupBox2.Controls.Add(this.magazinepricelabel2);
            this.magazinegroupBox2.Controls.Add(this.typlelabel2);
            this.magazinegroupBox2.Controls.Add(this.issuelabel2);
            this.magazinegroupBox2.Controls.Add(this.label25);
            this.magazinegroupBox2.Controls.Add(this.label32);
            this.magazinegroupBox2.Controls.Add(this.label35);
            this.magazinegroupBox2.Location = new System.Drawing.Point(394, 19);
            this.magazinegroupBox2.Name = "magazinegroupBox2";
            this.magazinegroupBox2.Size = new System.Drawing.Size(329, 329);
            this.magazinegroupBox2.TabIndex = 27;
            this.magazinegroupBox2.TabStop = false;
            this.magazinegroupBox2.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 29);
            this.button5.TabIndex = 28;
            this.button5.Text = "Sepete Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // magazinenamelbl2
            // 
            this.magazinenamelbl2.AutoSize = true;
            this.magazinenamelbl2.Location = new System.Drawing.Point(165, 177);
            this.magazinenamelbl2.Name = "magazinenamelbl2";
            this.magazinenamelbl2.Size = new System.Drawing.Size(45, 17);
            this.magazinenamelbl2.TabIndex = 26;
            this.magazinenamelbl2.Text = "Name";
            // 
            // pictureBox8
            // 
            this.pictureBox8.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox8.Image = global::OopFinalProject2021.Properties.Resources.macworldmagazine;
            this.pictureBox8.Location = new System.Drawing.Point(94, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 166);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // magazinepricelabel2
            // 
            this.magazinepricelabel2.AutoSize = true;
            this.magazinepricelabel2.Location = new System.Drawing.Point(167, 266);
            this.magazinepricelabel2.Name = "magazinepricelabel2";
            this.magazinepricelabel2.Size = new System.Drawing.Size(45, 17);
            this.magazinepricelabel2.TabIndex = 16;
            this.magazinepricelabel2.Text = "Name";
            // 
            // typlelabel2
            // 
            this.typlelabel2.AutoSize = true;
            this.typlelabel2.Location = new System.Drawing.Point(167, 233);
            this.typlelabel2.Name = "typlelabel2";
            this.typlelabel2.Size = new System.Drawing.Size(45, 17);
            this.typlelabel2.TabIndex = 15;
            this.typlelabel2.Text = "Name";
            // 
            // issuelabel2
            // 
            this.issuelabel2.AutoSize = true;
            this.issuelabel2.Location = new System.Drawing.Point(165, 204);
            this.issuelabel2.Name = "issuelabel2";
            this.issuelabel2.Size = new System.Drawing.Size(45, 17);
            this.issuelabel2.TabIndex = 14;
            this.issuelabel2.Text = "Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(102, 266);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 17);
            this.label25.TabIndex = 12;
            this.label25.Text = "Price:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(102, 237);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 17);
            this.label32.TabIndex = 11;
            this.label32.Text = "Type:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(102, 206);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(45, 17);
            this.label35.TabIndex = 10;
            this.label35.Text = "Issue:";
            // 
            // magazinegroupBox1
            // 
            this.magazinegroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.magazinegroupBox1.Controls.Add(this.buttonnn4);
            this.magazinegroupBox1.Controls.Add(this.magazinenamelbl1);
            this.magazinegroupBox1.Controls.Add(label15);
            this.magazinegroupBox1.Controls.Add(this.pictureBox7);
            this.magazinegroupBox1.Controls.Add(this.magazinepricelabel1);
            this.magazinegroupBox1.Controls.Add(this.typlelabel1);
            this.magazinegroupBox1.Controls.Add(this.issuelabel1);
            this.magazinegroupBox1.Controls.Add(this.label26);
            this.magazinegroupBox1.Controls.Add(this.label27);
            this.magazinegroupBox1.Controls.Add(this.label28);
            this.magazinegroupBox1.Location = new System.Drawing.Point(25, 17);
            this.magazinegroupBox1.Name = "magazinegroupBox1";
            this.magazinegroupBox1.Size = new System.Drawing.Size(329, 329);
            this.magazinegroupBox1.TabIndex = 14;
            this.magazinegroupBox1.TabStop = false;
            this.magazinegroupBox1.Visible = false;
            // 
            // buttonnn4
            // 
            this.buttonnn4.Location = new System.Drawing.Point(84, 290);
            this.buttonnn4.Name = "buttonnn4";
            this.buttonnn4.Size = new System.Drawing.Size(178, 39);
            this.buttonnn4.TabIndex = 28;
            this.buttonnn4.Text = "Sepete Ekle";
            this.buttonnn4.UseVisualStyleBackColor = true;
            this.buttonnn4.Click += new System.EventHandler(this.buttonnn4_Click);
            // 
            // magazinenamelbl1
            // 
            this.magazinenamelbl1.AutoSize = true;
            this.magazinenamelbl1.Location = new System.Drawing.Point(165, 177);
            this.magazinenamelbl1.Name = "magazinenamelbl1";
            this.magazinenamelbl1.Size = new System.Drawing.Size(45, 17);
            this.magazinenamelbl1.TabIndex = 26;
            this.magazinenamelbl1.Text = "Name";
            // 
            // pictureBox7
            // 
            this.pictureBox7.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox7.Image = global::OopFinalProject2021.Properties.Resources.lifebeginmagazine;
            this.pictureBox7.Location = new System.Drawing.Point(94, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(121, 166);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // magazinepricelabel1
            // 
            this.magazinepricelabel1.AutoSize = true;
            this.magazinepricelabel1.Location = new System.Drawing.Point(167, 266);
            this.magazinepricelabel1.Name = "magazinepricelabel1";
            this.magazinepricelabel1.Size = new System.Drawing.Size(45, 17);
            this.magazinepricelabel1.TabIndex = 16;
            this.magazinepricelabel1.Text = "Name";
            // 
            // typlelabel1
            // 
            this.typlelabel1.AutoSize = true;
            this.typlelabel1.Location = new System.Drawing.Point(167, 233);
            this.typlelabel1.Name = "typlelabel1";
            this.typlelabel1.Size = new System.Drawing.Size(45, 17);
            this.typlelabel1.TabIndex = 15;
            this.typlelabel1.Text = "Name";
            // 
            // issuelabel1
            // 
            this.issuelabel1.AutoSize = true;
            this.issuelabel1.Location = new System.Drawing.Point(165, 204);
            this.issuelabel1.Name = "issuelabel1";
            this.issuelabel1.Size = new System.Drawing.Size(45, 17);
            this.issuelabel1.TabIndex = 14;
            this.issuelabel1.Text = "Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(102, 266);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 17);
            this.label26.TabIndex = 12;
            this.label26.Text = "Price:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(102, 237);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 17);
            this.label27.TabIndex = 11;
            this.label27.Text = "Type:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(102, 206);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 17);
            this.label28.TabIndex = 10;
            this.label28.Text = "Issue:";
            // 
            // bookgroupbox6
            // 
            this.bookgroupbox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookgroupbox6.Controls.Add(this.button21);
            this.bookgroupbox6.Controls.Add(this.namelbl6);
            this.bookgroupbox6.Controls.Add(label58);
            this.bookgroupbox6.Controls.Add(this.label59);
            this.bookgroupbox6.Controls.Add(this.pictureBox6);
            this.bookgroupbox6.Controls.Add(this.pagelbl6);
            this.bookgroupbox6.Controls.Add(this.publisherlbl6);
            this.bookgroupbox6.Controls.Add(this.pricelbl6);
            this.bookgroupbox6.Controls.Add(this.authorlbl6);
            this.bookgroupbox6.Controls.Add(this.label64);
            this.bookgroupbox6.Controls.Add(this.label65);
            this.bookgroupbox6.Controls.Add(this.label66);
            this.bookgroupbox6.Location = new System.Drawing.Point(941, 366);
            this.bookgroupbox6.Name = "bookgroupbox6";
            this.bookgroupbox6.Size = new System.Drawing.Size(329, 356);
            this.bookgroupbox6.TabIndex = 29;
            this.bookgroupbox6.TabStop = false;
            this.bookgroupbox6.Visible = false;
            this.bookgroupbox6.Enter += new System.EventHandler(this.bookgroupbox6_Enter);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(116, 321);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(104, 29);
            this.button21.TabIndex = 32;
            this.button21.Text = "Sepete Ekle";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // namelbl6
            // 
            this.namelbl6.AutoSize = true;
            this.namelbl6.Location = new System.Drawing.Point(176, 184);
            this.namelbl6.Name = "namelbl6";
            this.namelbl6.Size = new System.Drawing.Size(45, 17);
            this.namelbl6.TabIndex = 26;
            this.namelbl6.Text = "Name";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(116, 301);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(40, 17);
            this.label59.TabIndex = 22;
            this.label59.Text = "Price";
            // 
            // pictureBox6
            // 
            this.pictureBox6.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox6.Image = global::OopFinalProject2021.Properties.Resources.Stefan_Zweig;
            this.pictureBox6.Location = new System.Drawing.Point(99, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 174);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pagelbl6
            // 
            this.pagelbl6.AutoSize = true;
            this.pagelbl6.Location = new System.Drawing.Point(178, 269);
            this.pagelbl6.Name = "pagelbl6";
            this.pagelbl6.Size = new System.Drawing.Size(45, 17);
            this.pagelbl6.TabIndex = 16;
            this.pagelbl6.Text = "Name";
            // 
            // publisherlbl6
            // 
            this.publisherlbl6.AutoSize = true;
            this.publisherlbl6.Location = new System.Drawing.Point(178, 240);
            this.publisherlbl6.Name = "publisherlbl6";
            this.publisherlbl6.Size = new System.Drawing.Size(45, 17);
            this.publisherlbl6.TabIndex = 15;
            this.publisherlbl6.Text = "Name";
            // 
            // pricelbl6
            // 
            this.pricelbl6.AutoSize = true;
            this.pricelbl6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricelbl6.Location = new System.Drawing.Point(176, 301);
            this.pricelbl6.Name = "pricelbl6";
            this.pricelbl6.Size = new System.Drawing.Size(45, 17);
            this.pricelbl6.TabIndex = 17;
            this.pricelbl6.Text = "Name";
            // 
            // authorlbl6
            // 
            this.authorlbl6.AutoSize = true;
            this.authorlbl6.Location = new System.Drawing.Point(176, 211);
            this.authorlbl6.Name = "authorlbl6";
            this.authorlbl6.Size = new System.Drawing.Size(45, 17);
            this.authorlbl6.TabIndex = 14;
            this.authorlbl6.Text = "Name";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(115, 269);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(41, 17);
            this.label64.TabIndex = 12;
            this.label64.Text = "Page";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(115, 240);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(67, 17);
            this.label65.TabIndex = 11;
            this.label65.Text = "Publisher";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(113, 208);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(50, 17);
            this.label66.TabIndex = 10;
            this.label66.Text = "Author";
            // 
            // MusicCDbutton
            // 
            this.MusicCDbutton.BackColor = System.Drawing.Color.MidnightBlue;
            this.MusicCDbutton.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusicCDbutton.ForeColor = System.Drawing.Color.White;
            this.MusicCDbutton.Location = new System.Drawing.Point(0, 286);
            this.MusicCDbutton.Name = "MusicCDbutton";
            this.MusicCDbutton.Size = new System.Drawing.Size(173, 88);
            this.MusicCDbutton.TabIndex = 2;
            this.MusicCDbutton.Text = "MusicCD";
            this.MusicCDbutton.UseVisualStyleBackColor = false;
            this.MusicCDbutton.Click += new System.EventHandler(this.MusicCDbutton_Click);
            // 
            // bookgroupbox5
            // 
            this.bookgroupbox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookgroupbox5.Controls.Add(this.button20);
            this.bookgroupbox5.Controls.Add(this.namelbl5);
            this.bookgroupbox5.Controls.Add(label43);
            this.bookgroupbox5.Controls.Add(this.label44);
            this.bookgroupbox5.Controls.Add(this.pictureBox5);
            this.bookgroupbox5.Controls.Add(this.pagelbl5);
            this.bookgroupbox5.Controls.Add(this.publisherlbl5);
            this.bookgroupbox5.Controls.Add(this.pricelbl5);
            this.bookgroupbox5.Controls.Add(this.authorlbl5);
            this.bookgroupbox5.Controls.Add(this.label54);
            this.bookgroupbox5.Controls.Add(this.label55);
            this.bookgroupbox5.Controls.Add(this.label56);
            this.bookgroupbox5.Location = new System.Drawing.Point(581, 366);
            this.bookgroupbox5.Name = "bookgroupbox5";
            this.bookgroupbox5.Size = new System.Drawing.Size(329, 356);
            this.bookgroupbox5.TabIndex = 28;
            this.bookgroupbox5.TabStop = false;
            this.bookgroupbox5.Visible = false;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(110, 321);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(104, 29);
            this.button20.TabIndex = 31;
            this.button20.Text = "Sepete Ekle";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // namelbl5
            // 
            this.namelbl5.AutoSize = true;
            this.namelbl5.Location = new System.Drawing.Point(172, 184);
            this.namelbl5.Name = "namelbl5";
            this.namelbl5.Size = new System.Drawing.Size(45, 17);
            this.namelbl5.TabIndex = 26;
            this.namelbl5.Text = "Name";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(112, 301);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(40, 17);
            this.label44.TabIndex = 22;
            this.label44.Text = "Price";
            // 
            // pictureBox5
            // 
            this.pictureBox5.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox5.Image = global::OopFinalProject2021.Properties.Resources.dan_brown;
            this.pictureBox5.Location = new System.Drawing.Point(99, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(132, 173);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pagelbl5
            // 
            this.pagelbl5.AutoSize = true;
            this.pagelbl5.Location = new System.Drawing.Point(174, 269);
            this.pagelbl5.Name = "pagelbl5";
            this.pagelbl5.Size = new System.Drawing.Size(45, 17);
            this.pagelbl5.TabIndex = 16;
            this.pagelbl5.Text = "Name";
            // 
            // publisherlbl5
            // 
            this.publisherlbl5.AutoSize = true;
            this.publisherlbl5.Location = new System.Drawing.Point(174, 240);
            this.publisherlbl5.Name = "publisherlbl5";
            this.publisherlbl5.Size = new System.Drawing.Size(45, 17);
            this.publisherlbl5.TabIndex = 15;
            this.publisherlbl5.Text = "Name";
            // 
            // pricelbl5
            // 
            this.pricelbl5.AutoSize = true;
            this.pricelbl5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricelbl5.Location = new System.Drawing.Point(172, 301);
            this.pricelbl5.Name = "pricelbl5";
            this.pricelbl5.Size = new System.Drawing.Size(45, 17);
            this.pricelbl5.TabIndex = 17;
            this.pricelbl5.Text = "Name";
            // 
            // authorlbl5
            // 
            this.authorlbl5.AutoSize = true;
            this.authorlbl5.Location = new System.Drawing.Point(172, 211);
            this.authorlbl5.Name = "authorlbl5";
            this.authorlbl5.Size = new System.Drawing.Size(45, 17);
            this.authorlbl5.TabIndex = 14;
            this.authorlbl5.Text = "Name";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(111, 269);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 17);
            this.label54.TabIndex = 12;
            this.label54.Text = "Page";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(111, 240);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(67, 17);
            this.label55.TabIndex = 11;
            this.label55.Text = "Publisher";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(109, 208);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(50, 17);
            this.label56.TabIndex = 10;
            this.label56.Text = "Author";
            // 
            // BooksButton
            // 
            this.BooksButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.BooksButton.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BooksButton.ForeColor = System.Drawing.Color.White;
            this.BooksButton.Location = new System.Drawing.Point(0, 34);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(173, 88);
            this.BooksButton.TabIndex = 0;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = false;
            this.BooksButton.Click += new System.EventHandler(this.BooksButton_Click);
            // 
            // bookgroupbox4
            // 
            this.bookgroupbox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookgroupbox4.Controls.Add(this.button19);
            this.bookgroupbox4.Controls.Add(this.namelbl4);
            this.bookgroupbox4.Controls.Add(label33);
            this.bookgroupbox4.Controls.Add(this.label34);
            this.bookgroupbox4.Controls.Add(this.pictureBox4);
            this.bookgroupbox4.Controls.Add(this.pagelbl4);
            this.bookgroupbox4.Controls.Add(this.publisherlbl4);
            this.bookgroupbox4.Controls.Add(this.pricelbl4);
            this.bookgroupbox4.Controls.Add(this.authorlbl4);
            this.bookgroupbox4.Controls.Add(this.label39);
            this.bookgroupbox4.Controls.Add(this.label40);
            this.bookgroupbox4.Controls.Add(this.label41);
            this.bookgroupbox4.Location = new System.Drawing.Point(216, 366);
            this.bookgroupbox4.Name = "bookgroupbox4";
            this.bookgroupbox4.Size = new System.Drawing.Size(329, 355);
            this.bookgroupbox4.TabIndex = 27;
            this.bookgroupbox4.TabStop = false;
            this.bookgroupbox4.Visible = false;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(106, 321);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(104, 29);
            this.button19.TabIndex = 30;
            this.button19.Text = "Sepete Ekle";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // namelbl4
            // 
            this.namelbl4.AutoSize = true;
            this.namelbl4.Location = new System.Drawing.Point(166, 184);
            this.namelbl4.Name = "namelbl4";
            this.namelbl4.Size = new System.Drawing.Size(45, 17);
            this.namelbl4.TabIndex = 26;
            this.namelbl4.Text = "Name";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(106, 301);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 17);
            this.label34.TabIndex = 22;
            this.label34.Text = "Price";
            // 
            // pictureBox4
            // 
            this.pictureBox4.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox4.Image = global::OopFinalProject2021.Properties.Resources.Kurk_mantolu;
            this.pictureBox4.Location = new System.Drawing.Point(93, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 173);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pagelbl4
            // 
            this.pagelbl4.AutoSize = true;
            this.pagelbl4.Location = new System.Drawing.Point(168, 269);
            this.pagelbl4.Name = "pagelbl4";
            this.pagelbl4.Size = new System.Drawing.Size(45, 17);
            this.pagelbl4.TabIndex = 16;
            this.pagelbl4.Text = "Name";
            this.pagelbl4.Click += new System.EventHandler(this.label35_Click);
            // 
            // publisherlbl4
            // 
            this.publisherlbl4.AutoSize = true;
            this.publisherlbl4.Location = new System.Drawing.Point(168, 240);
            this.publisherlbl4.Name = "publisherlbl4";
            this.publisherlbl4.Size = new System.Drawing.Size(45, 17);
            this.publisherlbl4.TabIndex = 15;
            this.publisherlbl4.Text = "Name";
            // 
            // pricelbl4
            // 
            this.pricelbl4.AutoSize = true;
            this.pricelbl4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricelbl4.Location = new System.Drawing.Point(166, 301);
            this.pricelbl4.Name = "pricelbl4";
            this.pricelbl4.Size = new System.Drawing.Size(45, 17);
            this.pricelbl4.TabIndex = 17;
            this.pricelbl4.Text = "Name";
            // 
            // authorlbl4
            // 
            this.authorlbl4.AutoSize = true;
            this.authorlbl4.Location = new System.Drawing.Point(166, 211);
            this.authorlbl4.Name = "authorlbl4";
            this.authorlbl4.Size = new System.Drawing.Size(45, 17);
            this.authorlbl4.TabIndex = 14;
            this.authorlbl4.Text = "Name";
            this.authorlbl4.Click += new System.EventHandler(this.label38_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(105, 269);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 17);
            this.label39.TabIndex = 12;
            this.label39.Text = "Page";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(105, 240);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(67, 17);
            this.label40.TabIndex = 11;
            this.label40.Text = "Publisher";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(103, 208);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 17);
            this.label41.TabIndex = 10;
            this.label41.Text = "Author";
            // 
            // MagazineButton
            // 
            this.MagazineButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.MagazineButton.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MagazineButton.ForeColor = System.Drawing.Color.White;
            this.MagazineButton.Location = new System.Drawing.Point(0, 160);
            this.MagazineButton.Name = "MagazineButton";
            this.MagazineButton.Size = new System.Drawing.Size(173, 88);
            this.MagazineButton.TabIndex = 1;
            this.MagazineButton.Text = "Magazine";
            this.MagazineButton.UseVisualStyleBackColor = false;
            this.MagazineButton.Click += new System.EventHandler(this.MagazineButton_Click);
            // 
            // bookgroupbox3
            // 
            this.bookgroupbox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookgroupbox3.Controls.Add(this.button18);
            this.bookgroupbox3.Controls.Add(this.namelbl3);
            this.bookgroupbox3.Controls.Add(label23);
            this.bookgroupbox3.Controls.Add(this.label24);
            this.bookgroupbox3.Controls.Add(this.pictureBox3);
            this.bookgroupbox3.Controls.Add(this.pagelbl3);
            this.bookgroupbox3.Controls.Add(this.publisherlbl3);
            this.bookgroupbox3.Controls.Add(this.pricelbl3);
            this.bookgroupbox3.Controls.Add(this.authorlbl3);
            this.bookgroupbox3.Controls.Add(this.label29);
            this.bookgroupbox3.Controls.Add(this.label30);
            this.bookgroupbox3.Controls.Add(this.label31);
            this.bookgroupbox3.Location = new System.Drawing.Point(941, 13);
            this.bookgroupbox3.Name = "bookgroupbox3";
            this.bookgroupbox3.Size = new System.Drawing.Size(329, 346);
            this.bookgroupbox3.TabIndex = 28;
            this.bookgroupbox3.TabStop = false;
            this.bookgroupbox3.Visible = false;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(111, 314);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(104, 29);
            this.button18.TabIndex = 29;
            this.button18.Text = "Sepete Ekle";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // namelbl3
            // 
            this.namelbl3.AutoSize = true;
            this.namelbl3.Location = new System.Drawing.Point(170, 177);
            this.namelbl3.Name = "namelbl3";
            this.namelbl3.Size = new System.Drawing.Size(45, 17);
            this.namelbl3.TabIndex = 26;
            this.namelbl3.Text = "Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(110, 294);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 17);
            this.label24.TabIndex = 22;
            this.label24.Text = "Price";
            // 
            // pictureBox3
            // 
            this.pictureBox3.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox3.Image = global::OopFinalProject2021.Properties.Resources.CLOCK;
            this.pictureBox3.Location = new System.Drawing.Point(99, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pagelbl3
            // 
            this.pagelbl3.AutoSize = true;
            this.pagelbl3.Location = new System.Drawing.Point(172, 262);
            this.pagelbl3.Name = "pagelbl3";
            this.pagelbl3.Size = new System.Drawing.Size(45, 17);
            this.pagelbl3.TabIndex = 16;
            this.pagelbl3.Text = "Name";
            // 
            // publisherlbl3
            // 
            this.publisherlbl3.AutoSize = true;
            this.publisherlbl3.Location = new System.Drawing.Point(172, 233);
            this.publisherlbl3.Name = "publisherlbl3";
            this.publisherlbl3.Size = new System.Drawing.Size(45, 17);
            this.publisherlbl3.TabIndex = 15;
            this.publisherlbl3.Text = "Name";
            // 
            // pricelbl3
            // 
            this.pricelbl3.AutoSize = true;
            this.pricelbl3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricelbl3.Location = new System.Drawing.Point(170, 294);
            this.pricelbl3.Name = "pricelbl3";
            this.pricelbl3.Size = new System.Drawing.Size(45, 17);
            this.pricelbl3.TabIndex = 17;
            this.pricelbl3.Text = "Name";
            // 
            // authorlbl3
            // 
            this.authorlbl3.AutoSize = true;
            this.authorlbl3.Location = new System.Drawing.Point(170, 204);
            this.authorlbl3.Name = "authorlbl3";
            this.authorlbl3.Size = new System.Drawing.Size(45, 17);
            this.authorlbl3.TabIndex = 14;
            this.authorlbl3.Text = "Name";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(109, 262);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 17);
            this.label29.TabIndex = 12;
            this.label29.Text = "Page";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(109, 233);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 17);
            this.label30.TabIndex = 11;
            this.label30.Text = "Publisher";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(107, 201);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 17);
            this.label31.TabIndex = 10;
            this.label31.Text = "Author";
            // 
            // MusicCdPanel
            // 
            this.MusicCdPanel.AutoScroll = true;
            this.MusicCdPanel.Controls.Add(this.musicgroupbox6);
            this.MusicCdPanel.Controls.Add(this.musicgroupbox5);
            this.MusicCdPanel.Controls.Add(this.musicgroupbox4);
            this.MusicCdPanel.Controls.Add(this.musicgroupboxx3);
            this.MusicCdPanel.Controls.Add(this.musicgroupbox2);
            this.MusicCdPanel.Controls.Add(this.musicgroupbox1);
            this.MusicCdPanel.Location = new System.Drawing.Point(206, 23);
            this.MusicCdPanel.Name = "MusicCdPanel";
            this.MusicCdPanel.Size = new System.Drawing.Size(1094, 699);
            this.MusicCdPanel.TabIndex = 29;
            this.MusicCdPanel.Visible = false;
            // 
            // musicgroupbox6
            // 
            this.musicgroupbox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musicgroupbox6.Controls.Add(this.button15);
            this.musicgroupbox6.Controls.Add(this.musicname6);
            this.musicgroupbox6.Controls.Add(label17);
            this.musicgroupbox6.Controls.Add(this.pictureBox13);
            this.musicgroupbox6.Controls.Add(this.musicprice6);
            this.musicgroupbox6.Controls.Add(this.singletype6);
            this.musicgroupbox6.Controls.Add(this.Singerlabel6);
            this.musicgroupbox6.Controls.Add(this.label38);
            this.musicgroupbox6.Controls.Add(this.label42);
            this.musicgroupbox6.Controls.Add(this.label45);
            this.musicgroupbox6.Location = new System.Drawing.Point(754, 373);
            this.musicgroupbox6.Name = "musicgroupbox6";
            this.musicgroupbox6.Size = new System.Drawing.Size(329, 329);
            this.musicgroupbox6.TabIndex = 28;
            this.musicgroupbox6.TabStop = false;
            this.musicgroupbox6.Visible = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(103, 289);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(116, 34);
            this.button15.TabIndex = 31;
            this.button15.Text = "Sepete Ekle";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // musicname6
            // 
            this.musicname6.AutoSize = true;
            this.musicname6.Location = new System.Drawing.Point(165, 177);
            this.musicname6.Name = "musicname6";
            this.musicname6.Size = new System.Drawing.Size(45, 17);
            this.musicname6.TabIndex = 26;
            this.musicname6.Text = "Name";
            // 
            // pictureBox13
            // 
            this.pictureBox13.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox13.Image = global::OopFinalProject2021.Properties.Resources.romance_music_;
            this.pictureBox13.Location = new System.Drawing.Point(94, 7);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(146, 166);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 21;
            this.pictureBox13.TabStop = false;
            // 
            // musicprice6
            // 
            this.musicprice6.AutoSize = true;
            this.musicprice6.Location = new System.Drawing.Point(167, 266);
            this.musicprice6.Name = "musicprice6";
            this.musicprice6.Size = new System.Drawing.Size(45, 17);
            this.musicprice6.TabIndex = 16;
            this.musicprice6.Text = "Name";
            // 
            // singletype6
            // 
            this.singletype6.AutoSize = true;
            this.singletype6.Location = new System.Drawing.Point(167, 233);
            this.singletype6.Name = "singletype6";
            this.singletype6.Size = new System.Drawing.Size(45, 17);
            this.singletype6.TabIndex = 15;
            this.singletype6.Text = "Name";
            // 
            // Singerlabel6
            // 
            this.Singerlabel6.AutoSize = true;
            this.Singerlabel6.Location = new System.Drawing.Point(165, 204);
            this.Singerlabel6.Name = "Singerlabel6";
            this.Singerlabel6.Size = new System.Drawing.Size(45, 17);
            this.Singerlabel6.TabIndex = 14;
            this.Singerlabel6.Text = "Name";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(102, 266);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 17);
            this.label38.TabIndex = 12;
            this.label38.Text = "Price:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(102, 237);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(44, 17);
            this.label42.TabIndex = 11;
            this.label42.Text = "Type:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(102, 206);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 17);
            this.label45.TabIndex = 10;
            this.label45.Text = "Singer:";
            // 
            // musicgroupbox5
            // 
            this.musicgroupbox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musicgroupbox5.Controls.Add(this.button14);
            this.musicgroupbox5.Controls.Add(this.musicname5);
            this.musicgroupbox5.Controls.Add(label51);
            this.musicgroupbox5.Controls.Add(this.pictureBox14);
            this.musicgroupbox5.Controls.Add(this.musicprice5);
            this.musicgroupbox5.Controls.Add(this.singletype5);
            this.musicgroupbox5.Controls.Add(this.Singerlabel5);
            this.musicgroupbox5.Controls.Add(this.label67);
            this.musicgroupbox5.Controls.Add(this.label68);
            this.musicgroupbox5.Controls.Add(this.label69);
            this.musicgroupbox5.Location = new System.Drawing.Point(394, 373);
            this.musicgroupbox5.Name = "musicgroupbox5";
            this.musicgroupbox5.Size = new System.Drawing.Size(329, 329);
            this.musicgroupbox5.TabIndex = 28;
            this.musicgroupbox5.TabStop = false;
            this.musicgroupbox5.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(103, 289);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(116, 34);
            this.button14.TabIndex = 31;
            this.button14.Text = "Sepete Ekle";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // musicname5
            // 
            this.musicname5.AutoSize = true;
            this.musicname5.Location = new System.Drawing.Point(165, 177);
            this.musicname5.Name = "musicname5";
            this.musicname5.Size = new System.Drawing.Size(45, 17);
            this.musicname5.TabIndex = 26;
            this.musicname5.Text = "Name";
            // 
            // pictureBox14
            // 
            this.pictureBox14.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox14.Image = global::OopFinalProject2021.Properties.Resources.BEATLES;
            this.pictureBox14.Location = new System.Drawing.Point(94, 7);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(148, 166);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 21;
            this.pictureBox14.TabStop = false;
            // 
            // musicprice5
            // 
            this.musicprice5.AutoSize = true;
            this.musicprice5.Location = new System.Drawing.Point(167, 266);
            this.musicprice5.Name = "musicprice5";
            this.musicprice5.Size = new System.Drawing.Size(45, 17);
            this.musicprice5.TabIndex = 16;
            this.musicprice5.Text = "Name";
            // 
            // singletype5
            // 
            this.singletype5.AutoSize = true;
            this.singletype5.Location = new System.Drawing.Point(167, 233);
            this.singletype5.Name = "singletype5";
            this.singletype5.Size = new System.Drawing.Size(45, 17);
            this.singletype5.TabIndex = 15;
            this.singletype5.Text = "Name";
            // 
            // Singerlabel5
            // 
            this.Singerlabel5.AutoSize = true;
            this.Singerlabel5.Location = new System.Drawing.Point(165, 204);
            this.Singerlabel5.Name = "Singerlabel5";
            this.Singerlabel5.Size = new System.Drawing.Size(45, 17);
            this.Singerlabel5.TabIndex = 14;
            this.Singerlabel5.Text = "Name";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(102, 266);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(44, 17);
            this.label67.TabIndex = 12;
            this.label67.Text = "Price:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(102, 237);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(44, 17);
            this.label68.TabIndex = 11;
            this.label68.Text = "Type:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(102, 206);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(53, 17);
            this.label69.TabIndex = 10;
            this.label69.Text = "Singer:";
            // 
            // musicgroupbox4
            // 
            this.musicgroupbox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musicgroupbox4.Controls.Add(this.button13);
            this.musicgroupbox4.Controls.Add(this.musicname4);
            this.musicgroupbox4.Controls.Add(label75);
            this.musicgroupbox4.Controls.Add(this.pictureBox15);
            this.musicgroupbox4.Controls.Add(this.musicprice4);
            this.musicgroupbox4.Controls.Add(this.singletype4);
            this.musicgroupbox4.Controls.Add(this.Singerlabel4);
            this.musicgroupbox4.Controls.Add(this.label83);
            this.musicgroupbox4.Controls.Add(this.label84);
            this.musicgroupbox4.Controls.Add(this.label85);
            this.musicgroupbox4.Location = new System.Drawing.Point(25, 373);
            this.musicgroupbox4.Name = "musicgroupbox4";
            this.musicgroupbox4.Size = new System.Drawing.Size(329, 329);
            this.musicgroupbox4.TabIndex = 28;
            this.musicgroupbox4.TabStop = false;
            this.musicgroupbox4.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(84, 286);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(139, 34);
            this.button13.TabIndex = 29;
            this.button13.Text = "Sepete Ekle";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // musicname4
            // 
            this.musicname4.AutoSize = true;
            this.musicname4.Location = new System.Drawing.Point(165, 177);
            this.musicname4.Name = "musicname4";
            this.musicname4.Size = new System.Drawing.Size(45, 17);
            this.musicname4.TabIndex = 26;
            this.musicname4.Text = "Name";
            // 
            // pictureBox15
            // 
            this.pictureBox15.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox15.Image = global::OopFinalProject2021.Properties.Resources.NİRVANA;
            this.pictureBox15.Location = new System.Drawing.Point(94, 7);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(139, 166);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 21;
            this.pictureBox15.TabStop = false;
            // 
            // musicprice4
            // 
            this.musicprice4.AutoSize = true;
            this.musicprice4.Location = new System.Drawing.Point(167, 266);
            this.musicprice4.Name = "musicprice4";
            this.musicprice4.Size = new System.Drawing.Size(45, 17);
            this.musicprice4.TabIndex = 16;
            this.musicprice4.Text = "Name";
            // 
            // singletype4
            // 
            this.singletype4.AutoSize = true;
            this.singletype4.Location = new System.Drawing.Point(167, 233);
            this.singletype4.Name = "singletype4";
            this.singletype4.Size = new System.Drawing.Size(45, 17);
            this.singletype4.TabIndex = 15;
            this.singletype4.Text = "Name";
            // 
            // Singerlabel4
            // 
            this.Singerlabel4.AutoSize = true;
            this.Singerlabel4.Location = new System.Drawing.Point(165, 204);
            this.Singerlabel4.Name = "Singerlabel4";
            this.Singerlabel4.Size = new System.Drawing.Size(45, 17);
            this.Singerlabel4.TabIndex = 14;
            this.Singerlabel4.Text = "Name";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(102, 266);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(44, 17);
            this.label83.TabIndex = 12;
            this.label83.Text = "Price:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(102, 237);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(44, 17);
            this.label84.TabIndex = 11;
            this.label84.Text = "Type:";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(102, 206);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(53, 17);
            this.label85.TabIndex = 10;
            this.label85.Text = "Singer:";
            // 
            // musicgroupboxx3
            // 
            this.musicgroupboxx3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musicgroupboxx3.Controls.Add(this.button12);
            this.musicgroupboxx3.Controls.Add(this.musicname3);
            this.musicgroupboxx3.Controls.Add(label87);
            this.musicgroupboxx3.Controls.Add(this.pictureBox16);
            this.musicgroupboxx3.Controls.Add(this.musicprice3);
            this.musicgroupboxx3.Controls.Add(this.singletype3);
            this.musicgroupboxx3.Controls.Add(this.Singerlabel3);
            this.musicgroupboxx3.Controls.Add(this.label91);
            this.musicgroupboxx3.Controls.Add(this.label92);
            this.musicgroupboxx3.Controls.Add(this.label93);
            this.musicgroupboxx3.Location = new System.Drawing.Point(754, 20);
            this.musicgroupboxx3.Name = "musicgroupboxx3";
            this.musicgroupboxx3.Size = new System.Drawing.Size(329, 329);
            this.musicgroupboxx3.TabIndex = 28;
            this.musicgroupboxx3.TabStop = false;
            this.musicgroupboxx3.Visible = false;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(96, 289);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(116, 34);
            this.button12.TabIndex = 29;
            this.button12.Text = "Sepete Ekle";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // musicname3
            // 
            this.musicname3.AutoSize = true;
            this.musicname3.Location = new System.Drawing.Point(165, 177);
            this.musicname3.Name = "musicname3";
            this.musicname3.Size = new System.Drawing.Size(45, 17);
            this.musicname3.TabIndex = 26;
            this.musicname3.Text = "Name";
            // 
            // pictureBox16
            // 
            this.pictureBox16.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox16.Image = global::OopFinalProject2021.Properties.Resources.cemadrian;
            this.pictureBox16.Location = new System.Drawing.Point(89, 7);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(151, 166);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 21;
            this.pictureBox16.TabStop = false;
            // 
            // musicprice3
            // 
            this.musicprice3.AutoSize = true;
            this.musicprice3.Location = new System.Drawing.Point(167, 266);
            this.musicprice3.Name = "musicprice3";
            this.musicprice3.Size = new System.Drawing.Size(45, 17);
            this.musicprice3.TabIndex = 16;
            this.musicprice3.Text = "Name";
            // 
            // singletype3
            // 
            this.singletype3.AutoSize = true;
            this.singletype3.Location = new System.Drawing.Point(167, 233);
            this.singletype3.Name = "singletype3";
            this.singletype3.Size = new System.Drawing.Size(45, 17);
            this.singletype3.TabIndex = 15;
            this.singletype3.Text = "Name";
            // 
            // Singerlabel3
            // 
            this.Singerlabel3.AutoSize = true;
            this.Singerlabel3.Location = new System.Drawing.Point(165, 204);
            this.Singerlabel3.Name = "Singerlabel3";
            this.Singerlabel3.Size = new System.Drawing.Size(45, 17);
            this.Singerlabel3.TabIndex = 14;
            this.Singerlabel3.Text = "Name";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(102, 266);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(44, 17);
            this.label91.TabIndex = 12;
            this.label91.Text = "Price:";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(102, 237);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(44, 17);
            this.label92.TabIndex = 11;
            this.label92.Text = "Type:";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(102, 206);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(53, 17);
            this.label93.TabIndex = 10;
            this.label93.Text = "Singer:";
            // 
            // musicgroupbox2
            // 
            this.musicgroupbox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musicgroupbox2.Controls.Add(this.button11);
            this.musicgroupbox2.Controls.Add(this.musicname2);
            this.musicgroupbox2.Controls.Add(label95);
            this.musicgroupbox2.Controls.Add(this.pictureBox17);
            this.musicgroupbox2.Controls.Add(this.musicprice2);
            this.musicgroupbox2.Controls.Add(this.singletype2);
            this.musicgroupbox2.Controls.Add(this.Singerlabel2);
            this.musicgroupbox2.Controls.Add(this.label99);
            this.musicgroupbox2.Controls.Add(this.label100);
            this.musicgroupbox2.Controls.Add(this.label101);
            this.musicgroupbox2.Location = new System.Drawing.Point(394, 19);
            this.musicgroupbox2.Name = "musicgroupbox2";
            this.musicgroupbox2.Size = new System.Drawing.Size(329, 329);
            this.musicgroupbox2.TabIndex = 27;
            this.musicgroupbox2.TabStop = false;
            this.musicgroupbox2.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(96, 289);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 34);
            this.button11.TabIndex = 28;
            this.button11.Text = "Sepete Ekle";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // musicname2
            // 
            this.musicname2.AutoSize = true;
            this.musicname2.Location = new System.Drawing.Point(165, 177);
            this.musicname2.Name = "musicname2";
            this.musicname2.Size = new System.Drawing.Size(45, 17);
            this.musicname2.TabIndex = 26;
            this.musicname2.Text = "Name";
            // 
            // pictureBox17
            // 
            this.pictureBox17.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox17.Image = global::OopFinalProject2021.Properties.Resources.yaşar;
            this.pictureBox17.Location = new System.Drawing.Point(94, 7);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(157, 166);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 21;
            this.pictureBox17.TabStop = false;
            // 
            // musicprice2
            // 
            this.musicprice2.AutoSize = true;
            this.musicprice2.Location = new System.Drawing.Point(167, 266);
            this.musicprice2.Name = "musicprice2";
            this.musicprice2.Size = new System.Drawing.Size(45, 17);
            this.musicprice2.TabIndex = 16;
            this.musicprice2.Text = "Name";
            // 
            // singletype2
            // 
            this.singletype2.AutoSize = true;
            this.singletype2.Location = new System.Drawing.Point(167, 233);
            this.singletype2.Name = "singletype2";
            this.singletype2.Size = new System.Drawing.Size(45, 17);
            this.singletype2.TabIndex = 15;
            this.singletype2.Text = "Name";
            // 
            // Singerlabel2
            // 
            this.Singerlabel2.AutoSize = true;
            this.Singerlabel2.Location = new System.Drawing.Point(165, 204);
            this.Singerlabel2.Name = "Singerlabel2";
            this.Singerlabel2.Size = new System.Drawing.Size(45, 17);
            this.Singerlabel2.TabIndex = 14;
            this.Singerlabel2.Text = "Name";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(102, 266);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(44, 17);
            this.label99.TabIndex = 12;
            this.label99.Text = "Price:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(102, 237);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(44, 17);
            this.label100.TabIndex = 11;
            this.label100.Text = "Type:";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(102, 206);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(49, 17);
            this.label101.TabIndex = 10;
            this.label101.Text = "Singer";
            // 
            // musicgroupbox1
            // 
            this.musicgroupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.musicgroupbox1.Controls.Add(this.button3);
            this.musicgroupbox1.Controls.Add(this.musicname1);
            this.musicgroupbox1.Controls.Add(label103);
            this.musicgroupbox1.Controls.Add(this.pictureBox18);
            this.musicgroupbox1.Controls.Add(this.musicprice1);
            this.musicgroupbox1.Controls.Add(this.singletype1);
            this.musicgroupbox1.Controls.Add(this.Singerlabel1);
            this.musicgroupbox1.Controls.Add(this.label107);
            this.musicgroupbox1.Controls.Add(this.label108);
            this.musicgroupbox1.Controls.Add(this.label109);
            this.musicgroupbox1.Location = new System.Drawing.Point(25, 16);
            this.musicgroupbox1.Name = "musicgroupbox1";
            this.musicgroupbox1.Size = new System.Drawing.Size(329, 329);
            this.musicgroupbox1.TabIndex = 14;
            this.musicgroupbox1.TabStop = false;
            this.musicgroupbox1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 27;
            this.button3.Text = "Sepete Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // musicname1
            // 
            this.musicname1.AutoSize = true;
            this.musicname1.Location = new System.Drawing.Point(165, 177);
            this.musicname1.Name = "musicname1";
            this.musicname1.Size = new System.Drawing.Size(45, 17);
            this.musicname1.TabIndex = 26;
            this.musicname1.Text = "Name";
            // 
            // pictureBox18
            // 
            this.pictureBox18.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox18.Image = global::OopFinalProject2021.Properties.Resources.AcayipTarkan;
            this.pictureBox18.Location = new System.Drawing.Point(77, 7);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(156, 166);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 21;
            this.pictureBox18.TabStop = false;
            // 
            // musicprice1
            // 
            this.musicprice1.AutoSize = true;
            this.musicprice1.Location = new System.Drawing.Point(167, 266);
            this.musicprice1.Name = "musicprice1";
            this.musicprice1.Size = new System.Drawing.Size(45, 17);
            this.musicprice1.TabIndex = 16;
            this.musicprice1.Text = "Name";
            // 
            // singletype1
            // 
            this.singletype1.AutoSize = true;
            this.singletype1.Location = new System.Drawing.Point(167, 233);
            this.singletype1.Name = "singletype1";
            this.singletype1.Size = new System.Drawing.Size(45, 17);
            this.singletype1.TabIndex = 15;
            this.singletype1.Text = "Name";
            // 
            // Singerlabel1
            // 
            this.Singerlabel1.AutoSize = true;
            this.Singerlabel1.Location = new System.Drawing.Point(165, 204);
            this.Singerlabel1.Name = "Singerlabel1";
            this.Singerlabel1.Size = new System.Drawing.Size(45, 17);
            this.Singerlabel1.TabIndex = 14;
            this.Singerlabel1.Text = "Name";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(102, 266);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(44, 17);
            this.label107.TabIndex = 12;
            this.label107.Text = "Price:";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(102, 237);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(44, 17);
            this.label108.TabIndex = 11;
            this.label108.Text = "Type:";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(102, 206);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(53, 17);
            this.label109.TabIndex = 10;
            this.label109.Text = "Singer:";
            // 
            // bookgroupbox2
            // 
            this.bookgroupbox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookgroupbox2.Controls.Add(this.button17);
            this.bookgroupbox2.Controls.Add(this.namelbl2);
            this.bookgroupbox2.Controls.Add(label13);
            this.bookgroupbox2.Controls.Add(this.label14);
            this.bookgroupbox2.Controls.Add(this.pictureBox2);
            this.bookgroupbox2.Controls.Add(this.pagelbl2);
            this.bookgroupbox2.Controls.Add(this.publisherlabel2);
            this.bookgroupbox2.Controls.Add(this.pricelbl2);
            this.bookgroupbox2.Controls.Add(this.authorlbl2);
            this.bookgroupbox2.Controls.Add(this.label19);
            this.bookgroupbox2.Controls.Add(this.label20);
            this.bookgroupbox2.Controls.Add(this.label21);
            this.bookgroupbox2.Location = new System.Drawing.Point(581, 16);
            this.bookgroupbox2.Name = "bookgroupbox2";
            this.bookgroupbox2.Size = new System.Drawing.Size(329, 343);
            this.bookgroupbox2.TabIndex = 27;
            this.bookgroupbox2.TabStop = false;
            this.bookgroupbox2.Visible = false;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(110, 311);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(104, 29);
            this.button17.TabIndex = 28;
            this.button17.Text = "Sepete Ekle";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // namelbl2
            // 
            this.namelbl2.AutoSize = true;
            this.namelbl2.Location = new System.Drawing.Point(170, 174);
            this.namelbl2.Name = "namelbl2";
            this.namelbl2.Size = new System.Drawing.Size(45, 17);
            this.namelbl2.TabIndex = 26;
            this.namelbl2.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(110, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox2.Image = global::OopFinalProject2021.Properties.Resources._1984;
            this.pictureBox2.Location = new System.Drawing.Point(99, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pagelbl2
            // 
            this.pagelbl2.AutoSize = true;
            this.pagelbl2.Location = new System.Drawing.Point(172, 259);
            this.pagelbl2.Name = "pagelbl2";
            this.pagelbl2.Size = new System.Drawing.Size(45, 17);
            this.pagelbl2.TabIndex = 16;
            this.pagelbl2.Text = "Name";
            // 
            // publisherlabel2
            // 
            this.publisherlabel2.AutoSize = true;
            this.publisherlabel2.Location = new System.Drawing.Point(172, 230);
            this.publisherlabel2.Name = "publisherlabel2";
            this.publisherlabel2.Size = new System.Drawing.Size(45, 17);
            this.publisherlabel2.TabIndex = 15;
            this.publisherlabel2.Text = "Name";
            // 
            // pricelbl2
            // 
            this.pricelbl2.AutoSize = true;
            this.pricelbl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricelbl2.Location = new System.Drawing.Point(170, 291);
            this.pricelbl2.Name = "pricelbl2";
            this.pricelbl2.Size = new System.Drawing.Size(45, 17);
            this.pricelbl2.TabIndex = 17;
            this.pricelbl2.Text = "Name";
            // 
            // authorlbl2
            // 
            this.authorlbl2.AutoSize = true;
            this.authorlbl2.Location = new System.Drawing.Point(170, 201);
            this.authorlbl2.Name = "authorlbl2";
            this.authorlbl2.Size = new System.Drawing.Size(45, 17);
            this.authorlbl2.TabIndex = 14;
            this.authorlbl2.Text = "Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(109, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Page";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(109, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "Publisher";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(107, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "Author";
            // 
            // bookgroupbox1
            // 
            this.bookgroupbox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookgroupbox1.Controls.Add(this.button16);
            this.bookgroupbox1.Controls.Add(this.namelbl1);
            this.bookgroupbox1.Controls.Add(nameLabel);
            this.bookgroupbox1.Controls.Add(this.label82);
            this.bookgroupbox1.Controls.Add(this.pictureBox1);
            this.bookgroupbox1.Controls.Add(this.pagelbl1);
            this.bookgroupbox1.Controls.Add(this.publisherlbl1);
            this.bookgroupbox1.Controls.Add(this.pricelbl1);
            this.bookgroupbox1.Controls.Add(this.authorlbl1);
            this.bookgroupbox1.Controls.Add(this.label12);
            this.bookgroupbox1.Controls.Add(this.label11);
            this.bookgroupbox1.Controls.Add(this.label10);
            this.bookgroupbox1.Location = new System.Drawing.Point(216, 16);
            this.bookgroupbox1.Name = "bookgroupbox1";
            this.bookgroupbox1.Size = new System.Drawing.Size(329, 343);
            this.bookgroupbox1.TabIndex = 13;
            this.bookgroupbox1.TabStop = false;
            this.bookgroupbox1.Visible = false;
            this.bookgroupbox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(101, 315);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(104, 29);
            this.button16.TabIndex = 27;
            this.button16.Text = "Sepete Ekle";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // namelbl1
            // 
            this.namelbl1.AutoSize = true;
            this.namelbl1.Location = new System.Drawing.Point(165, 177);
            this.namelbl1.Name = "namelbl1";
            this.namelbl1.Size = new System.Drawing.Size(45, 17);
            this.namelbl1.TabIndex = 26;
            this.namelbl1.Text = "Name";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(105, 294);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(40, 17);
            this.label82.TabIndex = 22;
            this.label82.Text = "Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.booksBindingSource, "Price", true));
            this.pictureBox1.Image = global::OopFinalProject2021.Properties.Resources.littleprience;
            this.pictureBox1.Location = new System.Drawing.Point(94, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pagelbl1
            // 
            this.pagelbl1.AutoSize = true;
            this.pagelbl1.Location = new System.Drawing.Point(167, 262);
            this.pagelbl1.Name = "pagelbl1";
            this.pagelbl1.Size = new System.Drawing.Size(45, 17);
            this.pagelbl1.TabIndex = 16;
            this.pagelbl1.Text = "Name";
            // 
            // publisherlbl1
            // 
            this.publisherlbl1.AutoSize = true;
            this.publisherlbl1.Location = new System.Drawing.Point(167, 233);
            this.publisherlbl1.Name = "publisherlbl1";
            this.publisherlbl1.Size = new System.Drawing.Size(45, 17);
            this.publisherlbl1.TabIndex = 15;
            this.publisherlbl1.Text = "Name";
            // 
            // pricelbl1
            // 
            this.pricelbl1.AutoSize = true;
            this.pricelbl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Price", true));
            this.pricelbl1.Location = new System.Drawing.Point(165, 294);
            this.pricelbl1.Name = "pricelbl1";
            this.pricelbl1.Size = new System.Drawing.Size(45, 17);
            this.pricelbl1.TabIndex = 17;
            this.pricelbl1.Text = "Name";
            // 
            // authorlbl1
            // 
            this.authorlbl1.AutoSize = true;
            this.authorlbl1.Location = new System.Drawing.Point(165, 204);
            this.authorlbl1.Name = "authorlbl1";
            this.authorlbl1.Size = new System.Drawing.Size(45, 17);
            this.authorlbl1.TabIndex = 14;
            this.authorlbl1.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Page";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Publisher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Author";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // onaybuton
            // 
            this.onaybuton.BackColor = System.Drawing.Color.DarkOrange;
            this.onaybuton.Font = new System.Drawing.Font("a song for jennifer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaybuton.ForeColor = System.Drawing.Color.White;
            this.onaybuton.Location = new System.Drawing.Point(732, 416);
            this.onaybuton.Name = "onaybuton";
            this.onaybuton.Size = new System.Drawing.Size(189, 44);
            this.onaybuton.TabIndex = 11;
            this.onaybuton.Text = "ONAYLIYORUM";
            this.onaybuton.UseVisualStyleBackColor = false;
            this.onaybuton.Click += new System.EventHandler(this.onaybuton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 640);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.SignupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.customerlabel);
            this.Controls.Add(this.LoginBox);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet4)).EndInit();
            this.SignupBox.ResumeLayout(false);
            this.SignupBox.PerformLayout();
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.menupanel.ResumeLayout(false);
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.cardInformation.ResumeLayout(false);
            this.cardInformation.PerformLayout();
            this.paymentType.ResumeLayout(false);
            this.paymentType.PerformLayout();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.CartPanel.ResumeLayout(false);
            this.MagazinePanel.ResumeLayout(false);
            this.magazinegroupBox6.ResumeLayout(false);
            this.magazinegroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.magazinegroupBox5.ResumeLayout(false);
            this.magazinegroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.magazinegroupBox4.ResumeLayout(false);
            this.magazinegroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.magazinegroupBox3.ResumeLayout(false);
            this.magazinegroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.magazinegroupBox2.ResumeLayout(false);
            this.magazinegroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.magazinegroupBox1.ResumeLayout(false);
            this.magazinegroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.bookgroupbox6.ResumeLayout(false);
            this.bookgroupbox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.bookgroupbox5.ResumeLayout(false);
            this.bookgroupbox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.bookgroupbox4.ResumeLayout(false);
            this.bookgroupbox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.bookgroupbox3.ResumeLayout(false);
            this.bookgroupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.MusicCdPanel.ResumeLayout(false);
            this.musicgroupbox6.ResumeLayout(false);
            this.musicgroupbox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.musicgroupbox5.ResumeLayout(false);
            this.musicgroupbox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.musicgroupbox4.ResumeLayout(false);
            this.musicgroupbox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.musicgroupboxx3.ResumeLayout(false);
            this.musicgroupboxx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.musicgroupbox2.ResumeLayout(false);
            this.musicgroupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.musicgroupbox1.ResumeLayout(false);
            this.musicgroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.bookgroupbox2.ResumeLayout(false);
            this.bookgroupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bookgroupbox1.ResumeLayout(false);
            this.bookgroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adlogin;
        private System.Windows.Forms.TextBox sifrelogin;
        private System.Windows.Forms.Label GirisDurumuLabel;
        private System.Windows.Forms.Label tarihlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label customerlabel;
        public System.Windows.Forms.TextBox signad;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox emailtextbox;
        public System.Windows.Forms.TextBox isimtextbox;
        public System.Windows.Forms.TextBox adrestextBox;
        internal System.Windows.Forms.TextBox signsifre;
        public System.Windows.Forms.DataGridView dataGridView1;
        private SqlDBDataSet sqlDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SqlDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private SqlDBDataSet1 sqlDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private SqlDBDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private SqlDBDataSet3 sqlDBDataSet3;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private SqlDBDataSet3TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private SqlDBDataSet4 sqlDBDataSet4;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SqlDBDataSet4TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        public System.Windows.Forms.GroupBox SignupBox;
        public System.Windows.Forms.GroupBox LoginBox;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DataSet1TableAdapters.BooksTableAdapter booksTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private SqlDBDataSet5 sqlDBDataSet5;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private SqlDBDataSet5TableAdapters.BooksTableAdapter booksTableAdapter1;
        private SqlDBDataSet5TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet1TableAdapters.BooksTableAdapter booksTableAdapter2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Panel menupanel;
        public System.Windows.Forms.Panel OrderPanel;
        public System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label total;
        public System.Windows.Forms.GroupBox cardInformation;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label49;
        public System.Windows.Forms.GroupBox paymentType;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label36;
        public System.Windows.Forms.GroupBox Information;
        public System.Windows.Forms.TextBox informationmail;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox informationaddress;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox informationname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel CartPanel;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RemoveButton;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel MagazinePanel;
        public System.Windows.Forms.GroupBox magazinegroupBox6;
        private System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Label magazinenamelbl6;
        private System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.Label magazinepricelabel6;
        public System.Windows.Forms.Label typlelabel6;
        internal System.Windows.Forms.Label issuelabel6;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        public System.Windows.Forms.GroupBox magazinegroupBox5;
        private System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Label magazinenamelbl5;
        private System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.Label magazinepricelabel5;
        public System.Windows.Forms.Label typlelabel5;
        internal System.Windows.Forms.Label issuelabel5;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        public System.Windows.Forms.GroupBox magazinegroupBox4;
        private System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Label magazinenamelbl4;
        private System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.Label magazinepricelabel4;
        public System.Windows.Forms.Label typlelabel4;
        internal System.Windows.Forms.Label issuelabel4;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        public System.Windows.Forms.GroupBox magazinegroupBox3;
        private System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Label magazinenamelbl3;
        private System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.Label magazinepricelabel3;
        public System.Windows.Forms.Label typlelabel3;
        internal System.Windows.Forms.Label issuelabel3;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        public System.Windows.Forms.GroupBox magazinegroupBox2;
        private System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Label magazinenamelbl2;
        private System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.Label magazinepricelabel2;
        public System.Windows.Forms.Label typlelabel2;
        internal System.Windows.Forms.Label issuelabel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label35;
        public System.Windows.Forms.GroupBox magazinegroupBox1;
        private System.Windows.Forms.Button buttonnn4;
        internal System.Windows.Forms.Label magazinenamelbl1;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Label magazinepricelabel1;
        public System.Windows.Forms.Label typlelabel1;
        internal System.Windows.Forms.Label issuelabel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.GroupBox bookgroupbox6;
        private System.Windows.Forms.Button button21;
        internal System.Windows.Forms.Label namelbl6;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.Label pagelbl6;
        public System.Windows.Forms.Label publisherlbl6;
        public System.Windows.Forms.Label pricelbl6;
        internal System.Windows.Forms.Label authorlbl6;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button MusicCDbutton;
        public System.Windows.Forms.GroupBox bookgroupbox5;
        private System.Windows.Forms.Button button20;
        internal System.Windows.Forms.Label namelbl5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label pagelbl5;
        public System.Windows.Forms.Label publisherlbl5;
        public System.Windows.Forms.Label pricelbl5;
        internal System.Windows.Forms.Label authorlbl5;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button BooksButton;
        public System.Windows.Forms.GroupBox bookgroupbox4;
        private System.Windows.Forms.Button button19;
        internal System.Windows.Forms.Label namelbl4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label pagelbl4;
        public System.Windows.Forms.Label publisherlbl4;
        public System.Windows.Forms.Label pricelbl4;
        internal System.Windows.Forms.Label authorlbl4;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button MagazineButton;
        public System.Windows.Forms.GroupBox bookgroupbox3;
        private System.Windows.Forms.Button button18;
        internal System.Windows.Forms.Label namelbl3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label pagelbl3;
        public System.Windows.Forms.Label publisherlbl3;
        public System.Windows.Forms.Label pricelbl3;
        internal System.Windows.Forms.Label authorlbl3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel MusicCdPanel;
        public System.Windows.Forms.GroupBox musicgroupbox6;
        private System.Windows.Forms.Button button15;
        internal System.Windows.Forms.Label musicname6;
        private System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.Label musicprice6;
        public System.Windows.Forms.Label singletype6;
        internal System.Windows.Forms.Label Singerlabel6;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label45;
        public System.Windows.Forms.GroupBox musicgroupbox5;
        private System.Windows.Forms.Button button14;
        internal System.Windows.Forms.Label musicname5;
        private System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.Label musicprice5;
        public System.Windows.Forms.Label singletype5;
        internal System.Windows.Forms.Label Singerlabel5;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        public System.Windows.Forms.GroupBox musicgroupbox4;
        private System.Windows.Forms.Button button13;
        internal System.Windows.Forms.Label musicname4;
        private System.Windows.Forms.PictureBox pictureBox15;
        public System.Windows.Forms.Label musicprice4;
        public System.Windows.Forms.Label singletype4;
        internal System.Windows.Forms.Label Singerlabel4;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        public System.Windows.Forms.GroupBox musicgroupboxx3;
        private System.Windows.Forms.Button button12;
        internal System.Windows.Forms.Label musicname3;
        private System.Windows.Forms.PictureBox pictureBox16;
        public System.Windows.Forms.Label musicprice3;
        public System.Windows.Forms.Label singletype3;
        internal System.Windows.Forms.Label Singerlabel3;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        public System.Windows.Forms.GroupBox musicgroupbox2;
        private System.Windows.Forms.Button button11;
        internal System.Windows.Forms.Label musicname2;
        private System.Windows.Forms.PictureBox pictureBox17;
        public System.Windows.Forms.Label musicprice2;
        public System.Windows.Forms.Label singletype2;
        internal System.Windows.Forms.Label Singerlabel2;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        public System.Windows.Forms.GroupBox musicgroupbox1;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label musicname1;
        private System.Windows.Forms.PictureBox pictureBox18;
        public System.Windows.Forms.Label musicprice1;
        public System.Windows.Forms.Label singletype1;
        internal System.Windows.Forms.Label Singerlabel1;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label109;
        public System.Windows.Forms.GroupBox bookgroupbox2;
        private System.Windows.Forms.Button button17;
        internal System.Windows.Forms.Label namelbl2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label pagelbl2;
        public System.Windows.Forms.Label publisherlabel2;
        public System.Windows.Forms.Label pricelbl2;
        internal System.Windows.Forms.Label authorlbl2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.GroupBox bookgroupbox1;
        private System.Windows.Forms.Button button16;
        internal System.Windows.Forms.Label namelbl1;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label pagelbl1;
        public System.Windows.Forms.Label publisherlbl1;
        public System.Windows.Forms.Label pricelbl1;
        internal System.Windows.Forms.Label authorlbl1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button onaybuton;
    }
}

