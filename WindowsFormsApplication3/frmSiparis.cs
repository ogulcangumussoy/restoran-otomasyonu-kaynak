using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication3
{
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {

        }
        private void btnIcecekler_Click(object sender, EventArgs e)
        {

        }
        //Hesap İşlemleri
        void islem(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btn11":
                    txtAdet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtAdet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtAdet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtAdet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtAdet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtAdet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtAdet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtAdet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtAdet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtAdet.Text += (0).ToString();
                    break;
                default:
                    MessageBox.Show("Sayi Gir");
                    break;
            }
        }   
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = cGenel._ButtonValue;
            cMasalar ms = new cMasalar();
            int tableId= ms.TableGetbyNumber(cGenel._ButtonName);
            if (ms.TableGetbyState(tableId, 2) == true || ms.TableGetbyState(tableId,4)== true)
            {
                cAdisyon Ad = new cAdisyon();
                int AdditionId = Ad.getByAddition(tableId);
                cSiparis orders = new cSiparis();
                orders.getByOrder(lvSiparisler,AdditionId);
            }
            btn11.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
        }
        cUrunCesitleri Uc = new cUrunCesitleri();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }
        private void lblMasaNo_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click_2(object sender, EventArgs e)
        {

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
        private void btnAdet_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden Emin Misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnIptal_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
        
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click_1(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_3(object sender, EventArgs e)
        {

        }
        private void btn2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {

        }
        private void btn9_Click(object sender, EventArgs e)
        {

        }
        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            txtAdet.Clear();
        }
        private void btnTatlilar_Click(object sender, EventArgs e)
        {

        }
        private void btnFastFood_Click(object sender, EventArgs e)
        {

        }
        private void btnCorba_Click(object sender, EventArgs e)
        {

        }
        private void btnAnaYemek3_Click(object sender, EventArgs e)
        {
          
            Uc.getByProductTypes(lvMenu, btnAnaYemek3);
        }
        private void btnIcecekler8_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnIcecekler8);
        }
        private void btnTatlilar7_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnTatlilar7);
        }
        private void btnSalata6_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnSalata6);
        }
        private void btnFastFood5_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnFastFood5);
        }
        private void btnCorba1_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnCorba1);
        }
        private void btnMakarna4_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnMakarna4);
        }
        private void btnAraSicak2_Click(object sender, EventArgs e)
        {
            Uc.getByProductTypes(lvMenu, btnAraSicak2);
        }
        int sayac = 0; int sayac_2 = 0;
        private void lvMenu_DoubleClick(object sender, EventArgs e)
        {
            if(txtAdet.Text=="")
            {
                txtAdet.Text = "1";
            }
            if(lvMenu.Items.Count >0)
            {
               
                lvSiparisler.Items.Add(lvMenu.SelectedItems[0].Text);   // ürün adı
                lvSiparisler.Items[sayac].SubItems.Add(txtAdet.Text);           
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvMenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(txtAdet.Text)).ToString());           
                sayac++;                
            }
        }
        private void btnSiparis_Click(object sender, EventArgs e)
        {

        }
    }
}
