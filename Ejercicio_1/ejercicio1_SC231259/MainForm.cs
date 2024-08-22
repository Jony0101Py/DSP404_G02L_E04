using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ejercicio1_SC231259
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InicializarSelectorCategorias();
            CargarInformacion();
            CargarEstadisticas("Programas de Televisión");
        }

        private void CargarInformacion()
        {
            string series = "1. Game of Thrones\n" +
                            "   - Título en español: Juego de tronos\n" +
                            "   - Creador: David Benioff\n" +
                            "   - Protagonistas: Sean Bean, Nikolaj Coster-Waldau, ...\n" +
                            "   - País de origen: Estados Unidos\n" +
                            "   - Temporadas: 8\n" +
                            "   - Episodios: 73\n" +
                            "   - Sinopsis: La trama de Game of Thrones...\n\n" +
                            "2. Chernobyl\n" +
                            "   - Título en español: Chernóbil\n" +
                            "   - Creado por: Craig Mazin\n" +
                            "   - Protagonistas: Jared Harris, Stellan Skarsgård, Emily Watson\n" +
                            "   - País de origen: Estados Unidos, Reino Unido\n" +
                            "   - Temporadas: 1\n" +
                            "   - Episodios: 5\n" +
                            "   - Sinopsis: La serie gira en torno al desastre nuclear...\n\n" +
                            "3. The Marvelous Mrs. Maisel\n" +
                            "   - Título en español: La maravillosa Señora Maisel\n" +
                            "   - Creado por: Amy Sherman-Palladino\n" +
                            "   - Protagonistas: Rachel Brosnahan, Michael Zegen, Alex Borstein...\n" +
                            "   - País de origen: Estados Unidos\n" +
                            "   - Temporadas: 3\n" +
                            "   - Episodios: 26\n" +
                            "   - Sinopsis: La serie cuenta la historia de un ama de casa...\n";
            // Datos pestaña de Series
            tabPage1.Controls.Add(new TextBox() { Text = series, Multiline = true, Dock = DockStyle.Fill });

            
            string books = "1. Harry Potter\n" +
                           "   - Autor: J. K. Rowling\n" +
                           "   - Género: Novela, Literatura fantástica\n" +
                           "   - Páginas: 3407 (ENG), 3665 (ESP)\n" +
                           "   - Protagonistas: Harry Potter, Ron Weasley, Hermione Granger...\n" +
                           "   - Argumento: La historia comienza con la celebración del mundo mágico...\n\n" +
                           "2. Goosebumps\n" +
                           "   - Autor: Robert Lawrence Stine\n" +
                           "   - Género: Ciencia ficción, literatura infantil y suspenso\n" +
                           "   - Páginas: ---\n" +
                           "   - Argumento: La serie consta de un total de 60 libros para España...\n\n" +
                           "3. Perry Mason\n" +
                           "   - Autor: Erle Stanley Gardner\n" +
                           "   - Género: Novela policiaca\n" +
                           "   - Páginas: xx\n" +
                           "   - Argumento: El personaje era un abogado que llegó a aparecer en 80 novelas...\n";
            //Datos pestaña de Libros
            tabPage2.Controls.Add(new TextBox() { Text = books, Multiline = true, Dock = DockStyle.Fill });

          
            string languages = "1. Python\n" +
                               "   - Desarrollador: Python Software Foundation\n" +
                               "   - Extensiones: .py, .pyc, .pyd, .pyo, .pyw, .pyz\n" +
                               "   - Apareció en: 1991\n" +
                               "   - Sistema operativo: Multiplataforma\n" +
                               "   - Paradigma: Multiparadigma\n" +
                               "   - Última versión estable: 3.8.3\n" +
                               "   - Licencia: Python Software Foundation License\n\n" +
                               "2. Java\n" +
                               "   - Desarrollador: James Gosling y Sun Microsystems\n" +
                               "   - Extensiones: java, class, jar, jad, jmod\n" +
                               "   - Apareció en: 1996\n" +
                               "   - Sistema operativo: Multiplataforma\n" +
                               "   - Paradigma: Orientado a objetos, imperativo\n" +
                               "   - Última versión estable: 14.01\n" +
                               "   - Licencia: GNU GPL / Java Community Process\n\n" +
                               "3. JavaScript\n" +
                               "   - Desarrollador: xx\n" +
                               "   - Extensiones: .js\n" +
                               "   - Apareció en: 1995\n" +
                               "   - Sistema operativo: xx\n" +
                               "   - Paradigma: Multiparadigma, programación funcional...\n" +
                               "   - Última versión estable: ECMAScript 2016\n";
            // Datos pestaña de Lenguajes de Programación
            tabPage3.Controls.Add(new TextBox() { Text = languages, Multiline = true, Dock = DockStyle.Fill });

        }

        private void InicializarSelectorCategorias()
        {
            
            comboBoxCategorias.Items.Add("Programas de Televisión");
            comboBoxCategorias.Items.Add("Libros");
            comboBoxCategorias.Items.Add("Lenguajes de Programación");

            // Seleccionar la primera categoría por defecto
            comboBoxCategorias.SelectedIndex = 0;

            // Manejar el evento de cambio de selección
            comboBoxCategorias.SelectedIndexChanged += ComboBoxCategorias_SelectedIndexChanged;
        }

        private void ComboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la categoría seleccionada y cargar las estadísticas
            string categoriaSeleccionada = comboBoxCategorias.SelectedItem.ToString();
            CargarEstadisticas(categoriaSeleccionada);
        }

        private void CargarEstadisticas(string categoria)
        {
            
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Configurar el área de gráfico
            ChartArea areaGrafico = new ChartArea("AreaPrincipal");
            chart1.ChartAreas.Add(areaGrafico);

            // Crear la serie de datos
            Series serie = new Series("Serie1");
            serie.ChartType = SeriesChartType.Pie; // Cambiar tipo de gráfico si es necesario

            // Configurar datos según la categoría seleccionada
            switch (categoria)
            {
                case "Programas de Televisión":
                    serie.Points.AddXY("Game of Thrones", 40);
                    serie.Points.AddXY("Chernobyl", 34);
                    serie.Points.AddXY("The Marvelous Mrs. Maisel", 26);
                    chart1.Titles.Add("Distribución de Programas de Televisión");
                    break;
                case "Libros":
                    serie.Points.AddXY("Harry Potter", 44);
                    serie.Points.AddXY("Goosebumps", 30);
                    serie.Points.AddXY("Perry Mason", 26);
                    chart1.Titles.Add("Distribución de Libros");
                    break;
                case "Lenguajes de Programación":
                    serie.Points.AddXY("Python", 47);
                    serie.Points.AddXY("Java", 38);
                    serie.Points.AddXY("JavaScript", 15);
                    chart1.Titles.Add("Distribución de Lenguajes de Programación");
                    break;
                default:
                    throw new ArgumentException("Categoría no válida");
            }

           
            chart1.Series.Add(serie);
        }

    }
}
