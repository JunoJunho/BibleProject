using BibleProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BibleProject.ViewModel
{
    public class BibleViewModel
    {
        public ObservableCollection<BibleItem> BibleList
        {
            get;
            set;
        }

        public void InitializeBible()
        {
            string connStr = "Data Source =192.168.1.71;Database=korHRV;User Id=root;Password=root";
            string query = "select * from bible_korhrv";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            ObservableCollection<BibleItem> bibleList = new ObservableCollection<BibleItem>();
            
            try
            {
                while (reader.Read())
                {
                    bibleList.Add(new Model.BibleItem(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            BibleList = bibleList;
            conn.Close();
        }
    }
}
