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
    public partial class UgovorForm : Form
    {
        Form form;
        UserControl u;
        Ugovor ugovor;

        public UgovorForm(Form form, UserControl u, Ugovor ugovor)
        {
            this.form = form;
            this.u = u;
            this.ugovor = ugovor;
            DateTime datum;
            DateTime.TryParse(ugovor.date, out datum);
            InitializeComponent();
            label1.Text = "Broj ugovora: " + ugovor.id.ToString();
            label2.Text = "Datum potpisivanja ugovora: " + datum.Day + "." + datum.Month + "." + datum.Year + ".";
            label3.Text = "Trajanje ugovora: " + ugovor.trajanje;
            label4.Text = "Tip ugovora: " + ugovor.tip;
            label5.Text = "Plata: " + ugovor.plata.ToString() + " dinara";
        }

    }
}
