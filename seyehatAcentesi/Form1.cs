using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace seyehatAcentesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            grbKb.Enabled = true;
            int araKoltuk = 3, bosHazırlanacaklaricinEklenenler = 0, koridoricinHazırlananKoltuklarHaric = 0;

            for (int i = 1; i<=54+bosHazırlanacaklaricinEklenenler; i++)
            {
                Button btn= new Button();
                btn.Width = 37;
                btn.Margin=new Padding(all:1);
                if (i == araKoltuk)
                {
                    btn.Height = 0;

                    bosHazırlanacaklaricinEklenenler++;
                    araKoltuk +=5;
                }
                else
                {
                    btn.Height=37;
                    koridoricinHazırlananKoltuklarHaric++;
                    btn.Text=
                        koridoricinHazırlananKoltuklarHaric.ToString();
                    btn.Tag = koridoricinHazırlananKoltuklarHaric;
                    btn.Click += btn_Click;

                }
                btn.BackgroundImageLayout= ImageLayout.Stretch;
                flwPanel.Controls.Add(btn);

            }  
            Label lbl=new Label();
            lbl.Width = 77;
            lbl.Height = 37;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.BackColor = Color.Cornsilk;
            lbl.Margin= new Padding(39,1,0,0);
            lbl.Text = "KAPI";
            lbl.TextAlign=ContentAlignment.MiddleLeft;
            flwPanel.Controls.Add(lbl);
        
        }

       

        Button secilenButonHafizadaTut;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            grbKb.Enabled = true;
            btnSayı.Text=btn.Tag.ToString();
            secilenButonHafizadaTut = btn;
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string boslar=string.Empty;
            foreach(var item in grbKb.Controls)
            {
                if(item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        boslar += txt.Tag + "";
                    }
                }
            }
            if(!string.IsNullOrEmpty(boslar))
            {
                MessageBox.Show(boslar,"Şu Nesneleri Boş Bıraktınız",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string cinsiyet = rdbErkek.Checked ? rdbErkek.Text : rdbKadın.Text;
            bool isKoltuk= true;
            for(int i = 0;i<flwPanel.Controls.Count;i++)
            {
                if (flwPanel.Controls[i] is Button)
                {
                    Button btn = flwPanel.Controls[i] as Button;
                    if (Convert.ToInt16(secilenButonHafizadaTut.Tag)%2==0 )
                    {
                        if (btn.Text==(Convert.ToInt16(secilenButonHafizadaTut.Tag)-1).ToString())
                        {
                            if (!(btn.Tag.GetType().Name=="Int32"))
                            {
                                if (btn.Tag != cinsiyet)
                                {
                                    isKoltuk = false;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (btn.Text==(Convert.ToInt16(secilenButonHafizadaTut.Tag)+1).ToString()) ;
                    }
                }
            }
            
            if(isKoltuk)
            {
                

                string veriler = $"{lblKNo.Text} nolu  Koltuk : {lblAd.Text}{lblSoyad.Text}  {cinsiyet} Tel No: {lblTelefon.Text}";

                lboxSatilanKoltuklar.Items.Add(veriler);

                secilenButonHafizadaTut.BackColor = rdbErkek.Checked ?

                    Color.Azure : Color.LightPink;

                
                grbKb.Enabled = false;
                secilenButonHafizadaTut.Tag = cinsiyet;


                cinsiyet = rdbErkek.Checked ? "C:\\Users\\ASUS\\OneDrive\\Masaüstü\\Fatih Hoca Tüm Notları\\seyehatAcentesi\\seyehatAcentesi\\Images\\man.png" : "C:\\Users\\ASUS\\OneDrive\\Masaüstü\\Fatih Hoca Tüm Notları\\seyehatAcentesi\\seyehatAcentesi\\App.config";
                secilenButonHafizadaTut.BackgroundImage = Image.FromFile(cinsiyet);
                MessageBox.Show("İşlem Başarılı");

            }
            else
            {
                MessageBox.Show("Alamazsın");
            }



        }
    }
}
