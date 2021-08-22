using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
namespace OopFinalProject2021
{
    public class ShoppingCart
    {
        public int CustomerID;
        public static List<ItemToPurchase> itemsToPurchases = new List<ItemToPurchase>();
        
        public int itemcounter = 0;
        public string paymentType;

        public void printProducts(Form1 form) {
     

            
            for (int i = 0; i < itemsToPurchases.Count; i++)
            {
                string[] row = { itemsToPurchases[i].product.id, itemsToPurchases[i].product.name, itemsToPurchases[i].product.price};
                var satir = new ListViewItem(row);
                form.listView1.Items.Add(satir);
            }
            
        }
        public void AddProduct(ItemToPurchase item) {

            itemsToPurchases.Add(item);
            itemcounter++;

        }
        public void RemoveProduct(ItemToPurchase item , string x,Form1 form) {

            for (int i = 0; i < itemsToPurchases.Count; i++)
            {
                if (itemsToPurchases[i].product.id == x)
                {
                    item = itemsToPurchases[i];
                }
            }
            itemsToPurchases.Remove(item);
            form.listView1.SelectedItems[0].Remove();
            itemcounter--;
        }
        public void PlaceOrder(Form1 form, Customer cstmr) 
        {
            double total = 0;
            form.informationname.Text = cstmr.Name;
            form.informationaddress.Text = cstmr.Adress;
            form.informationmail.Text = cstmr.Email;

            for (int i = 0; i < itemsToPurchases.Count; i++)
            {
                total+= Convert.ToDouble(itemsToPurchases[i].product.price);
            }
            form.totallbl.Text = total.ToString();
        }

        public void CancelOrder(Form1 form) {
                itemsToPurchases.Clear();
            form.listView1.Items.Clear();
            
        }

        public void SendInvoicebyEmail(Form1 form) 
        {

            MailMessage mail = new MailMessage();

            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("ebkaya.0637@gmail.com","Burak06**");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mail.Subject = "Online Store Invoice";
            mail.Body = "Online Store'dan alışveriş yaptığınız için teşekkür ederiz. " + form.totallbl.Text + " değerindeki ürünleriniz işleme alınmıştır, en yakın zaman kargoya verilecektir. İyi günler dileriz..";
            mail.To.Add(form.informationmail.Text);
            mail.From=new MailAddress("ebkaya.0637@gmail.com");
            istemci.Send(mail);
            
                
        }



    }
}
