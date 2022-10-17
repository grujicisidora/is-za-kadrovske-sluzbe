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
    public partial class OstaliPodaciForm : Form
    {
        public OstaliPodaciForm()
        {
            InitializeComponent();
            UCOstaliPodaciPocetna str = new UCOstaliPodaciPocetna(this);
            Controls.Add(str);
        }
    }
}
