using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama; 
        #endregion
        #region Properties
        public int UrunTurNo
        {
            get
            {
                return _UrunTurNo;
            }
            set
            {
                _UrunTurNo = value;
            }
        }
        public string KategoriAd
        {
            get
            {
                return _KategoriAd;
            }
            set
            {
                _KategoriAd = value;
            }
        }
        public string Aciklama
        {
            get
            {
                return _Aciklama;
            }
            set
            {
                _Aciklama = value;
            }
        } 
        #endregion
        public void getByProductTypes(ListView Cesitler,Button btn)
        {
            Cesitler.Items.Clear();
            gnl.bagac();
            SqlCommand comm = new SqlCommand("Select URUNAD,urunler.ID From kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID where urunler.KATEGORIID= @KATEGORIID",gnl.bagac());
            string aa = btn.Name;
            int uzunluk = aa.Length;
            comm.Parameters.Add("@KATEGORIID", SqlDbType.BigInt).Value = aa.Substring(uzunluk - 1, 1);   
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNAD"].ToString());               
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            gnl.bag.Dispose();
            gnl.bagkapat();
        }
    }
}
