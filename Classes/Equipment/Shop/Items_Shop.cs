using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasy.Interfaces;

namespace FirstFantasy.Classes.Equipment.Shop
{
    class Items_Shop : IDescribable
    {
        private string item;
        private int daño;
        private int durabilidad;
        private int curacion;

        public string Item { get => item; set => item = value; }
        public int Daño { get => daño; set => daño = value; }
        public int Durabilidad { get => durabilidad; set => durabilidad = value; }
        public int Curacion { get => curacion; set => curacion = value; }

        public string ShowCharacter()
        {
            return "Item: " + Item;
        }
        public string ShowInformation()
        {
            return Item + ":" +" Damage: " + Daño + " Durability: " + Durabilidad + " Curation: " + Curacion;
        }
    }
}
