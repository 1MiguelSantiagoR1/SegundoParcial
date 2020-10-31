using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using FirstFantasy.Classes.Equipment.Shop;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int indice;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            String option = CboxCharacter.Text;
            Character myCharacter;
            Weapon equipamiento;
            Clothes accesorios;
            

            if (option == "Wizard")
            {
                Wizzard.Visibility = (Visibility.Visible);
            }
            else
            {
                Wizzard.Visibility = (Visibility.Hidden);
            }
            if (option == "Vampire")
            {
                vampiree.Visibility = (Visibility.Visible);
            }
            else
            {
                vampiree.Visibility = (Visibility.Hidden);
            }
            if (option == "Cleric")
            {
                Clericc.Visibility = (Visibility.Visible);
            }
            else
            {
                Clericc.Visibility = (Visibility.Hidden);
            }
            if (option == "Fighter")
            {
                Fighterr.Visibility = (Visibility.Visible);
            }
            else
            {
                Fighterr.Visibility = (Visibility.Hidden);
            }

            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric();
                    equipamiento = new Stick();
                    myCharacter.Name = "Slade";
                    myCharacter.Experience = 0;
                    myCharacter.Level = 1;
                    equipamiento.Arma = "Merlin´s Stick";
                    equipamiento.Daño = 10;
                    equipamiento.Durabilidad = 150;
                    accesorios = new Capa();
                    accesorios.Atuendo = "Agility cape";
                    accesorios.Proteccion = 2;
                    accesorios.Durabilidad = 300;
                    break;

                case "Fighter":
                    myCharacter = new Fighter();
                    equipamiento = new Sword();
                    myCharacter.Name = "Arturo";
                    myCharacter.Experience = 0;
                    myCharacter.Level = 1;
                    equipamiento.Arma = "King´s Sword";
                    equipamiento.Daño = 20;
                    equipamiento.Durabilidad = 30;
                    accesorios = new Armadura();
                    accesorios.Atuendo = "Futuristic armor";
                    accesorios.Proteccion = 18;
                    accesorios.Durabilidad = 30;
                    break;

                case "Vampire":
                    myCharacter = new Vampire();
                    equipamiento = new Axe();
                    myCharacter.Name = "Vladimir";
                    myCharacter.Experience = 0;
                    myCharacter.Level = 1;
                    equipamiento.Arma = "The sanguinary";
                    equipamiento.Daño = 15;
                    equipamiento.Durabilidad = 100;
                    accesorios = new Botas();
                    accesorios.Atuendo = "Dracula´s Boots";
                    accesorios.Proteccion = 3;
                    accesorios.Durabilidad = 170;
                    break;

                case "Wizard":
                    myCharacter = new Wizard();
                    equipamiento = new Book();

                    myCharacter.Name = "Ryze";
                    myCharacter.Experience = 0;
                    myCharacter.Level = 1;
                    equipamiento.Arma = "Book of Destiny";
                    equipamiento.Daño = 20;
                    equipamiento.Durabilidad = 50;
                    accesorios = new Sombrero();
                    accesorios.Atuendo = "Magician Hat";
                    accesorios.Proteccion = 6;
                    accesorios.Durabilidad = 100;
                    break;

                default:
                    myCharacter = null;
                    equipamiento = null;
                    accesorios = null;
                    MessageBox.Show("Debes selecionar una clase");
                    break;
            }

            if (myCharacter != null && equipamiento != null && accesorios != null)
            {
                TxtOutput.Text = "";
                TxtOutput.Text += myCharacter.ShowCharacter();
                TxtOutput2.Text = equipamiento.ShowCharacter() + "\n";
                TxtOutput3.Text = equipamiento.ShowInformation();
                TxtOutput2.Text += accesorios.ShowCharacter() + "\n";
                TxtOutput3.Text += accesorios.ShowInformation() + "\n";
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TxtOutput3.Visibility = (Visibility.Visible);
            Label_items.Visibility = (Visibility.Visible);
            Rectangle_Items.Visibility = (Visibility.Visible);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String option = CboxCharacter.Text;
            if (TxtOutput.Text == "")
            {
                MessageBox.Show("Please create the character first");
            }
            else
            {
                switch (option)
                {
                    case "Cleric":
                        FileManager.WriteFileCleric("Custom Cleric : " + "\n" + "Information ---------- " + "\n" + TxtOutput.Text + "\n" + "Inventory ----------  " + "\n" + TxtOutput2.Text);
                        break;
                    case "Fighter":
                        FileManager.WriteFileFighter("Custom Fighter : " + "\n" + "Information ---------- " + "\n" + TxtOutput.Text + "\n" + "Inventory ----------  " + "\n" + TxtOutput2.Text);
                        break;
                    case "Vampire":
                        FileManager.WriteFileVampire("Custom Vampire : " + "\n" + "Information ---------- " + "\n" + TxtOutput.Text + "\n" + "Inventory ----------  " + "\n" + TxtOutput2.Text);
                        break;
                    case "Wizard":
                        FileManager.WriteFileWizard("Custom Wizard : " + "\n" + "Information ---------- " + "\n" + TxtOutput.Text + "\n" + "Inventory ----------  " + "\n" + TxtOutput2.Text);
                        break;
                }

                MessageBox.Show("Personaje guardado con Exito!");
            }


        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            Items_Shop shop;
            shop = new Items_Shop();
            ListBoxShop.Visibility = (Visibility.Visible);
            ListBoxShop.Items.Add("Health Potion");
            ListBoxShop.Items.Add("Infinity Edge");
            ListBoxShop.Items.Add("Dragon Scroll");
            ListBoxShop.Items.Add("Ice Axe");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Items_Shop objetos;
            if (ListBoxShop.SelectedItem.ToString() == "Ice Axe")
            {
                objetos = new Ice_Axe();
                objetos.Item = "Ice Axe";
                objetos.Daño = 10;
                objetos.Curacion = 30;
                objetos.Durabilidad = 20;
                TxtOutput2.Text += objetos.ShowCharacter() + "\n";
                TxtOutput3.Text += objetos.ShowInformation() + "\n";
            }

            if (ListBoxShop.SelectedItem.ToString() == "Infinity Edge")
            {
                objetos = new Infinity_Edge();
                objetos.Item = "Infinity Edge";
                objetos.Daño = 40;
                objetos.Curacion = 0;
                objetos.Durabilidad = 50;
                TxtOutput2.Text += objetos.ShowCharacter() + "\n";
                TxtOutput3.Text += objetos.ShowInformation() + "\n";
            }

            if (ListBoxShop.SelectedItem.ToString() == "Health Potion")
            {
                objetos = new Health_Potion();
                objetos.Item = "Health Potion";
                objetos.Daño = 0;
                objetos.Curacion = 70;
                objetos.Durabilidad = 1;
                TxtOutput2.Text += objetos.ShowCharacter() + "\n";
                TxtOutput3.Text += objetos.ShowInformation() + "\n";
            }

            if (ListBoxShop.SelectedItem.ToString() == "Dragon Scroll")
            {
                objetos = new Dragon_Scroll();
                objetos.Item = "Dragon Scroll";
                objetos.Daño = 0;
                objetos.Curacion = 50;
                objetos.Durabilidad = 5;
                TxtOutput2.Text += objetos.ShowCharacter() + "\n";
                TxtOutput3.Text += objetos.ShowInformation() + "\n";
            }
        }

        private void attackbutton_Click(object sender, RoutedEventArgs e)
        {
            String option = CboxCharacter.Text;
            if (option == "" || TxtOutput.Text == "")
            {
                MessageBox.Show("Please select and create a Character");
            }
            else
            {
                switch (option)
                {
                    case "Cleric":
                        int damage = 12;
                        Random rnd = new Random();
                        for (int i = 0; i < 1; i++)
                        {
                            int ynum = rnd.Next(1, 8);
                            attackbox.Text = "TAKE THIS!!! :" + "\n" + "Base Damage: " + damage + "Weapon damage: " + ynum;
                        }
                        break;
                    case "Fighter":
                        int damage1 = 10;
                        Random rnd1 = new Random();
                        for (int i = 0; i < 1; i++)
                        {
                            int ynum = rnd1.Next(1, 8);
                            attackbox.Text = "FOR MY LORD!!! :" + "\n" + " Base Damage: " + damage1 + "Weapon damage: " + ynum;
                        }
                        break;
                    case "Vampire":
                        int damage2 = 8;
                        Random rnd2 = new Random();
                        for (int i = 0; i < 1; i++)
                        {
                            int ynum = rnd2.Next(1, 8);
                            attackbox.Text = "I WILL KILL YOU!!! :" + "\n" + " Base Damage: " + damage2 + "Weapon damage: " + ynum;
                        }
                        break;
                    case "Wizard":
                        int damage3 = 5;
                        Random rnd3 = new Random();
                        for (int i = 0; i < 1; i++)
                        {
                            int ynum = rnd3.Next(1, 8);
                            attackbox.Text = "WOSHHHH DIEEE!!! :" + "\n" + " Base Damage: " + damage3 + "Weapon damage: " + ynum;
                        }
                        break;
                }
            }
            
        }
    }
}
