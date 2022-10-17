using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    public partial class ZanimanjeForm : Form
    {
        Form form;
        UserControl u;
        Zanimanje zanimanje;

        public ZanimanjeForm(Form form, UserControl u,Zanimanje zanimanje)
        {
            this.form = form;
            this.u = u;
            this.zanimanje = zanimanje;
            InitializeComponent();
            label1.Text = "Naziv zanimanja: " + zanimanje.naziv;
            label2.Text = "Obrazovna ustanova: " + RadSaBazomObrazovnaUstanova.pretraziPoId(zanimanje.obrUstanova).nazivOU + ", " + RadSaBazomGrad.pretraziPoPtt(RadSaBazomObrazovnaUstanova.pretraziPoId(zanimanje.obrUstanova).ptt);
            label4.Text = "Stepen obrazovanja: " + RadSaBazomObrazovnaUstanova.pretraziPoId(zanimanje.obrUstanova).stepenObr;
            label3.Text = "Smer: " + zanimanje.smer;
        }
    }
}
