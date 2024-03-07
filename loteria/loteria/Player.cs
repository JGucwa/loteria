using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace loteria
{
    public class Player
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public Player(int id, string firstname, string surname, string email, string code)
        {
            Id = id;
            Firstname = firstname;
            Surname = surname;
            Email = email;
            Code = code;
        }
        public Player(string firstname, string surname, string email, string code)
        {

            Firstname = firstname;
            Surname = surname;
            Email = email;
            Code = code;
        }
        public Player()
        {


        }
    }
}
