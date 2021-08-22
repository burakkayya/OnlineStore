using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace OopFinalProject2021
{
  public abstract class Product:Form1
    {

        SqlConnection baglanti = new SqlConnection("Data Source=SQL5063.site4now.net;Initial Catalog=db_a75733_melisaozzel;User Id=db_a75733_melisaozzel_admin;Password=asdf1234M.");

        public string name;
        public string id;
        public string price;
        void printProperties() {}
    }
}
