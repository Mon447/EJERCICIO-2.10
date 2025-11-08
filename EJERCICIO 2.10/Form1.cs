using EJERCICIO_2._10;
using System;
using System.Windows.Forms;

namespace Ejecicio_2._10
{
    public partial class Form1 : Form
    {
        private ColaCircular colaCircular;

        public Form1()
        {
            InitializeComponent();
            lblMensaje.Text = "INGRESE LA CANTIDAD Y PRESIONE CREAR.";
            
            SetOperacionButtonsEnabled(false);
        }

        private void SetOperacionButtonsEnabled(bool enabled)
        {
            btnEnqueue.Enabled = enabled;
            btnDequeue.Enabled = enabled;
            btnPeek.Enabled = enabled;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCapacidad.Text, out int capacidad) || capacidad <= 0)
            {
                lblMensaje.Text = "INGRESE UNA CAPACIDAD VALIDA.";
                return;
            }

            try
            {
                colaCircular = new ColaCircular(capacidad);
                SetOperacionButtonsEnabled(true);
                txtCapacidad.Enabled = false; 
                lblMensaje.Text = $"COLA CIRCULAR CON CAPACIDAD {capacidad}. LISTA PARA ENQUEUE.";
                ActualizarInterfaz();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "ERROR: " + ex.Message;
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (colaCircular == null) return;

            if (!int.TryParse(txtValor.Text, out int valor))
            {
                lblMensaje.Text = "ERROR: INGRESE UN VALOR ENTERO.";
                return;
            }

            try
            {
                colaCircular.Enqueue(valor);
                lblMensaje.Text = $"ÉXITO: {valor} ENCOLADO CORRECTAMENTE.";
                txtValor.Clear();
                ActualizarInterfaz();
            }
            catch (InvalidOperationException ex)
            {
                lblMensaje.Text = "ERROR: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "ERROR AL ENCOLAR: " + ex.Message;
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (colaCircular == null) return;

            try
            {
                int valor = colaCircular.Dequeue();
                lblMensaje.Text = $"ÉXITO: VALOR {valor} EXTRAIDO.";
                ActualizarInterfaz();
            }
            catch (InvalidOperationException ex)
            {
                lblMensaje.Text = "ERROR: " + ex.Message; 
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "ERROR AL DESENCOLAR: " + ex.Message;
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (colaCircular == null) return;

            try
            {
                int valor = colaCircular.Peek();
                lblMensaje.Text = $"PEEK: EL VALOR AL FRENTE ES: {valor} .";
            }
            catch (InvalidOperationException ex)
            {
                lblMensaje.Text = "ERROR: " + ex.Message; 
            }
        }

        private void ActualizarInterfaz()
        {
            lbxEstado.Items.Clear();

            if (colaCircular == null)
            {
                lbxEstado.Items.Add("LA COLA NO SE HA INIIALIZADO.");
                return;
            }

            string estadoCompleto = colaCircular.MostrarEstado();

            string[] lineas = estadoCompleto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string linea in lineas)
            {
                lbxEstado.Items.Add(linea);
            }

            lblMensaje.Text += $" ELEMENTOS: {colaCircular.ContadorElementos()}";
        }
    }
}
