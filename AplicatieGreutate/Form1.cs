using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieGreutate
{
    public partial class Form1 : Form
    {
        double greutateOm;
        const float GRAVITATIE_LUNA = 0.16f;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            greutateOm = double.Parse(textBoxCalculeaza.Text.ToString());

         
            controlerAfisare.SetBounds(0, 40, 450, 20);

            Font font = new Font(FontFamily.GenericSansSerif, 12);


            string textNume = textBoxNume.Text;

            controlerAfisare.Text = $"Ma numesc  {textNume}  si am {((float)greutateOm * (float)GRAVITATIE_LUNA)} kg pe Luna ";
            panel.Controls.Add(controlerAfisare);
        }
    }
}
