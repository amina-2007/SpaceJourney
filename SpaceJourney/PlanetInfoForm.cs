using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceJourney
{
    public partial class PlanetInfoForm : Form
    {
        public PlanetInfoForm(Planet planet, List<Order> orders)
        {
            InitializeComponent();
            LoadPlanetInfo(planet); 
            PersonalizeColors(planet.PlanetName);
           
            OrderByPlanet(planet.PlanetName, orders);



        }

        private void PlanetInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderByPlanet(string pName, List<Order> orders)
        {
            int c = 0;
            dataGridPlanetInfo.Rows.Clear(); //сначала очистка потому что без нее каждый раз будут дублироваься заказы

             var sortedOrders=orders.Where(x=>x.ChosenPlanet.ToUpper()==pName.ToUpper()).ToList(); //самый второй в проекте линк-запрос, просто фильтруем по выбранной планете
             foreach (var order in sortedOrders)
             {dataGridPlanetInfo.Rows.Add(order.Name, order.Phone, order.Snils, order.RType, order.ChosenPlanet); c++;
             
            }
            if (pName == "СОЛНЦЕ")labelOrderCount.Text= "На солнце едут шашлыки!";
            else
           labelOrderCount.Text ="Заказало поездку сюда: " + c.ToString();

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
            switch (pname.ToLower())
            {
                case "меркурий":
                    dataGridPlanetInfo.BackgroundColor=Color.Sienna;
                    labelCHPlanet.ForeColor=Color.Sienna;
                    labelOrderCount.ForeColor=Color.Sienna;
                    labelFirstImage.ForeColor=Color.Sienna;
                    labelLastImage.ForeColor=Color.Sienna;
                    labelSurfaceImage.ForeColor=Color.Sienna;
                    buttonOkPonyatno.BackColor=Color.Sienna;
                    break;

                case "венера":
                    dataGridPlanetInfo.BackgroundColor = Color.SandyBrown;
                    labelCHPlanet.ForeColor = Color.SandyBrown;
                    labelOrderCount.ForeColor = Color.SandyBrown;
                    labelFirstImage.ForeColor = Color.SandyBrown;
                    labelLastImage.ForeColor = Color.SandyBrown;
                    labelSurfaceImage.ForeColor = Color.SandyBrown;
                    buttonOkPonyatno.BackColor = Color.SandyBrown;
                    break;

                case "земля":
                    dataGridPlanetInfo.BackgroundColor = Color.LimeGreen;
                    labelCHPlanet.ForeColor = Color.LimeGreen;
                    labelOrderCount.ForeColor = Color.LimeGreen;
                    labelFirstImage.ForeColor = Color.LimeGreen;
                    labelLastImage.ForeColor = Color.LimeGreen;
                    labelSurfaceImage.ForeColor = Color.LimeGreen;
                    buttonOkPonyatno.BackColor = Color.LimeGreen;
                    break;

                case "марс":
                    dataGridPlanetInfo.BackgroundColor = Color.IndianRed;
                    labelCHPlanet.ForeColor = Color.IndianRed;
                    labelOrderCount.ForeColor = Color.IndianRed;
                    labelFirstImage.ForeColor = Color.IndianRed;
                    labelLastImage.ForeColor = Color.IndianRed;
                    labelSurfaceImage.ForeColor = Color.IndianRed;
                    buttonOkPonyatno.BackColor = Color.IndianRed;
                    break;

                case "юпитер":
                    dataGridPlanetInfo.BackgroundColor = Color.BurlyWood;
                    labelCHPlanet.ForeColor = Color.BurlyWood;
                    labelOrderCount.ForeColor = Color.BurlyWood;
                    labelFirstImage.ForeColor = Color.BurlyWood;
                    labelLastImage.ForeColor = Color.BurlyWood;
                    labelSurfaceImage.ForeColor = Color.BurlyWood;
                    buttonOkPonyatno.BackColor = Color.BurlyWood;
                    break;

                case "сатурн":
                    dataGridPlanetInfo.BackgroundColor = Color.PaleGoldenrod;
                    labelCHPlanet.ForeColor = Color.PaleGoldenrod;
                    labelOrderCount.ForeColor = Color.PaleGoldenrod;
                    labelFirstImage.ForeColor = Color.PaleGoldenrod;
                    labelLastImage.ForeColor = Color.PaleGoldenrod;
                    labelSurfaceImage.ForeColor = Color.PaleGoldenrod;
                    buttonOkPonyatno.BackColor = Color.PaleGoldenrod;
                    break;

                case "уран":
                    dataGridPlanetInfo.BackgroundColor = Color.DodgerBlue;
                    labelCHPlanet.ForeColor = Color.DodgerBlue;
                    labelOrderCount.ForeColor = Color.DodgerBlue;
                    labelFirstImage.ForeColor = Color.DodgerBlue;
                    labelLastImage.ForeColor = Color.DodgerBlue;
                    labelSurfaceImage.ForeColor = Color.DodgerBlue;
                    buttonOkPonyatno.BackColor = Color.DodgerBlue;
                    break;

                case "нептун":
                    dataGridPlanetInfo.BackgroundColor = Color.Cyan;
                    labelCHPlanet.ForeColor = Color.Cyan;
                    labelOrderCount.ForeColor = Color.Cyan;
                    labelFirstImage.ForeColor = Color.Cyan;
                    labelLastImage.ForeColor = Color.Cyan;
                    labelSurfaceImage.ForeColor = Color.Cyan;
                    buttonOkPonyatno.BackColor = Color.Cyan;
                    break;

                case "солнце":
                    dataGridPlanetInfo.BackgroundColor = Color.Yellow;
                    labelCHPlanet.ForeColor = Color.Yellow;
                    labelOrderCount.ForeColor = Color.Yellow;
                    labelFirstImage.ForeColor = Color.Yellow;
                    labelLastImage.ForeColor = Color.Yellow;
                    labelSurfaceImage.ForeColor = Color.Yellow;
                    buttonOkPonyatno.BackColor = Color.Yellow;
                    break;
            }
            //switch-case
        }

        private void buttonOkPonyatno_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}
