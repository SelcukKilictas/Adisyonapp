using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Adisyonapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnYazdır_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }
        

        
        

        
        decimal fiyat = 0,adet =0,tutar=0;

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);
                Pen kalem = new Pen(Color.Black);

                e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss")}", font, firca, 50, 25);

                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("Tanımlı Ürün", font, firca, 350, 75);
                e.Graphics.DrawLine(kalem,50, 70, 780, 70);
                e.Graphics.DrawLine(kalem,50, 110, 780, 110);
                e.Graphics.DrawLine(kalem,50, 70, 50, 110);
                e.Graphics.DrawLine(kalem,780, 70, 780, 110);

                e.Graphics.DrawString("**************************", font, firca, 285, 115);

                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("Ürün Adı", font, firca, 60, 150);
                e.Graphics.DrawString("Fiyatı", font, firca, 60, 200);
                e.Graphics.DrawString("Adedi", font, firca, 60, 250);
                e.Graphics.DrawString("Tutarı", font, firca, 60, 300);

                font = new Font("Arial", 20, FontStyle.Bold);
                e.Graphics.DrawString("**************************", font, firca, 285, 340);

                font = new Font("Arial", 15, FontStyle.Bold);
                e.Graphics.DrawString("Açıklama", font, firca, 60, 370);

                e.Graphics.DrawLine(kalem, 50, 140, 780, 140);
                e.Graphics.DrawLine(kalem, 50, 330, 50, 140);
                e.Graphics.DrawLine(kalem, 50, 330, 780, 330);
                e.Graphics.DrawLine(kalem, 780, 140, 780, 330);

                font = new Font("Arial", 15);
                e.Graphics.DrawString(textBox4.Text, font, firca, 200, 150);
                e.Graphics.DrawString($"{fiyat.ToString("0,00")}₺", font, firca, 200, 200);
                e.Graphics.DrawString($"{adet.ToString()}", font, firca, 200, 250);
                e.Graphics.DrawString($"{tutar.ToString("0.00")}₺", font, firca, 200, 300);

                font = new Font("Arial", 14);
                e.Graphics.DrawString(txtAciklama.Text, font, firca, 60, 420);

                e.Graphics.DrawLine(kalem, 50, 360, 780, 360);
                e.Graphics.DrawLine(kalem, 50, 360, 50, 1120);
                e.Graphics.DrawLine(kalem, 50, 1120, 780, 1120);
                e.Graphics.DrawLine(kalem, 780, 1120, 780, 360);

                



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lblUrunAdi_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fiyat = decimal.Parse(textBox3.Text);
                adet = decimal.Parse(textBox2.Text);
                tutar = adet * fiyat;
                textBox1.Text = tutar.ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }

     
    }
}
