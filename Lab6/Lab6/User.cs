using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lab6
{
    class User
    {
        public string login,password,role,main_role;

        public static string main_login { get; set; }
        public static string main_password { get; set; }
        public string Check(string Log,string Pas)
        {
            StreamReader f = new StreamReader("users.txt");
            string line;
            bool flag=false;
            string[] temp = new string[2];
            while ((line = f.ReadLine()) != null)
            {
                temp = line.Split(',');
                login = temp[0];
                password = temp[1];
                role = temp[2];
                if ((login == Log) && (password == Pas))
                {
                    flag=true;
                    main_role=role;
                    main_login =login;
                    main_password = password;
                    break;
                }
            }
            f.Close();
            if (flag ==true) return main_role;
            else return "Error";
        }

        public void Change(string new_p)
        {
            string[] database;
            string[] userbase = File.ReadAllLines("users.txt");
            for (int i=0;i<userbase.Length;i++)
            {
                string[] a = userbase[i].Split(',');
                string log = a[0];
                string pass = a[1];
                if ((log==main_login)&&(pass==main_password))
                {
                    database = userbase[i].Split(',');
                    database[1] = new_p;
                    userbase[i] = database[0] + ',' + database[1] + ',' + database[2];
                }
            }
            File.WriteAllLines("users.txt",userbase);
        }
    }
}
