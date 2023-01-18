using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaThyaraVintimilla.Models;
using SQLite;

namespace HamburguesaThyaraVintimilla.Data
{
    public class TV_BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public TV_BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<TV_Burger>();
        }
        public int AddNewBurger(TV_Burger burger)
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
        public List<TV_Burger> GetAllBurgers()
        {
            Init();
            List<TV_Burger> burgers = conn.Table<TV_Burger>().ToList();
            return burgers;
        }
        public int DeleteItem(TV_Burger item)
        {
            Init();
            return conn.Delete(item);
        }

       
    }
}

