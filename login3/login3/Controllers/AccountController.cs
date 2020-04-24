using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login3.Models;
using System.Data.SqlClient;

//para crear este controlador primero se agrego un controlador
namespace login3.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //crear un metodo pra la cadena de coneccion
        void connectionString() {

            con.ConnectionString = "data source=ACERE11\\SQLEXPRESS; database=WPF; integrated security = SSPI;";
        
        }

        //verificar nombre y contraseña
        [HttpPost]
        public ActionResult Verify(Account acc) {

            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from login where username = '"+acc.Name+"' and password ='"+acc.Password+"' ";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Create");

            }
            else
            {
                con.Close();
                return View("Error");

            }
            

            }
    }
    
}