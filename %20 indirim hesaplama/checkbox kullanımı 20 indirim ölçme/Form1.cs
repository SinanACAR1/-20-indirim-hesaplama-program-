using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tutar, toplam;
                tutar = Convert.ToInt32(textBox1.Text);
                if (checkBox1.Checked == true)
                {
                    toplam = tutar - (tutar * 0.2);
                }
                else
                {
                    toplam = tutar;
                }
                label2.Text = toplam.ToString();
            }
            catch
            {
                MessageBox.Show("lütfen boş alanı doldurunuz","HATA!!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
           }


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

       


    }
}
