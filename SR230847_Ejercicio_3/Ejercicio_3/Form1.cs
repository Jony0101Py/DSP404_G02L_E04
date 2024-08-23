using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;



namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasCompletadas = new List<Tarea>();
        
        public Form1()
        {
            InitializeComponent();

            //Vamos a inicializar las opciones para ordenar
            cmbOrdenarPor.Items.Add("Nombre");
            cmbOrdenarPor.Items.Add("Fecha Límite");
            cmbOrdenarPor.SelectedIndex = 0; // Establecer valor por defecto

            // Inicializar opciones de filtrar por
            cmbFiltrarPor.Items.Add("Todas");
            cmbFiltrarPor.Items.Add("Próximas 7 Días");
            cmbFiltrarPor.SelectedIndex = 0;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txttarea.Text;
            DateTime? fechaLimite = dtplimite.Value;

            if (string.IsNullOrEmpty(nombre) || !fechaLimite.HasValue)
            {
                MessageBox.Show("Por favor, ingrese un nombre de tarea y una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!fechaLimite.HasValue)
            {
                MessageBox.Show("Por favor, ingrese una fecha límite válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nombre.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El nombre de la tarea solo puede contener letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tarea tarea = new Tarea { Nombre = nombre, FechaLimite = fechaLimite.Value };
            tareasPendientes.Add(tarea);
            ActualizarListasTareas();
            txttarea.Clear();
            dtplimite.Value = DateTime.Now;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = (string)Listado.SelectedItem;
            if (textoSeleccionado != null)
            {
                Tarea tareaSeleccionada = tareasPendientes.FirstOrDefault(t => $"{t.Nombre} - {t.FechaLimite.ToShortDateString()}" == textoSeleccionado);
                if (tareaSeleccionada != null)
                {
                    tareasPendientes.Remove(tareaSeleccionada);
                    ActualizarListasTareas();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = (string)Listado.SelectedItem;
            if (textoSeleccionado != null)
            {
                Tarea tareaSeleccionada = tareasPendientes.FirstOrDefault(t => $"{t.Nombre} - {t.FechaLimite.ToShortDateString()}" == textoSeleccionado);
                if (tareaSeleccionada != null)
                {
                    txttarea.Text = tareaSeleccionada.Nombre;
                    dtplimite.Value = tareaSeleccionada.FechaLimite;
                    tareasPendientes.Remove(tareaSeleccionada);
                    ActualizarListasTareas();
                }
            }
        }

        private void btnCompletada_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = (string)Listado.SelectedItem;
            if (textoSeleccionado != null)
            {
                Tarea tareaSeleccionada = tareasPendientes.FirstOrDefault(t => $"{t.Nombre} - {t.FechaLimite.ToShortDateString()}" == textoSeleccionado);
                if (tareaSeleccionada != null)
                {
                    tareaSeleccionada.Completada = true;
                    tareasPendientes.Remove(tareaSeleccionada);
                    tareasCompletadas.Add(tareaSeleccionada);
                    ActualizarListasTareas();
                }
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            string textoSeleccionado = (string)TareaCompletada.SelectedItem;
            if (textoSeleccionado != null)
            {
                Tarea tareaSeleccionada = tareasCompletadas.FirstOrDefault(t => $"{t.Nombre} - {t.FechaLimite.ToShortDateString()}" == textoSeleccionado);
                if (tareaSeleccionada != null)
                {
                    tareaSeleccionada.Completada = false;
                    tareasCompletadas.Remove(tareaSeleccionada);
                    tareasPendientes.Add(tareaSeleccionada);
                    ActualizarListasTareas();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ActualizarListasTareas()
        {
            var ordenarPor = cmbOrdenarPor.SelectedItem?.ToString() ?? "Nombre";
            var filtrarPor = cmbFiltrarPor.SelectedItem?.ToString() ?? "Todas";

            var tareasPendientesFiltradas = tareasPendientes.AsEnumerable();

            if (filtrarPor == "Próximas 7 Días")
            {
                DateTime hoy = DateTime.Now;
                DateTime limite = hoy.AddDays(7);
                tareasPendientesFiltradas = tareasPendientesFiltradas.Where(t => t.FechaLimite >= hoy && t.FechaLimite <= limite);
            }

            // Ordenar tareas
            if (ordenarPor == "Nombre")
            {
                tareasPendientesFiltradas = tareasPendientesFiltradas.OrderBy(t => t.Nombre);
            }
            else if (ordenarPor == "Fecha Límite")
            {
                tareasPendientesFiltradas = tareasPendientesFiltradas.OrderBy(t => t.FechaLimite);
            }

            // Actualiza las tareas pendientes
            Listado.Items.Clear();
            foreach (var tarea in tareasPendientes)
            {
                Listado.Items.Add($"{tarea.Nombre} - {tarea.FechaLimite.ToShortDateString()}");
            }
        
            // Actualiza las tareas completadas
            TareaCompletada.Items.Clear();
            foreach (var tarea in tareasCompletadas)
            {
                TareaCompletada.Items.Add($"{tarea.Nombre} - {tarea.FechaLimite.ToShortDateString()}");
            }
        }

        private void cmbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrarPor.SelectedIndex != null)
            {
                ActualizarListasTareas();
            }
        }

        private void cmbOrdenarPor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbOrdenarPor.SelectedIndex != null)
            {
                ActualizarListasTareas();
            }
        }
    }

    public class Tarea
    {
        public string Nombre { get; set; }
        public DateTime FechaLimite { get; set; }
        public bool Completada { get; set; }
    }
}