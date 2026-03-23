using Compilador1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador1
{
    public partial class Form1 : Form
    {
        ConfigManager config;
        ErrorManager errorManager;

        public Form1()
        {
            InitializeComponent();

            config = new ConfigManager();
            errorManager = new ErrorManager("Errores/errores.txt");

            CargarConfiguracion();
        }

        private void CargarConfiguracion()
        {
            lstReservadas.Items.Clear();
            lstDelimitadores.Items.Clear();

            foreach (var r in config.Reservadas)
                lstReservadas.Items.Add(r);

            foreach (var d in config.Delimitadores)
                lstDelimitadores.Items.Add(d);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            dgvTokens.Rows.Clear();
            lstErrores.Items.Clear();

            string entrada = txtEntrada.Text;

            if (string.IsNullOrWhiteSpace(entrada))
            {
                lstErrores.Items.Add(errorManager.GetError("ERR001"));
                return;
            }

            List<string> errores = new List<string>();

            Lexico lexico = new Lexico(config);

            var tokens = lexico.Analizar(entrada, errores);

            foreach (var t in tokens)
            {
                dgvTokens.Rows.Add(t.Lexema, t.Tipo);
            }

            foreach (var err in errores)
            {
                lstErrores.Items.Add(err);
            }

            lblResultado.Text = "Tokens válidos: " + tokens.Count;
        }

        private void btnAgregarReservada_Click(object sender, EventArgs e)
        {
            string nueva = txtNuevaReservada.Text.Trim();

            if (string.IsNullOrEmpty(nueva))
                return;

            if (!config.Reservadas.Contains(nueva))
            {
                config.Reservadas.Add(nueva);
                config.GuardarReservadas();
                CargarConfiguracion();
            }

            txtNuevaReservada.Clear();
        }

        private void btnEliminarReservada_Click(object sender, EventArgs e)
        {
            if (lstReservadas.SelectedItem == null)
                return;

            string seleccion = lstReservadas.SelectedItem.ToString();

            config.Reservadas.Remove(seleccion);

            config.GuardarReservadas();

            CargarConfiguracion();
        }

        private void btnAgregarDelimitador_Click(object sender, EventArgs e)
        {
            string nuevo = txtNuevoDelimitador.Text.Trim();

            if (string.IsNullOrEmpty(nuevo))
                return;

            if (!config.Delimitadores.Contains(nuevo))
            {
                config.Delimitadores.Add(nuevo);
                config.GuardarDelimitadores();
                CargarConfiguracion();
            }

            txtNuevoDelimitador.Clear();
        }

        private void btnEliminarDelimitador_Click(object sender, EventArgs e)
        {
            if (lstDelimitadores.SelectedItem == null)
                return;

            string seleccion = lstDelimitadores.SelectedItem.ToString();

            config.Delimitadores.Remove(seleccion);

            config.GuardarDelimitadores();

            CargarConfiguracion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config = new ConfigManager();
            CargarConfiguracion();
        }
    }
}
