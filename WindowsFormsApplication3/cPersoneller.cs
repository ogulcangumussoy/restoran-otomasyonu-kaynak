using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class cPersoneller
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private string _PersonelDurum;

        #endregion
        #region Properties
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
        public int PersonelGorevId
        {
            get
            {
                return _PersonelGorevId;
            }
            set
            {
                _PersonelGorevId = value;
            }
        }
        public string PersonelAd
        {
            get
            {
                return _PersonelAd;
            }
            set
            {
                _PersonelAd = value;
            }
        }

        public string PersonelSoyad
        {
            get
            {
                return _PersonelSoyad;
            }
            set
            {
                _PersonelSoyad = value;
            }
        }

        public string PersonelParola
        {
            get
            {
                return _PersonelParola;
            }
            set
            {
                _PersonelParola = value;
            }
        }

        public string PersonelKullaniciAdi
        {
            get
            {
                return _PersonelKullaniciAdi;
            }
            set
            {
                _PersonelKullaniciAdi = value;
            }
        }

        public string PersonelDurum
        {
            get
            {
                return _PersonelDurum;
            }
            set
            {
                _PersonelDurum = value;
            }
        }
        #endregion
        public bool personelEntryControl(string password, int userId)
        {            
            bool result = false;
            gnl.bagac();
            DataTable dt = new DataTable();
            SqlCommand sda = new SqlCommand("Select * from personeller where ID = @Id and PAROLA = @password", gnl.bagac());
            sda.Parameters.Add("@Id", SqlDbType.VarChar).Value = userId;
            sda.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            sda.ExecuteScalar();
            result = Convert.ToBoolean(sda.ExecuteScalar());
            return result;
        }
        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            gnl.bagac();
            SqlCommand mcd = new SqlCommand("Select * from personeller", gnl.bagac());
            SqlDataReader dr = mcd.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p.PersonelId = Convert.ToInt32(dr["ID"]);
                p.PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p.PersonelAd = Convert.ToString(dr["AD"]);
                p.PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p.PersonelParola = Convert.ToString(dr["PAROLA"]);
                p.PersonelKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                p.PersonelDurum = Convert.ToString(dr["DURUM"]);
                cb.Items.Add(p);
            }
            dr.Close();
            gnl.bagkapat();
        }
        public override string ToString()
        {
            return PersonelAd + " " + PersonelSoyad;
        }
    }
}
