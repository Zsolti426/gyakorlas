using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("C# and MySQL : How to Connect to MySQL Database using localhost" + Environment.NewLine);
            
            try
            {
                string connectionString = "server=localhost;port=3306;uid=adatbazis2;pwd=12345;database=adatb2;charset=utf8;SslMode=none;";
                MySqlConnection con = new MySqlConnection(connectionString);


                con.Open();

                Console.WriteLine("Connection is " + con.State.ToString() + Environment.NewLine);

                MySqlCommand com = con.CreateCommand();
