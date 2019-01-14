using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DövizKurlarıDataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lstBoxDoviz.Items.Clear();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rooteleman = xmldoc.DocumentElement; //tüm döküman
            XmlNodeList liste = rooteleman.GetElementsByTagName("Currency");
            List<Doviz> dlist = new List<Doviz>();
            foreach (var item in liste)
            {
                Doviz d = new Doviz();
                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;
                d.DovizAd = isim;
                string alisFiyat = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;
                string satisFiyat= currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;

                if (!string.IsNullOrEmpty(alisFiyat)) {
                    d.AlisFiyat = Convert.ToDecimal(alisFiyat);
                }
                if (!string.IsNullOrEmpty(satisFiyat))
                {
                    d.SatisFiyat = Convert.ToDecimal(satisFiyat);
                }
                if (!string.IsNullOrEmpty(birim))
                {
                    d.Birim = Convert.ToInt32(birim);
                }
                lstBoxDoviz.Items.Add(d);
                dlist.Add(d);

            }
            dataGridVievDoviz.DataSource = dlist;
            int i = 0;
            foreach (var item in dlist)
            {
                try
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = item.DovizAd;
                    dataGridView1.Rows[i].Cells[1].Value = item.SatisFiyat;
                    i++;
                }
                catch(Exception)
                {
                }
            }
        }
        private void lstBoxDoviz_SelectedINdexChanged(object sender, EventArgs e)
        {
            Doviz secilenDoviz = (Doviz)lstBoxDoviz.SelectedItem;
            lblAlıs.Text = secilenDoviz.AlisFiyat.ToString();
            lblSatis.Text = secilenDoviz.SatisFiyat.ToString();
            lblBirim.Text = secilenDoviz.Birim.ToString();
        }
    }
}
