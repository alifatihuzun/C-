using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlDb = new SqlServerDb();
            sqlDb.ExecuteSql("");

            var oracleDb = new OracleDb();
            oracleDb.ExecuteSql("");
            oracleDb.GetDbVersion();

            var laptop = new Laptop();
            laptop.Carry();
            laptop.Insert();

            var desktop = new Desktop();
            desktop.Insert();


        }
    }
}
