using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._02._2024._1473._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if(tabControl2.SelectedIndex == 2)
            {
                decimal hesap = 0;
                string mesaj = $"çorba={nCorba.Value * 60}\r\n"+
                $"telefon:{txtTelofon.Text}\r\n" +
                $"adres:{txtAdres.Text}\r\n\r\n";

                if(nCorba.Value > 0)
                {
                    hesap += nCorba.Value*60;
                    mesaj += $"çorba={nCorba.Value * 60}\r\n";
                }

                if(nSalata.Value > 0)
                {
                    hesap += nSalata.Value * 30;
                    mesaj += $"salata={nSalata.Value * 30}\r\n";
                }

                if (nAnaYemek.Value > 0)
                {
                    hesap += nAnaYemek .Value * 100;
                    mesaj += $"anayemek={nAnaYemek .Value * 100}\r\n";
                }

                if (nTatli.Value > 0)
                {
                    hesap += nTatli.Value * 50;
                    mesaj += $"tatli={nTatli.Value * 50}\r\n";
                }

                mesaj += $"***********************\r\n";
                mesaj += $"ödeneçek tutar :{hesap}";    

                txtBilgi.Text= mesaj;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelofon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if(nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 12;
                    txtBilgi.Text += String.Format("çorba{0:c}", nCorba.Value * 12) + "\r\n";
                }

                txtBilgi.Text += "___________";

                txtBilgi.Text = String.Format("toplam{0:c}", hesap);

            }
        }
    }
}
