using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Caso03.Models;

namespace Caso03.Data
{
    public class ConexionMySqlDbContext : DbContext{
        //Constructor
        public ConexionMySqlDbContext(DbContextOptions 
            <ConexionMySqlDbContext> options ): base(options) 
        {
               //Constructor vacio
        }
        public DbSet<Categorias> Categorias {get; set;}
    }
}
