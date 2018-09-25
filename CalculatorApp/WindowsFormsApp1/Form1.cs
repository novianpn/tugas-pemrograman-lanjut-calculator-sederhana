using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hitung_Click(object sender, EventArgs e)
        {
            Double nilaiA, nilaiB, hasil;

            if (combo1.SelectedIndex == 0)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA + nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (combo1.SelectedIndex == 1)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA - nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (combo1.SelectedIndex == 2)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA * nilaiB;
                txtHasil.Text = hasil.ToString();
            }

            else if (combo1.SelectedIndex == 3)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA / nilaiB;
                txtHasil.Text = hasil.ToString();
            }
        }
    }
}
