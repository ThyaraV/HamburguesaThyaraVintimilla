using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaThyaraVintimilla.Models;
using SQLite;

namespace HamburguesaThyaraVintimilla.Data
{
    public class BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Burger>();
        }
        public int AddNewBurger(Burger burger)
        {
            Init();
            //int result = conn.Insert(burger);
            //return result;
            if(burger.Id != 0)
            {
                conn.Update(burger);
                return burger.Id;
            }
            else
            {
                return conn.Insert(burger);
            }
        }
        public List<Burger> GetAllBurgers()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }
        public int DeleteItem(Burger item)
        {
            Init();
            return conn.Delete(item);
        }

       
    }
}

