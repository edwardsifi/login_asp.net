using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//para hacer este modelo primero se creo una clase vacia
namespace login3.Models
{
    
    //este es el modelo dela base de datos a crear las variables dentro
    //despues de crear el modelo se crea el controlador del modelo
    public class Account
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
