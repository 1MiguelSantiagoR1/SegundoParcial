using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public abstract class Character : IDescribable
    {
        private string name;
        private int level;
        private int experience;

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public virtual String ShowCharacter()
        {
            return "Name: "+ name + "\n" + "Level: "+ level + "\n" + "XP: "+ experience;
        }
        public string ShowInformation()
        {
            return "The name of your Character is: " + name + "With Level: " + level + "And Experience: " + experience;
        }
    }
}
