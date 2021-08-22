using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OopFinalProject2021
{
   public class Customer:Form1
    {
      public static  SqlConnection baglanti = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75733_melisaozzel;User Id=db_a75733_melisaozzel_admin;Password=asdf1234M.");

        Form1 form = new Form1();
        public int CustomerID;
        public string Name;
        public string Adress;
        public string Email;
   
        public string username = "";
        public string password = "";
        
        private Customer()
        {}
        private static Customer[] instance = null;
        public static Customer[] instance_()
        {
            if (instance == null)
            {
                instance = new Customer[20];
                for (int i = 0; i < 20; i++)
                {
                    instance[i] = new Customer();
                    instance[i].username = "";
                    instance[i].password = "";
                }
            }
            return instance;

        }

        public   void printCustomerDetails()
        {
            baglanti.Open();
            MessageBox.Show("veri tabanı baglantısı acıldı");
            SqlCommand komut = new SqlCommand("Select *From dbo.Customers", baglanti);
            komut.ExecuteNonQuery();
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);

            DataGridView dataGridView= new DataGridView();
            dataGridView.DataSource = tablo;
            dataGridView1 = dataGridView;
            baglanti.Close();

        }
        public void saveCustomer() 
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into dbo.Customers(KullanıcıAdı,Şifre,Email,İsim,Adres,CustomerID) values ('" + customers[counter].username.ToString() + "','" + customers[counter].password.ToString() + "','" + customers[counter].Email.ToString() + "','" + customers[counter].Name.ToString() + "','" + customers[counter].Adress.ToString() + "','" + customers[counter].CustomerID + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        public void printCustomerPurchases() 
        {

            for (int i = 0; i < ShoppingCart.itemsToPurchases.Count; i++)
            {
                string[] row = { ShoppingCart.itemsToPurchases[i].product.id, ShoppingCart.itemsToPurchases[i].product.name, ShoppingCart.itemsToPurchases[i].product.price };
                var satir = new ListViewItem(row);
                form.listView1.Items.Add(satir);
            }
        }

    }
}
