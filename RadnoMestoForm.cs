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
    public partial class RadnoMestoForm : Form
    {
        Form form;
        UserControl u;
        RadnoMesto radnoMesto;
        Organizacija organizacija;

        public RadnoMestoForm(Form form, UserControl u, RadnoMesto radnoMesto)
        {
            this.form = form;
            this.u = u;
            this.radnoMesto = radnoMesto;
            InitializeComponent();
            label1.Text = "Naziv radnog mesta: " + radnoMesto.naziv;
            opisTxt.Text = radnoMesto.opis;
            odeljenjeLbl.Visible = false;
            poslJedLbl.Visible = false;
        }

        public RadnoMestoForm(Form form, UserControl u, Organizacija organizacija)
        {
            this.form = form;
            this.u = u;
            this.organizacija = organizacija;
            InitializeComponent();
            label1.Text = "Naziv radnog mesta: " + RadSaBazomRadnoMesto.pretraziID(organizacija.idRadMesta).naziv;
            opisTxt.Text = RadSaBazomRadnoMesto.pretraziID(organizacija.idRadMesta).opis;
            odeljenjeLbl.Text = "Odeljenje: " + RadSaBazomOdeljenje.pretraziID(organizacija.idOdeljenja).nazivOdeljenja;
            PoslovnaJedinica poslJed = RadSaBazomPoslovnaJedinica.pretraziID(organizacija.idPoslJed);
            poslJedLbl.Text = "Poslovna jedinica: " + poslJed.adresa + ", " + RadSaBazomGrad.pretraziPoPtt(poslJed.ptt);
        }
    }
}
