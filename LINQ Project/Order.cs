using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<Order>GetOrders()
        {
            List<Order> liste = new List<Order>();
            string sorgu = @"select o.CustomerID,o.EmployeeID,o.OrderID,o.OrderDate,
            (select ContactName from Customers where CustomerID = o.CustomerID) as ContactName
            from Orders o"; // Order ve Customer classlarındaki table'lar için sql sorugusu
            DataTable dt = GetDataTable(sorgu); // Sorgu için oluşturulan bağlantı metodu
            foreach (DataRow item in dt.Rows)
            // dt'deki satırları düzgün bir sırayla aktarabilmek için foreach kullanıldı
            {
                Order o = new Order(); // Order Class o instance'landı
                o.OrderID = (int)item["OrderID"]; // veri int tipinde olduğu için int'e castlandı
                o.CustomerID = (string)item["CustomerID"]; // Veri string'e castlandı
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderDate = (DateTime)item["OrderDate"]; // Veri Datetime'a castlandı
                o.Customer = new Customer(); // Customer'daki verileri doldurabilmek için yeni bir instance
                o.Customer.ContactName = (string)item["ContactName"];
                o.Customer.CustomerID = (string)item["CustomerID"];

                liste.Add(o); // Her bir satır için verileri Liste'ye ekledi
            }
            return liste;
        }

        private DataTable GetDataTable(string sorgu)
        {
            string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
            // Project/Add New Data source/Database/Dataset/Show the Connection --> metni buradan kopyaladık
            SqlDataAdapter sda = new SqlDataAdapter(sorgu,cs); // Database üzerindeki işlemler için kullanılan komut
            DataTable dt = new DataTable(); // Dataları aktarabileceğimiz bir DataTable oluşturuldu
            sda.Fill(dt); // Sda ile çekilen veriler Oluşturulan dt ye dolduruldu
            return dt;

        }
    }
    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount 
        {
            get {return Orders.Count; }
        }
    }

}
