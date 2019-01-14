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

namespace DövizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // xml  dosyasındaki verileri bize gösterdi.
        private void btnYukle_Click(object sender, EventArgs e)
        {//data set düzgün formattaki veriyi okur.
            DataSet doviz = new DataSet();
            doviz.ReadXml("http://www.tcmb.gov.tr/kurlar/today.xml");
            dataGridDoviz.DataSource = doviz.Tables[1];
        }
    }
}
