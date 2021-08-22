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
namespace OopFinalProject2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        public static Customer[] customers = Customer.instance_();
        public static Book[] books = new Book[10];
        public static Magazine[] magazines= new Magazine[10];
        public static MusicCD[] musicCDs = new MusicCD[10];
        public static ShoppingCart[] carts = new ShoppingCart[20];

        public static int counter = 10;
        public static int bookcounter = 1;
        public static int magazinecounter = 1;
        public static int musiccdcounter = 1;
        public static int CustomerIndex;
        public string kullanıcıadı;
        SqlConnection baglanti = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75733_melisaozzel;User Id=db_a75733_melisaozzel_admin;Password=asdf1234M.");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sqlDBDataSet5.Books' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.booksTableAdapter1.Fill(this.sqlDBDataSet5.Books);
          
            // TODO: Bu kod satırı 'sqlDBDataSet4.PRODUCT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pRODUCTTableAdapter.Fill(this.sqlDBDataSet4.PRODUCT);
            // TODO: Bu kod satırı 'sqlDBDataSet3.Customers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.customersTableAdapter1.Fill(this.sqlDBDataSet3.Customers);
            // TODO: Bu kod satırı 'sqlDBDataSet1.Customer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from dbo.Customers where KullanıcıAdı like '" + adlogin.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            int i = 0;
            while (read.Read())
            {
                customers[i].username = read["KullanıcıAdı"].ToString();
                customers[i].password = read["Şifre"].ToString();
                customers[i].Name = read["İsim"].ToString();
                customers[i].Email = read["Email"].ToString();
                customers[i].Adress = read["Adres"].ToString();
                customers[i].CustomerID = Convert.ToInt32(read["CustomerID"]);
                i++;
            }
            baglanti.Close();

            for (i = 0; i <= 9; i++)
            {
                 books[i] = new Book();
                magazines[i] = new Magazine();
                musicCDs[i] = new MusicCD();
            }
            for (i = 0; i <= 9; i++)
            {
                carts[i] = new ShoppingCart();
               
            }
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("ID", 150);
            listView1.Columns.Add("NAME", 150);
            listView1.Columns.Add("PRICE", 150);

         

        }
        private void button1_Click(object sender, EventArgs e)
        {
            customers[counter].username = signad.Text;
            customers[counter].password = signsifre.Text;
            customers[counter].Adress = adrestextBox.Text;
            customers[counter].Email = emailtextbox.Text;
            customers[counter].Name = isimtextbox.Text;
            customers[counter].CustomerID = counter;

            customers[counter].saveCustomer();

            counter++;
            MessageBox.Show("Kayıt Başarılı!");
            SignupBox.Visible = false;
            LoginBox.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
        

            kullanıcıadı = adlogin.Text; 
         
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from dbo.Customers where KullanıcıAdı like '" +adlogin.Text + "' ", baglanti);
                SqlDataReader read = komut.ExecuteReader();
            int i=0;
            //while (read.Read())
            //{
            //        customers[i].username = read["KullanıcıAdı"].ToString();
            //        customers[i].password = read["Şifre"].ToString();
            //        customers[i].Name = read["İsim"].ToString();
            //        customers[i].Email = read["Email"].ToString();
            //        customers[i].Adress = read["Adres"].ToString();
            //        customers[i].CustomerID = Convert.ToInt32(read["CustomerID"]);
            //    i++;
            //}
            while (read.Read())
                {
                    if ( adlogin.Text== read["KullanıcıAdı"].ToString()  && sifrelogin.Text == read["Şifre"].ToString())
                    {
                    for (i = 0; i < customers.Length; i++)
                    {
                        if(customers[i].username == read["KullanıcıAdı"].ToString() && customers[i].password== read["Şifre"].ToString())
                        {
                            CustomerIndex = i;
                        }
                    }
                    DateTime dt = DateTime.Now;
                    int saniye = dt.Second;
                    int dakika = dt.Minute;
                    int saat = dt.Hour;
                    int gun = dt.Day;
                    int ay = dt.Month;
                    int yil = dt.Year;
                    MessageBox.Show("Giriş Başarılı");
                    menupanel.Visible = true;
                    // musicgroupbox3.Visible = true;
                    SignupBox.Visible = false;
                    LoginBox.Visible = false;
                    dataGridView1.Visible = false;
                    button4.Visible = false;
                    //Products.Visible = false;
                    for (i = 0; i < customers.Length; i++)
                    {
                        if(customers[i].username==adlogin.Text && customers[i].password == sifrelogin.Text)
                        {
                            CustomerIndex = i;
                        }

                    }
                    break;
                    }

                    else
                    MessageBox.Show("Giriş Başarısız");
               
                }


            baglanti.Close();

            //if (customers[i].username == adlogin.Text && customers[i].password == sifrelogin.Text)
            //{
            //    GirisDurumuLabel.Text = "Giris Basarılı..";
            //    tarihlabel.Text = gun.ToString() + "/" + ay.ToString() + "/" + yil.ToString() + "  " + saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString();
            //    CustomerIndex = i;

            //    break;
            //}


            //else
            //{
            //    GirisDurumuLabel.Text = "Giris Basarısız";
            //}







        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            //verilerigoruntule();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //verilerigoruntule2();

            customers[counter].printCustomerDetails();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adlogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void MusicCDbutton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
            listView1.Visible = false;
            MusicCdPanel.Visible = true;
            musicgroupbox1.Visible = true;
            musicgroupbox2.Visible = true;
            musicgroupboxx3.Visible = true;
            musicgroupbox4.Visible = true;
            musicgroupbox5.Visible = true;
            musicgroupbox6.Visible = true;

            bookgroupbox1.Visible = false;
            bookgroupbox2.Visible = false;
            bookgroupbox3.Visible = false;
            bookgroupbox4.Visible = false;
            bookgroupbox5.Visible = false;
            bookgroupbox6.Visible = false;

            MagazinePanel.Visible = false;
            magazinegroupBox1.Visible = false;
            magazinegroupBox2.Visible = false;
            magazinegroupBox3.Visible = false;
            magazinegroupBox4.Visible = false;
            magazinegroupBox5.Visible = false;
            magazinegroupBox6.Visible = false;


            for (int i = 1; i <= 6; i++)
            {

                musicCDs[i].printProperties(this);
                musiccdcounter++;
            }

        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
            listView1.Visible = false;

            bookgroupbox1.Visible = true;
            bookgroupbox2.Visible = true;
            bookgroupbox3.Visible = true;
            bookgroupbox4.Visible = true;
            bookgroupbox5.Visible = true;
            bookgroupbox6.Visible = true;


            MagazinePanel.Visible = false;
            magazinegroupBox1.Visible = false;
            magazinegroupBox2.Visible = false;
            magazinegroupBox3.Visible = false;
            magazinegroupBox4.Visible = false;
            magazinegroupBox5.Visible = false;
            magazinegroupBox6.Visible = false;
            MusicCdPanel.Visible = false;

            musicgroupbox1.Visible = false;
            musicgroupbox2.Visible = false;
            musicgroupboxx3.Visible = false;
            musicgroupbox4.Visible = false;
            musicgroupbox5.Visible = false;
            musicgroupbox6.Visible = false;

           

            for (int i = 1; i <= 6; i++)
            {

                books[i].printProperties(this);
                bookcounter++;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void booksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageLabel_Click(object sender, EventArgs e)
        {

        }

        private void imgPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void booksDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void bookgroupbox6_Enter(object sender, EventArgs e)
        {

        }

        private void MagazineButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
            listView1.Visible = false;
            bookgroupbox1.Visible = false;
            bookgroupbox2.Visible = false;
            bookgroupbox3.Visible = false;
            bookgroupbox4.Visible = false;
            bookgroupbox5.Visible = false;
            bookgroupbox6.Visible = false;

            musicgroupbox1.Visible = false;
            musicgroupbox2.Visible = false;
            musicgroupboxx3.Visible = false;
            musicgroupbox4.Visible = false;
            musicgroupbox5.Visible = false;
            musicgroupbox6.Visible = false;


            MagazinePanel.Visible = true;
            magazinegroupBox1.Visible = true;
            magazinegroupBox2.Visible = true;
            magazinegroupBox3.Visible = true;
            magazinegroupBox4.Visible = true;
            magazinegroupBox5.Visible = true;
            magazinegroupBox6.Visible = true;

            for (int i = 1; i <= 6; i++)
            {

                magazines[i].printProperties(this);
                magazinecounter++;
            }
        }

        private void publisherlbl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void magazinegroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void buttonnn4_Click(object sender, EventArgs e)
        {
            Magazine product = new Magazine();
            product.id = "1";
            product.name = magazinenamelbl1.Text;
            product.issue = issuelabel1.Text;
            product.price = magazinepricelabel1.Text;

            product.type = typlelabel1.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Magazine product = new Magazine();
            product.id = "2";
            product.name = magazinenamelbl2.Text;
            product.issue = issuelabel2.Text;
            product.price = magazinepricelabel2.Text;

            product.type = typlelabel2.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Magazine product = new Magazine();

            product.id = "3";
            product.name = magazinenamelbl3.Text;
            product.issue = issuelabel3.Text;
            product.price = magazinepricelabel3.Text;

            product.type = typlelabel3.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Magazine product = new Magazine();

            product.id = "4";
            product.name = magazinenamelbl4.Text;
            product.issue = issuelabel4.Text;
            product.price = magazinepricelabel4.Text;

            product.type = typlelabel4.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Magazine product = new Magazine();

            product.id = "5";
            product.name = magazinenamelbl5.Text;
            product.issue = issuelabel5.Text;
            product.price = magazinepricelabel5.Text;

            product.type = typlelabel5.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Magazine product = new Magazine();

            product.id = "6";
            product.name = magazinenamelbl6.Text;
            product.issue = issuelabel6.Text;
            product.price = magazinepricelabel6.Text;
            product.type = typlelabel6.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            MagazinePanel.Visible = false;
            CartPanel.Visible = true;
            listView1.Visible = true;
            carts[CustomerIndex].printProducts(this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            carts[CustomerIndex].CancelOrder(this);

            carts[CustomerIndex].printProducts(this);
            MessageBox.Show("Sipariş İptal Edildi.");


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ItemToPurchase item = new ItemToPurchase();
            carts[CustomerIndex].RemoveProduct(item,listView1.SelectedItems[0].Text,this);
        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            MusicCdPanel.Visible = false;
            MagazinePanel.Visible = false;
            CartPanel.Visible = false;
            OrderPanel.Visible = true;
            carts[CustomerIndex].PlaceOrder(this,customers[CustomerIndex]);
            listView1.Items.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Book product = new Book();

            product.id = "1";
            product.name = namelbl1.Text;
            product.price = pricelbl1.Text;
            product.author = authorlbl1.Text;
            product.publisher = publisherlbl1.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Book product = new Book();

            product.id = "2";
            product.name = namelbl2.Text;
            product.price = pricelbl2.Text;
            product.author = authorlbl2.Text;
            product.publisher = publisherlabel2.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Book product = new Book();

            product.id = "3";
            product.name = namelbl3.Text;
            product.price = pricelbl3.Text;
            product.author = authorlbl3.Text;
            product.publisher = publisherlbl3.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Book product = new Book();

            product.id = "4";
            product.name = namelbl4.Text;
            product.price = pricelbl4.Text;
            product.author = authorlbl4.Text;
            product.publisher = publisherlbl4.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Book product = new Book();

            product.id = "5";
            product.name = namelbl5.Text;
            product.price = pricelbl5.Text;
            product.author = authorlbl5.Text;
            product.publisher = publisherlbl5.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Book product = new Book();

            product.id = "6";
            product.name = namelbl6.Text;
            product.price = pricelbl6.Text;
            product.author = authorlbl6.Text;
            product.publisher = publisherlbl6.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MusicCD product = new MusicCD();

            product.id = "1";
            product.name = musicname1.Text;
            product.price = musicprice1.Text;
            product.singer = Singerlabel1.Text;
            product.type = singletype1.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MusicCD product = new MusicCD();

            product.id = "2";
            product.name = musicname2.Text;
            product.price = musicprice2.Text;
            product.singer = Singerlabel2.Text;
            product.type = singletype2.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MusicCD product = new MusicCD();

            product.id = "3";
            product.name = musicname3.Text;
            product.price = musicprice3.Text;
            product.singer = Singerlabel3.Text;
            product.type = singletype3.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MusicCD product = new MusicCD();

            product.id = "4";
            product.name = musicname4.Text;
            product.price = musicprice4.Text;
            product.singer = Singerlabel4.Text;
            product.type = singletype4.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MusicCD product = new MusicCD();

            product.id = "5";
            product.name = musicname5.Text;
            product.price = musicprice5.Text;
            product.singer = Singerlabel5.Text;
            product.type = singletype5.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MusicCD product = new MusicCD();

            product.id = "6";
            product.name = musicname6.Text;
            product.price = musicprice6.Text;
            product.singer = Singerlabel6.Text;
            product.type = singletype6.Text;
            ItemToPurchase item = new ItemToPurchase();
            item.product = product;
            item.quantity = 1;
            carts[CustomerIndex].AddProduct(item);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cardInformation.Visible = true;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginBox.Visible = false;
            SignupBox.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cardInformation.Visible = false;
        }

        private void onaybuton_Click(object sender, EventArgs e)
        {
            carts[CustomerIndex].SendInvoicebyEmail(this);
            MessageBox.Show("Siparişiniz Alınmıştır!");
            OrderPanel.Visible = false;
            CartPanel.Visible = false;


        }
    }
}
