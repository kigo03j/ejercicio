using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(Txt1.Text);
            int num2 = Convert.ToInt32(Txt2.Text);
            int resultado = num1 + num1;
            TxtResult.Text= resultado.ToString();   
        }
    }
}
