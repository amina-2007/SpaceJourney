using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpaceJourney
{
    internal class Planet:IPlanet
    {
      public  string PlanetName { get; set; }
        public string PlanetInfo { get; set; }
        public Image FirstPlanetImage { get; set; }
        public Image LastPlanetImage { get; set; }
        public Image PlanetSurfaceImage { get; set; }
        public double OrbitSpeed { get; set; } //не путать это вокруг солнца ниже вокруг своей оси
        public double RotateSpeed { get; set; }
        //комментарии человеческие все
        public Planet(string name, string info, double ospeed, double rspeed)
        {//зачем нужен this? он указывает именно на поля класса если  вроде принимаемые значения в конструкторе так же называются то без него может быть ошибка эээ
            this.PlanetName = name;
           this.PlanetInfo = info;
           this. OrbitSpeed = ospeed;
            this.RotateSpeed = rspeed;
        }
    }
}
