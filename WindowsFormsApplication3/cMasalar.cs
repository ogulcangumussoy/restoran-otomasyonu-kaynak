using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Data.SqlClient;

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
            gnl.bagac();           
            SqlCommand cmd = new SqlCommand("Select durum from Masalar where Id=@TableId and DURUM=@state", gnl.bagac());
            cmd.Parameters.Add("@TableId", SqlDbType.BigInt).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.BigInt).Value = State;           
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            gnl.bagkapat();          
            return result;
        }
        public string SessionSum(int State)
        {
            string dt = "";
            gnl.bagac();
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaId From adisyonlar Right Join masalar on adisyonlar.MasaId=masalar.ID where masalar.DURUM=@durum and adisyonlar.Durum=0",gnl.bagac());
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.BigInt).Value = State;
            try
            {   
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                gnl.bag.Dispose();
                gnl.bagkapat();
            }
            return dt;
        }
    }
}
