using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    class cGenel
    {
        MySqlConnection baglanti;
        // Bağlantı adında bir bağlantı oluşturduk.

        public string conString = ("Server=localhost;Database=itadakimasu;Uid=root;Pwd='';");
        

        public static int  _personelId;
        public static int _gorevId;

        public static string _ButtonValue;
        public static string _ButtonName;
    }
}



