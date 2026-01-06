using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceJourney
{
    public partial class PlanetInfoForm : Form
    {
        public PlanetInfoForm(Planet planet)
        {
            InitializeComponent();
            LoadPlanetInfo(planet); 
        }

        private void PlanetInfoForm_Load(object sender, EventArgs e)
        {

        }


        private void LoadPlanetInfo(Planet planet)
        {//ДАННЫЕ ПЕРЕдаем в форму
            labelCHPlanet.Text=planet.PlanetName;
            RTBPlanetInfo.Text=planet.PlanetInfo;
            pictureBoxFirstImage.Image = planet.FirstPlanetImage;
            pictureBoxLastImage.Image = planet.LastPlanetImage;
            pictureBoxSurface.Image=planet.PlanetSurfaceImage;
        }

        public void PersonalizeColors(string pname)
        {
            //switch-case
        }
    }
}
