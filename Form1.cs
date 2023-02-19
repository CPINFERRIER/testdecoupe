using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            // Ouvrir le fichier en lecture
            StreamReader fichier = new StreamReader(textBox1.Text);

            // Lire une ligne de texte depuis le fichier
            string ligne = fichier.ReadLine();

            // Découper la ligne en utilisant la méthode Split
            string[] param = ligne.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Écrire le premier mot dans le label
            textBox2.Text = param[0];
            
            // Afficher la valeur du premier mot dans une boîte de dialogue
            MessageBox.Show("Le premier mot est : " + textBox2.Text);
            
            // Fermer le fichier
            fichier.Close();

        }

    }
}
