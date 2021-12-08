using Microsoft.AspNetCore.Mvc;
using MVCLAB1.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;




namespace MVCLAB1.Controllers
{

    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            using (var connect = new MySqlConnection(Secret.connection))
            {
                string sql = "select * from availmovies";

                connect.Open();

                List<Movie> availmovies = connect.Query<Movie>(sql).ToList();

                connect.Close();

                Movie m = availmovies[0];
                return View(m);
            }


        }
    }















}
