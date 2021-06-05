using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Caso03.Controllers{
    public class CategoriasController : Controller{

        //Método para devolver la vista Categorias
        public IActionResult Index(){
            return View(); //Retorna una vista llamada Categorias
        }

    }
}