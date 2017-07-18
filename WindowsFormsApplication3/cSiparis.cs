using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class cSiparis
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _Id;
        private int _adisyonID;
        private int _urunId;
        private int _adet;
        private int _masaId; 
        #endregion
        #region Properties
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        public int AdisyonID
        {
            get
            {
                return _adisyonID;
            }
            set
            {
                _adisyonID = value;
            }
        }
        public int UrunId
        {
            get
            {
                return _urunId;
            }
            set
            {
                _urunId = value;
            }
        }
        public int Adet
        {
            get
            {
                return _adet;
            }
            set
            {
                _adet = value;
            }
        }
        public int MasaId
        {
            get
            {
                return _masaId;
            }

            set
            {
                _masaId = value;
            }
        } 
        #endregion
        // Siparişleri Getir.
        public void getByOrder(ListView lv,int AdisyonId)
        {
            gnl.bagac();
            SqlCommand cmd= new SqlCommand("Select URUNAD,FIYAT,Satislar.ID,Satislar.URUNID,satislar.ADET from satislar Inner Join urunler on Satislar.URUNID=Urunler.ID Where ADISYONID=@AdisyonId", gnl.bagac());
            SqlDataReader dr = null;
            cmd.Parameters.Add("@AdisyonId",SqlDbType.BigInt).Value= AdisyonId;               
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["URUNAD"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["ADET"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["URUNID"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["FIYAT"]) * Convert.ToDecimal(dr["ADET"])));
                    lv.Items[sayac].SubItems.Add(dr["ID"].ToString());
                    sayac++;
                }
        }
    }
}
