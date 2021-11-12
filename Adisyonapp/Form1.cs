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
        private void printDocument1_PrintPage(object sender,System.Drawing.Printing.PrintingPageEventArgs e)

        {
            try
            {
                Font font = new Font("Arial", 14);
                SolidBrush firca = new SolidBrush(Color.Black);

//e.Graphics.DrawString($"Tarih={DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss")}", font, firca, 50, 25);
            }
            catch (Exception)
            {

                throw;
            }

        }

        
        

        
        decimal fiyat = 0,adet =0,tutar=0;

        

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
