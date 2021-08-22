using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OopFinalProject2021
{
    public class Magazine : Product
    {

        SqlConnection baglanti = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75733_melisaozzel;User Id=db_a75733_melisaozzel_admin;Password=asdf1234M.");
        public string issue;
        public string type;

        public void printProperties(Form1 form)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From dbo.Magazines where ID like '" + magazinecounter + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                magazines[magazinecounter].id = read["ID"].ToString();
                magazines[magazinecounter].name = read["Name"].ToString();
                magazines[magazinecounter].type = read["Type"].ToString();
                magazines[magazinecounter].issue = read["issue"].ToString();
                magazines[magazinecounter].price = read["Price"].ToString();


            }

            baglanti.Close();

            form.magazinenamelbl1.Text = magazines[1].name;
            form.issuelabel1.Text = magazines[1].issue;
            form.typlelabel1.Text = magazines[1].type;
            form.magazinepricelabel1.Text = magazines[1].price;

            form.magazinenamelbl2.Text = magazines[2].name;
            form.issuelabel2.Text = magazines[2].issue;
            form.typlelabel2.Text = magazines[2].type;
            form.magazinepricelabel2.Text = magazines[2].price;

            form.magazinenamelbl3.Text = magazines[3].name;
            form.issuelabel3.Text = magazines[3].issue;
            form.typlelabel3.Text = magazines[3].type;
            form.magazinepricelabel3.Text = magazines[3].price;

            form.magazinenamelbl4.Text = magazines[4].name;
            form.issuelabel4.Text = magazines[4].issue;
            form.typlelabel4.Text = magazines[4].type;
            form.magazinepricelabel4.Text = magazines[4].price;

            form.magazinenamelbl5.Text = magazines[5].name;
            form.issuelabel5.Text = magazines[5].issue;
            form.typlelabel5.Text = magazines[5].type;
            form.magazinepricelabel5.Text = magazines[5].price;

            form.magazinenamelbl6.Text = magazines[6].name;
            form.issuelabel6.Text = magazines[6].issue;
            form.typlelabel6.Text = magazines[6].type;
            form.magazinepricelabel6.Text = magazines[6].price;

        }
        }
 }
