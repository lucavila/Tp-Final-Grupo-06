using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_Final_Grupo_06.Models;

namespace TP_Final_Grupo_06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Lista = BD.Obtener_Todos_Usuarios();
            return View();
        }

        public ActionResult MostrarLocales()
        {
            List<Local> lista = BD.Obtener_Todos_Locales();
            ViewBag.ListaLocales = lista;
            return View();
        }

        public ActionResult Algo()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    


    public ActionResult Login()
    {
        return View();
    }

        [HttpPost]
        public ActionResult Login(Usuario unUsuario)
        {
            if (unUsuario.usuario is null || unUsuario.contraseña is null)
            {
                ViewBag.resultado = "Se debe ingresar usuario y contraseña";
                return View("Login");
            }
            else
            {
                ViewBag.resultado = BD.LogIn(unUsuario);
                if (ViewBag.resultado == "error")
                {
                    ViewBag.resultado = "El usuario o contraseña son incorrectos";
                    return View("Login");
                }
                else
                {
                    Session["NombreUsuario"] = unUsuario.usuario;
                    Session["Contraseña"] = unUsuario.contraseña;
                    return View("Index");
                }
            }
        }

        [HttpPost]
        public ActionResult Busqueda(Local a)
        {
            if (a.nombre_local is null)
            {
                ViewBag.resultado = "Se debe ingresar un local";
                return View("Index");
            }
            else
            {
                ViewBag.resultado = BD.Buscar_local_por_nombre(a);
                if (ViewBag.resultado == "error")
                {
                    ViewBag.resultado = "El local no existe";
                    return View("Index");
                }
                else
                {
                    a = BD.Traer_Local_por_nombre(a);
                    ViewBag.id_local = a.id_local;
                    return View("Local");
                }
            }

        }

        public ActionResult Registrarse()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Registrarse(Usuario nuevoUsuario)
    {
        if (nuevoUsuario.usuario is null || nuevoUsuario.contraseña is null)
        {
            ViewBag.resultado = "Se debe ingresar usuario y contraseña";
            return View("Registrarse");
        }
        else
        {
            Usuario nuevoUsuario2 = new Usuario();
            nuevoUsuario2.usuario = nuevoUsuario.usuario;
            nuevoUsuario2.contraseña = nuevoUsuario.contraseña;
            int resultado = BD.CrearUsuario(nuevoUsuario2);
            if (resultado == 0)
            {
                ViewBag.resultado = "Este nombre de usuario ya esta siendo utilizado";
                return View("Registrarse");
            }
            else
            {
                return View("Index");
            }
        }

    }

        public ActionResult Local(int id_local)
        {
            ViewBag.id_local = id_local;
            Local UnLocal = new Local();
            UnLocal = BD.Buscar_Local_Por_Id(id_local);
            ViewBag.Local = UnLocal;
            return View();
        }

        public ActionResult AñadirLocal()
        {
            return View();
        }



    }

}
