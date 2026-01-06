using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceJourney
{
    internal interface IOrder
    {
        string Name { get; }
        string Phone { get; }
        string Snils { get; }
        string RType { get; }
        string ChosenPlanet { get; }
    }
    internal class Order : IOrder
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Snils { get; set; }
        public string RType { get; set; }
        public string ChosenPlanet { get; set; }

        public Order(string name, string phone, string snils, string rtype, string chplanet) 
        {
        this.Name = name;
            this.Phone = phone;
            this.Snils = snils;
            this.RType = rtype;
            this.ChosenPlanet = chplanet;
        }
         
    }
}
