using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace WindowsFormsApplication3
{
    class cPersonelHareketleri
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarih;
        private string _Durum; 
        #endregion
        #region Properties
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

        public int PersonelId
        {
            get
            {
                return _PersonelId;
            }

            set
            {
                _PersonelId = value;
            }
        }

        public string Islem
        {
            get
            {
                return _Islem;
            }

            set
            {
                _Islem = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _Tarih;
            }

            set
            {
                _Tarih = value;
            }
        }

        public string Durum
        {
            get
            {
                return _Durum;
            }

            set
            {
                _Durum = value;
            }
        }
        #endregion

        public bool PersonelActionSave(cPersonelHareketleri ph)
        {
            bool result = false;
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = itadakimasu; Uid = root; Pwd = ''");
            MySqlCommand mcd = new MySqlCommand("Insert Into personelhareketleri(PERSONELID,ISLEM,TARIH)Values(@personelId,@islem,@tarih)",con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                mcd.Parameters.Add("@personelId", MySqlDbType.Int16).Value = ph.PersonelId;
                mcd.Parameters.Add("@islem", MySqlDbType.VarChar).Value = ph.Islem;
                mcd.Parameters.Add("@tarih",MySqlDbType.DateTime).Value= ph.Tarih;
                result = Convert.ToBoolean(mcd.ExecuteNonQuery());
                
            }
            catch (MySqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
    }
}
