using Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        private TirarDados tirarDados;

        public Form1()
        {
            InitializeComponent();
            tirarDados = new TirarDados(); // Inicia la clase TirarDados
        }

        // Método que se ejecuta cuando el usuario hace clic en el botón
        private void btnLanzarDados_Click(object sender, EventArgs e)
        {
            // Realiza una tirada de dados
            (int dado1, int dado2, int suma) = tirarDados.Tirar();

            // Actualiza las etiquetas con los resultados
            lblDado.Text = $"Dado 1: {dado1}";
            lblDado2.Text = $"Dado 2: {dado2}";
            lblSuma.Text = $"Suma: {suma}";

            MostrarConteoSumas();
        }

        // Método para mostrar el conteo acumulado de las sumas
        private void MostrarConteoSumas()
        {
            int[] conteoSumas = tirarDados.ObtenerConteoSumas();

            // Limpiar el ListBox antes de mostrar los conteos actualizados
            lstConteo.Items.Clear();
            lstConteo.Items.Add("Suma\tCantidad");

            for (int i = 0; i < conteoSumas.Length; i++)
            {
                int suma = i + 2;
                int cantidad = conteoSumas[i];
                lstConteo.Items.Add($"{suma}\t{cantidad}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}