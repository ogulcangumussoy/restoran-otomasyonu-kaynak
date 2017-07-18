using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class cGenel
    {
        public static string conString = "Server=.;Database=restoran_db;Trusted_Connection=true";
        public SqlConnection bag;
        public SqlConnection bagac()
        {
            bag = new SqlConnection(conString);
            try
            {
                if (bag.State == ConnectionState.Closed)
                    bag.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            return bag;
        }
        public void bagkapat()
        {
            bag.Close();
            

        }
        
        

        public static int  _personelId;
        public static int _gorevId;

        public static string _ButtonValue;
        public static string _ButtonName;
    }
}



