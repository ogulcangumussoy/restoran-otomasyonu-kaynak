using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace WindowsFormsApplication3
{
    class cMasalar
    {
        #region FIELDS
        private int _ID;
        private int _KAPASITE;
        private int _SERVISTURU;
        private int _DURUM;
        private int _ONAY; 
        #endregion
        #region PROPERTIES
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public int KAPASITE
        {
            get
            {
                return _KAPASITE;
            }

            set
            {
                _KAPASITE = value;
            }
        }

        public int SERVISTURU
        {
            get
            {
                return _SERVISTURU;
            }

            set
            {
                _SERVISTURU = value;
            }
        }

        public int DURUM
        {
            get
            {
                return _DURUM;
            }

            set
            {
                _DURUM = value;
            }
        }

        public int ONAY
        {
            get
            {
                return _ONAY;
            }

            set
            {
                _ONAY = value;
            }
        }
        #endregion

        cGenel gnl = new cGenel();
        public int TableGetbyNumber (string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;
            return Convert.ToInt32(aa.Substring(length - 1, 1));
        }
        public bool TableGetbyState(int ButtonName, int State)
        {
            bool result = false;
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=itadakimasu;Uid=root;Pwd='';");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select durum from Masalar where Id=@TableId and DURUM=@state", con);

            cmd.Parameters.Add("@TableId", MySqlDbType.Int32).Value = ButtonName;
            cmd.Parameters.Add("Qstate", MySqlDbType.Int32).Value = State;
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch(MySqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            
            }
            return result;
        }
        public string SessionSum(int State)
        {
            string dt = "";
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=itadakimasu;Uid=root;Pwd='';");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select Tarih,MasaId From adisyonlar Right Join masalar on adisyonlar.MasaId=masalar.ID where masalar.DURUM=@durum and adisyonlar.Durum=0",con);
            MySqlDataReader dr = null;
            cmd.Parameters.Add("@durum", MySqlDbType.Int32).Value = State;

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch(MySqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
    }
}
