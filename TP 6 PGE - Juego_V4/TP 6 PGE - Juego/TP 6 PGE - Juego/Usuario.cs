using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_6_PGE___Juego
{
    class Usuario
    {
        string Nombre;
        int Edad, MaxScore;

        string FilePath;

        bool file;
        Form3 User = new Form3();

        public Usuario()
        { 
            FilePath = Path.Combine(Directory.GetCurrentDirectory(), "usuario.txt");
            checkFile();
        }

        public int MaxScore1
        {
            set
            {
                if (value > MaxScore)
                {
                    MaxScore = value;
                }
            }
            get => MaxScore;
        }
        public int Edad1
        {
            get => Edad;
        }
        public string Nombre1
        {
            get => Nombre;
        }
        private void checkFile()
        {
            if (File.Exists(FilePath))
            {
                file = true;
                ReadFile();
            }
            else
            {
                file = false;
                WriteFile();
            }
        }

        public void WriteFile()
        {
            if (file) {
                try
                {
                    using (StreamWriter sw = File.CreateText(FilePath))
                    {
                        sw.Write("Nombre: " + Nombre + "\nEdad: " + Edad + "\nPuntuacion Maxima: " + MaxScore);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error --> ", ex);
                }
            }
            else
            {
                try
                {
                    User.ShowDialog();
                    Nombre = User.Nombre;
                    Edad = User.Edad;
                    MaxScore = 0;
                    using (StreamWriter sw = File.CreateText(FilePath))
                    {
                        sw.Write("Nombre: " + Nombre + "\nEdad: " + Edad + "\nPuntuacion Maxima: " + MaxScore);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error --> ", ex);
                }
            }
            
            
            
        }

        public void ReadFile() {
            if (file)
            {
                List<string> lines = File.ReadAllLines(FilePath).ToList();
                string[] nombre = lines[0].Split(':');
                string[] edad = lines[1].Split(':');
                string [] score = lines[2].Split(':');

                Nombre = nombre[1].Trim();
                Edad = Convert.ToInt32(edad[1].Trim());
                MaxScore = Convert.ToInt32(score[1].Trim());
            }
            
        }

        public void Editar()
        {
            try
            {
                User.ShowDialog();
                Nombre = User.Nombre;
                Edad = User.Edad;
                MaxScore = 0;
                using (StreamWriter sw = File.CreateText(FilePath))
                {
                    sw.Write("Nombre: " + Nombre + "\nEdad: " + Edad + "\nPuntuacion Maxima: " + MaxScore);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error --> ", ex);
            }
        }

    }
}
