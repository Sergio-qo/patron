using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron
{
    public partial class Form1 : Form
    {
        Prediccion prediccion = new Prediccion();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            
            LBLPrediccion.Text = prediccion.insertarDato(1).ToString();
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            LBLPrediccion.Text = prediccion.insertarDato(0).ToString();
        }
    }
}
