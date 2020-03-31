using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
            
        }

     

        // Formu diğer denetimlerde kullanmaı sağlayacak kodlar.

        static Baslangic _obj;

        public static Baslangic Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Baslangic();
                }
                return _obj;
            }
        }

        public Panel pnlcontainer
        {
            get { return panelcontainer; }
            set { panelcontainer = value; }
        }

        anasayfa ansf = new anasayfa();
       
        private void Baslangic_Load(object sender, EventArgs e)
        {
            _obj = this;
            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);

            odk.Hide();
            ftr.Hide();
            lokfiy.Hide();
            ayrl.Hide();
            ytl.Hide();
            ntlr.Hide();
            

            textBox1.Text=hesap.yhesap;
            textBox1.AutoSize = false;
            this.textBox1.Size = new System.Drawing.Size(249, 250);




        }

        /////////////////////////////////////////////




        rez rezerve = new rez();



        private void rezbtn_Click(object sender, EventArgs e)
        {
            rezerve.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(rezerve);
            panelcontainer.Controls["rez"].BringToFront();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();

            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();

            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();


            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        lokantafiyat lokfiy = new lokantafiyat();

        private void lokbtn_Click(object sender, EventArgs e)
        {
           
            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Show();
            panelcontainer.Controls["lokantafiyat"].BringToFront();
          

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);    
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();


            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();

            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        Musyonet msynt = new Musyonet();

        
        private void musbtn_Click(object sender, EventArgs e)
        {
            

            

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();

            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Show();
            panelcontainer.Controls["Musyonet"].BringToFront();


            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();

            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();


        }

        private void Baslangic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        notlar ntlr = new notlar();
        private void button8_Click(object sender, EventArgs e)
        {
            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
           
            panelcontainer.Controls["notlar"].BringToFront();
            panelcontainer.Controls["notlar"].Show();


            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();

            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();


            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();

            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();
        }

        odalar odlr = new odalar();

        private void button4_Click(object sender, EventArgs e)
        {

            odlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odlr);
            panelcontainer.Controls["odalar"].BringToFront();
            Baslangic.Instance.pnlcontainer.Controls["Odalar"].Show();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();

            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();


            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();

            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        Odakayit odk = new Odakayit();

        private void button3_Click(object sender, EventArgs e)
        {
            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].BringToFront();
            panelcontainer.Controls["Odakayit"].Show();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();

            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();

            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();

            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        fatura ftr = new fatura();
        private void button5_Click(object sender, EventArgs e)
        {
            ftr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["fatura"].BringToFront();
            Baslangic.Instance.pnlcontainer.Controls["fatura"].Show();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();


            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();

            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();


            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        rezarvasyon ayrl = new rezarvasyon();

        private void button6_Click(object sender, EventArgs e)
        {
            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].BringToFront();
            Baslangic.Instance.pnlcontainer.Controls["rezarvasyon"].Show();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();


            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();


            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giriş menu = new Giriş();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].BringToFront();
            Baslangic.Instance.pnlcontainer.Controls["anasayfa"].Show();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();


            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();


            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();


        }
        yetkili ytl = new yetkili();

        private void button7_Click(object sender, EventArgs e)
        {
            ytl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ytl);
            panelcontainer.Controls["yetkili"].BringToFront();
            Baslangic.Instance.pnlcontainer.Controls["yetkili"].Show();

            msynt.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(msynt);
            panelcontainer.Controls["Musyonet"].Hide();

            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(odk);
            panelcontainer.Controls["Odakayit"].Hide();


            odk.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ftr);
            panelcontainer.Controls["Fatura"].Hide();


            lokfiy.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(lokfiy);
            panelcontainer.Controls["lokantafiyat"].Hide();

            ayrl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ayrl);
            panelcontainer.Controls["rezarvasyon"].Hide();

            ansf.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ansf);
            panelcontainer.Controls["anasayfa"].Hide();

            ntlr.Dock = DockStyle.Fill;
            panelcontainer.Controls.Add(ntlr);
            panelcontainer.Controls["notlar"].Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Focus();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
