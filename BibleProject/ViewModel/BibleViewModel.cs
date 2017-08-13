using BibleProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.IO;

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
            Dictionary<int, String> chapDict = readChapterInfo();
            ObservableCollection<BibleItem> bibleList = new ObservableCollection<BibleItem>();

            readFromDB(ref bibleList, ref chapDict);

            BibleList = bibleList;
        }

        private void readFromDB(ref ObservableCollection<BibleItem> bibleList, ref Dictionary<int, String> chapDict)
        {
            string connStr = "Data Source =127.0.0.1;Database=korHRV;User Id=root;Password=root";
            string query = "select * from bible_korhrv";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Connection = conn;
            conn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    int bookNum = reader.GetInt32(0);
                    string bookName = chapDict[bookNum];
                    bibleList.Add(new Model.BibleItem(bookName, reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            conn.Close();
        }

        private void readFromFile()
        {

        }

        private Dictionary<int, String> readChapterInfo()
        {
            string fileName = "book_name.txt";
            string[] lines = System.IO.File.ReadAllLines(fileName);
            Dictionary<int, String> chapDict = new Dictionary<int, string>();
            foreach(string line in lines)
            {
                string[] tokens = line.Split();
                chapDict.Add(int.Parse(tokens[0]), tokens[1]);
            } // Chapter 정보 확인

            return chapDict;
        }
    }
}
