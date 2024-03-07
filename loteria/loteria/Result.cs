using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace loteria
{
    public class Result
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public DateTime LoteryDate { get; set; }
        public string WonNumbers { get; set; }
        public int WonCount { get; set; }

        public Result() { }
        public Result(int id, DateTime loteryDate, string wonNumbers, int wonCount)
        {
            Id = id;
            LoteryDate = loteryDate;
            WonNumbers = wonNumbers;
            WonCount = wonCount;
        }
        public Result(DateTime loteryDate, string wonNumbers, int wonCount)
        {
            LoteryDate = loteryDate;
            WonNumbers = wonNumbers;
            WonCount = wonCount;
        }
    }
}
