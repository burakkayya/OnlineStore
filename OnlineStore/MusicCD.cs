using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OopFinalProject2021
{
  public class MusicCD:Product
    {
        SqlConnection baglanti = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75733_melisaozzel;User Id=db_a75733_melisaozzel_admin;Password=asdf1234M.");
        public string singer;
        public string type;  
       
        public  void printProperties(Form1 form) 
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From dbo.MusicCD where ID like '" + musiccdcounter + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                musicCDs[musiccdcounter].id = read["ID"].ToString();
                musicCDs[musiccdcounter].name = read["Name"].ToString();
                musicCDs[musiccdcounter].type = read["Type"].ToString();
                musicCDs[musiccdcounter].singer = read["Singer"].ToString();
                musicCDs[musiccdcounter].price = read["Price"].ToString();
            }
            baglanti.Close();
            
            form.musicname1.Text = musicCDs[1].name;
            form.Singerlabel1.Text = musicCDs[1].singer;
            form.singletype1.Text = musicCDs[1].type;
            form.musicprice1.Text = musicCDs[1].price;

            form.musicname2.Text = musicCDs[2].name;
            form.Singerlabel2.Text = musicCDs[2].singer;
            form.singletype2.Text = musicCDs[2].type;
            form.musicprice2.Text = musicCDs[2].price;

            form.musicname3.Text = musicCDs[3].name;
            form.Singerlabel3.Text = musicCDs[3].singer;
            form.singletype3.Text = musicCDs[3].type;
            form.musicprice3.Text = musicCDs[3].price;

            form.musicname4.Text = musicCDs[4].name;
            form.Singerlabel4.Text = musicCDs[4].singer;
            form.singletype4.Text = musicCDs[4].type;
            form.musicprice4.Text = musicCDs[4].price;

            form.musicname5.Text = musicCDs[5].name;
            form.Singerlabel5.Text = musicCDs[5].singer;
            form.singletype5.Text = musicCDs[5].type;
            form.musicprice5.Text = musicCDs[5].price;

            form.musicname6.Text = musicCDs[6].name;
            form.Singerlabel6.Text = musicCDs[6].singer;
            form.singletype6.Text = musicCDs[6].type;
            form.musicprice6.Text = musicCDs[6].price;

        }

    }
}
