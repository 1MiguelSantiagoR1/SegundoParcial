using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FirstFantasy.Classes.Player
{
    class FileManager
    {
        public static void WriteFileCleric(string append)
        {
            string path = @"C:\Users\Administrator\Desktop\FirstFantasy\Lista de personajes Guardados\Cleric.txt";
            File.WriteAllText(path, append);
        }
        public static void WriteFileFighter(string append)
        {
            string path = @"C:\Users\Administrator\Desktop\FirstFantasy\Lista de personajes Guardados\Fighter.txt";
            File.WriteAllText(path, append);
        }
        public static void WriteFileVampire(string append)
        {
            string path = @"C:\Users\Administrator\Desktop\FirstFantasy\Lista de personajes Guardados\Vampire.txt";
            File.WriteAllText(path, append);
        }
        public static void WriteFileWizard(string append)
        {
            string path = @"C:\Users\Administrator\Desktop\FirstFantasy\Lista de personajes Guardados\Wizard.txt";
            File.WriteAllText(path, append);
        }
    }
}

