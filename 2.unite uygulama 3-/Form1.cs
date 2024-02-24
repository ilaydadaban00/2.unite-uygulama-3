using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.unite_uygulama_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, karşılaştır;

            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

              if(sayi1 > sayi2)
            {
                MessageBox.Show("sayi1 büyüktür sayı 2 den");
            }
            else if(sayi1 == sayi2){
                MessageBox.Show("sayi 1 eşittir sayı 2 den");
            }
            else
            {
                MessageBox.Show("sayi 2 büyüktür sayı 1 den");
            }



        }
   
    }   
}
