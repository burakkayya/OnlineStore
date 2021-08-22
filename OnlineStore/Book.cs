using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace OopFinalProject2021
{
    public class Book : Product
    {

       
       public static SqlConnection baglanti = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75733_melisaozzel;User Id=db_a75733_melisaozzel_admin;Password=asdf1234M.");
        //public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7919PTC\\MYSQL;Initial Catalog=SqlDB;Integrated Security=True");

        public string ISBNnumber;
        public string author;
        public string publisher;
        public string page;

       
       public void printProperties(Form1 form) 
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From dbo.Books where ID like '"+ bookcounter +"' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();


            while(read.Read())
            {
                
                    books[bookcounter].name = read["Name"].ToString();
                    books[bookcounter].author = read["Author"].ToString();
                    books[bookcounter].publisher = read["Publisher"].ToString();
                    books[bookcounter].page = read["Page"].ToString();
                    books[bookcounter].price = read["Price"].ToString();

                

            }

            baglanti.Close();
            
                form.namelbl1.Text = books[1].name;
                form.authorlbl1.Text = books[1].author;
                form.publisherlbl1.Text = books[1].publisher;
                form.pagelbl1.Text = books[1].page;
                form.pricelbl1.Text = books[1].price;

            form.namelbl2.Text = books[2].name;
            form.authorlbl2.Text = books[2].author;
            form.publisherlabel2.Text = books[2].publisher;
            form.pagelbl2.Text = books[2].page;
            form.pricelbl2.Text = books[2].price;


            form.namelbl3.Text = books[3].name;
            form.authorlbl3.Text = books[3].author;
            form.publisherlbl3.Text = books[3].publisher;
            form.pagelbl3.Text = books[3].page;
            form.pricelbl3.Text = books[3].price;




            form.namelbl4.Text = books[4].name;
            form.authorlbl4.Text = books[4].author;
            form.publisherlbl4.Text = books[4].publisher;
            form.pagelbl4.Text = books[4].page;
            form.pricelbl4.Text = books[4].price;


            form.namelbl5.Text = books[5].name;
            form.authorlbl5.Text = books[5].author;
            form.publisherlbl5.Text = books[5].publisher;
            form.pagelbl5.Text = books[5].page;
            form.pricelbl5.Text = books[5].price;


            form.namelbl6.Text = books[6].name;
            form.authorlbl6.Text = books[6].author;
            form.publisherlbl6.Text = books[6].publisher;
            form.pagelbl6.Text = books[6].page;
            form.pricelbl6.Text = books[6].price;
        }

    }
}
