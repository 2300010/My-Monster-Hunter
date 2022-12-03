using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonsterHunterDLL;

namespace My_Monster_Hunter
{
    public partial class frmMainMenu : Form
    {
        //Declare object
        Maps myMaps = new Maps();

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //Show all maps available
            cmbMaps.Items.Add(myMaps.maps[0]);
            cmbMaps.Items.Add(myMaps.maps[1]);
            cmbMaps.Items.Add(myMaps.maps[2]);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Quit application
            this.Close();
        }
    }
}
