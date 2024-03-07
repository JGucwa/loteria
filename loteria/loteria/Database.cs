using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace loteria
{
    public class Database
    {
        private readonly SQLiteConnection polaczenie;
        public Database(string sciezka)
        {
            polaczenie = new SQLiteConnection(sciezka);
            polaczenie.CreateTable<Player>();
            polaczenie.CreateTable<Result>();
        }
        public int Zapisz<T>(T obiekt)
        {
            return polaczenie.Insert(obiekt);
        }
        public List<T> Wypisz<T>() where T : new()
        {
            return polaczenie.Table<T>().ToList();
        }
    }
}
