using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartman_Otomasyon
{

    
    class SqlHelper
    {
        private string ConnectionString { get; set; }
        public SqlConnection Con { get; set; }

        public SqlHelper()
        {
            ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Apartman;Integrated Security=True");
            // Oluşan connection'ın yolu
            Con = new SqlConnection(ConnectionString);
            // SqlHelper her çağrıldığında yeni bir connection oluşturacak
        }
        public void ExecuteProc(string procName,params SqlParameter[] ps) 
            // Birden fazla parametre olduğu için dizide tutuluyor
        {
            SqlCommand command = new SqlCommand();
            // Sql komutu newlendi
            command.CommandType = CommandType.StoredProcedure;
            // komut tipi stored prosedüre eşitlendi
            command.CommandText = procName;
            // Komutun adı prosedür adına eşitlendi
            command.Parameters.AddRange(ps);
            // Parametreler daha önce oluşturulan diziye eklendi
            command.Connection = Con;
            // Komutun bağlantısı tanımlandı
            Con.Open();
            // bağlantı açıldı
            command.ExecuteNonQuery();
            // komut çalıştırıldı
            Con.Close();
            // bağlantı kapandı
        }
        public DataTable GetTable(string query)
        // Database'den tablo getirmek için metod oluşturulduı
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionString);
            // sda adında yeni bir data bağlantısı oluşturuldu
            DataTable dt = new DataTable();
            // Gelen datayı eşitleyebilmek için bir datatable oluşturuldu
            sda.Fill(dt);
            // çekilen data, table'a dolduruldu
            return dt;
        }
    }
}
