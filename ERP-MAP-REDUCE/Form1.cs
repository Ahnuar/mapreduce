using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ERP_MAP_REDUCE
{
    public partial class Frmain : Form
    {
        string filePath = string.Empty;

        Dictionary<char, int> letrasContadas = new Dictionary<char, int>();
        Dictionary<string, int> PalabrasContadas = new Dictionary<string, int>();


        public Frmain()
        {
            InitializeComponent();
        }

        private void btFichero_Click(object sender, EventArgs e)
        {
            if (fdFichero.ShowDialog() == DialogResult.OK)
            {
                filePath = fdFichero.FileName;
                lbFichero.Text = filePath;
            }

        }

        private void btContarPalabras_Click(object sender, EventArgs e)
        {
            if (filePath != string.Empty)
            {
                ContarPalabras();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún fichero");
            }
        }


        private void btContarletras_Click(object sender, EventArgs e)
        {
            if (filePath != string.Empty)
            {
                Contarletras();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún fichero");
            }
        }

        private void ContarPalabras()
        {
            string text = File.ReadAllText(filePath);
            string[] palabras = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            object lockObject = new object();

            Parallel.ForEach(palabras, (palabra) =>
            {
                lock (lockObject)
                {
                    if (PalabrasContadas.ContainsKey(palabra))
                    {
                        PalabrasContadas[palabra]++;
                    }
                    else
                    {
                        PalabrasContadas[palabra] = 1;
                    }
                }
            });

            imprimirPalabrasPorValor ();

        }


        private void Contarletras()
        {
            string text = File.ReadAllText(filePath);
            string letras = text.ToLower().Where(char.IsLetter).ToString();

            object lockObject = new object();

            Parallel.ForEach(letras, (letra) =>
            {
                lock (lockObject)
                {
                    if (letrasContadas.ContainsKey(letra))
                    {
                        letrasContadas[letra]++;
                    }
                    else
                    {
                        letrasContadas[letra] = 1;
                    }
                }
            });


            imprimirLetrasPorValor();
        }


        private void imprimirPalabrasPorValor()
        {
            lbPalabrasContadas.Items.Clear();
            foreach (var palabra in PalabrasContadas.OrderByDescending(x => x.Value))
            {
                lbPalabrasContadas.Items.Add(palabra.Key + "\t " + palabra.Value.ToString());

            }
        }

        
        private void imprimirLetrasPorValor() {

            lbLetrasContadas.Items.Clear();
            foreach (var letra in letrasContadas.OrderByDescending(x => x.Value))
            {
                lbLetrasContadas.Items.Add(letra.Key + "\t " + letra.Value.ToString());
            }

        }



    }
}
