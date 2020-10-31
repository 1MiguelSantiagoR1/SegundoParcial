using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasy.Interfaces;

namespace FirstFantasy.Classes.Equipment
{
    class Clothes : IDescribable
    {
        private string atuendo;
        private int proteccion;
        private int durabilidad;
        public string Atuendo { get => atuendo; set => atuendo = value; }
        public int Durabilidad { get => durabilidad; set => durabilidad = value; }
        public int Proteccion { get => proteccion; set => proteccion = value; }

        public string ShowCharacter()
        {
            return "Outfit: " + Atuendo;
        }
        public string ShowInformation()
        {
            return "\n" + Atuendo +":"+" Protection: +" + Proteccion + " Durability: " + Durabilidad;

        }
    }
}
