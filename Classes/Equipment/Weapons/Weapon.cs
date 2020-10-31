using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        private string arma;
        private int daño;
        private int durabilidad;


        public string Arma { get => arma; set => arma = value; }
        public int Daño { get => daño; set => daño = value; }
        public int Durabilidad { get => durabilidad; set => durabilidad = value; }

        public string ShowCharacter()
        {
            return "Weapon: " + Arma;
        }

        public string ShowInformation()
        {
            return  Arma + " Damage: "+ Daño + " Durability: " + Durabilidad ;
        }
    }
}
