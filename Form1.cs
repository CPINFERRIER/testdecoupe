using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testdecoup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
            private void button1_Click(object sender, EventArgs e)
        {
             // Crée le dossier pour enregistrer le fichier fini         
                string folderPath = textBox1.Text + "ShootOK";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine(folderPath);

                }

            string directoryPath = textBox1.Text;
            string[] files = Directory.GetFiles(directoryPath, "toconf*.txt");

            string closestFile = null;
            int closestNumber = int.MaxValue;

            foreach (string file in files)
            {
                int number = int.Parse(Path.GetFileNameWithoutExtension(file).Substring(6));
                int difference = Math.Abs(number);
                if (difference < closestNumber)
                {
                    closestFile = file;
                    closestNumber = difference;
                }
            }

            if (closestFile != null)
            {
                Console.WriteLine($"Le fichier le plus proche de 0 est {closestFile}.");
            }
            else
            {
                Console.WriteLine("Aucun fichier trouvé.");
            }

            // Ouvrir le fichier en lecture
            StreamReader fichier = new StreamReader(closestFile);

            // Lire une ligne de texte depuis le fichier
            string ligne = fichier.ReadLine();

            // Découper la ligne en utilisant la méthode Split
            string[] param = ligne.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Écrire le premier mot dans le label
            string namech = param[0];
            string RAh = param[4];
            string RAm = param[5];
            string RAs = param[6];
            string DECh = param[7];
            string DECm = param[8];
            string DECs = param[9];

            // Afficher la valeur du premier mot dans une boîte de dialogue
            //MessageBox.Show("Le premier mot est : " + textBox2.Text);

            string fileName = namech + ".txt";
            File.WriteAllText(textBox1.Text + "ShootOK/" + fileName, namech);

            // Fermer le fichier
            fichier.Close();

        }

    }
}
