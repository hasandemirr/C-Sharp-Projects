using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Otomatik_Mail_Gönderme
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
            // ConnectingString bağlantı adresi tanımlandı
            string sql = "select*from Orders where OrderDate >'5/5/1998'";
            // 1997'den sonraki tarihi alabilmek için sql sorgusu tanımlandı
            SqlDataAdapter sda = new SqlDataAdapter(sql, cs);
            // bağlantı, adres sorgu bilgileri girilerek tanımlandı
            DataTable dt = new DataTable();
            // Datatable tanımlandı
            sda.Fill(dt);
            // Datatable bağlantıdaki database ile dolduruldu

            string mailBody = "";
            // Mail içeriği için boş bir string tanımlandı

            foreach (DataRow x in dt.Rows)
            // her bir satırdaki veriyi çekebilmek için foreach kullanıldı
            {
                mailBody += x["OrderDate"] + " " + x["CustomerID"];
            }
            MailGonder(mailBody);

        }

        private static void MailGonder(string mailBody)
        // Mail gönderme işlemini tanımladığımız metod    
        {
            MailMessage ePosta = new MailMessage();
            // System.Net.Mail kütüphanesi kullanılıyor
            ePosta.From = new MailAddress("hasan.demir.0396@gmail.com");
            // ePostayı Gönderecek adress bilgileri
            ePosta.To.Add("hasan.demir.0396@gmail.com");
            // ePosta gönderilecek adres bilgileri
            ePosta.Subject = "Son Siparişler";
            // ePosta konusu
            ePosta.Body = mailBody;
            // ePosta içeriği

            SmtpClient smtp = new SmtpClient();
            // ePosta bağlantı bilgileri
            smtp.Credentials = new System.Net.NetworkCredential("hasan.demir.0396@gmail.com", "asdasd");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(ePosta);
            
        }
    }
}