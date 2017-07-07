using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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

            MySqlConnection con = new MySqlConnection("Server=localhost;Database=itadakimasu;Uid=root;Pwd='';");
            con.Open();
            MySqlCommand mcd = new MySqlCommand("Select * from personeller where ID=@Id and PAROLA=@password", con);
            mcd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = userId;
            mcd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(mcd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = itadakimasu; Uid = root; Pwd = ''");
            con.Open();
            MySqlCommand mcd = new MySqlCommand("Select * from personeller", con);


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlDataReader dr = mcd.ExecuteReader();

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
            con.Close();



        }
        public override string ToString()
        {
            return PersonelAd + " " + PersonelSoyad;
        }


    }
}
