using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SC231259_ejercicio1.Models;

namespace SC231259_ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        // Instancia de la clase Conexion
        private Conexion conexion = new Conexion();

        // Método para cargar las listas desplegables y las ofertas
        private void CargarDatosDropDowns()
        {
            // Dropdown categorías
            categorias ct = new categorias();
            ct.Categorias = conexion.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;

            // Dropdown empresas
            Empresa emp = new Empresa();
            emp.Empresas = conexion.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;

            // Dropdown localidades
            Localidad loc = new Localidad();
            loc.Localidades = conexion.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
        }

        // GET: Home
        public ActionResult Index()
        {
            // Cargar los datos iniciales para las listas desplegables
            CargarDatosDropDowns();

            // Cargar ofertas sin filtros (valores predeterminados)
            ViewBag.Ofertas = conexion.CargarDatos();

            return View();
        }

        [HttpPost]
        public ActionResult Index(string OpcionesCat, string OpcionesLoc, string OpcionesEmp)
        {
            int dcat = Convert.ToInt32(OpcionesCat);
            int dloc = Convert.ToInt32(OpcionesLoc);
            int demp = Convert.ToInt32(OpcionesEmp);

            // Cargar las listas desplegables
            CargarDatosDropDowns();

            // Cargar ofertas con los filtros seleccionados
            ViewBag.Ofertas = conexion.CargarDatos(dcat, dloc, demp);

            return View();
        }

        [HttpPost]
        public ActionResult Nuevo()
        {
            // Cargar listas de selección para tipo de contrato, tipo de jornada y tipo de localidad
            ViewBag.TipoC = new List<SelectListItem>
            {
                new SelectListItem { Text = "Permanente", Value = "1" },
                new SelectListItem { Text = "Por Proyecto", Value = "2" }
            };

            ViewBag.TipoJ = new List<SelectListItem>
            {
                new SelectListItem { Text = "Tiempo Completo", Value = "1" },
                new SelectListItem { Text = "Por Horas", Value = "2" }
            };

            ViewBag.TipoL = new List<SelectListItem>
            {
                new SelectListItem { Text = "Área", Value = "1" },
                new SelectListItem { Text = "Proximidad", Value = "2" }
            };

            // Cargar las listas desplegables
            CargarDatosDropDowns();

            return View();
        }



        [ActionName("Editar")]
        public ActionResult Editar(string nIdOferta)
        {
            List<SelectListItem> tcontrato = new List<SelectListItem>();
            tcontrato.Add(new SelectListItem { Text = "Permanente", Value = "1" });
            tcontrato.Add(new SelectListItem { Text = "Por Proyecto", Value = "2" });
            ViewBag.TipoC = tcontrato;
            List<SelectListItem> tjornada = new List<SelectListItem>();
            tjornada.Add(new SelectListItem { Text = "Tiempo Completo", Value = "1" });
            tjornada.Add(new SelectListItem { Text = "Por Horas", Value = "2" });
            ViewBag.TipoJ = tjornada;
            List<SelectListItem> tlocalidad = new List<SelectListItem>();
            tlocalidad.Add(new SelectListItem { Text = "Area", Value = "1" });
            tlocalidad.Add(new SelectListItem { Text = "Proximidad", Value = "2" });
            ViewBag.TipoL = tlocalidad;

            //Dropdown categorias
            categorias ct = new categorias();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            return View(obj.mostrarOferta(int.Parse(nIdOferta)));
        }

        [ActionName("Actualizar")]
        public ActionResult Update(string nIdOferta, string OpcionesCat, string OpcionesLoc,
        string OpcionesEmp, string sTituloOferta, string TipoJ, string TipoC, string fSalario,
        string TipoL, string dFechaPublicacion, string dFechaContratacion,
        string sDescripcion, string nVacantes)
        {
            Conexion obj = new Conexion();
            obj.conectar();
            obj.actualizarOferta(int.Parse(nIdOferta), int.Parse(OpcionesEmp), sTituloOferta,
           int.Parse(TipoJ), int.Parse(TipoC), double.Parse(fSalario), int.Parse(OpcionesLoc), int.Parse(TipoL),
           int.Parse(OpcionesCat), sDescripcion, dFechaContratacion, int.Parse(nVacantes));
            obj.desconectar();
            int dcat, dloc, demp;
            dcat = Convert.ToInt16(OpcionesCat);
            dloc = Convert.ToInt16(OpcionesLoc);
            demp = Convert.ToInt16(OpcionesEmp);
            //Dropdown categorias
            categorias ct = new categorias();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            Datos data = new Datos();
            data.DatosOfertas = obj.CargarDatos(dcat, dloc, demp);
            ViewBag.Ofertas = data.DatosOfertas;
            return View("Index");
        }


        [ActionName("Eliminar")]
        public ActionResult Delete(string nIdOferta)
        {
            Conexion obj = new Conexion();
            obj.conectar();
            obj.EliminarDatos(int.Parse(nIdOferta));
            obj.desconectar();

            //Dropdown categorias
            categorias ct = new categorias();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            Datos data = new Datos();
            data.DatosOfertas = obj.CargarDatos();
            ViewBag.Ofertas = data.DatosOfertas;
            return View("Index");
        }

    }
}
