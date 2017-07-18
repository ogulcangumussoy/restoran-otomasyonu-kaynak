using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class cAdisyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private int _Durum;
        private int _MasaId; 
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
        public int ServisTurNo
        {
            get
            {
                return _ServisTurNo;
            }
            set
            {
                _ServisTurNo = value;
            }
        }
        public decimal Tutar
        {
            get
            {
                return _Tutar;
            }
            set
            {
                _Tutar = value;
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
        public int Durum
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
        public int MasaId
        {
            get
            {
                return _MasaId;
            }
            set
            {
                _MasaId = value;
            }
        } 
        #endregion
        public int getByAddition(int MasaId)
        {
            gnl.bagac();
            SqlCommand cmd = new SqlCommand("Select top 1 ID From Adisyonlar Where MASAID=@MasaId Order By ID desc", gnl.bagac());
            cmd.Parameters.Add("@MasaId",SqlDbType.BigInt).Value= MasaId;
            MasaId = Convert.ToInt32(cmd.ExecuteScalar());        
            gnl.bag.Dispose();
            gnl.bagkapat();       
            return MasaId;
        }
    }
}
