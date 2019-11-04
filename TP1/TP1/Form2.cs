using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class ChargerXML : Form
    {
        public ChargerXML()
        {
            InitializeComponent();
        }

        private void ChargerXML_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ButtonNouvelleListe_Click(object sender, EventArgs e)
        {
            ManipulationBaseDonnees.InitialiseListeDuStagiaire();
        }
    }
}
