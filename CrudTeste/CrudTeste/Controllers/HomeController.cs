using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudTeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace CrudTeste.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            List<Professores> listaProfessores = new List<Professores>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "Select * From professores";
                MySqlCommand command = new MySqlCommand(sql, connection);

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Professores professor = new Professores();
                        professor.id = Convert.ToInt32(dataReader["id"]);
                        professor.nome = Convert.ToString(dataReader["nome"]);
                        professor.especialidade = Convert.ToString(dataReader["especialidade"]);
                        listaProfessores.Add(professor);
                    }
                }
                connection.Close();
            }

            return View(listaProfessores);
        }
        public IActionResult CreateProfessor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProfessor_Post(Professores professor)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sql = $"Insert Into professores(nome, especialidade) Values ('{professor.nome}', '{professor.especialidade}')";
                    
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    return RedirectToAction("Index");
                }
            }
            else
                return View();
        }
        public IActionResult EditProfessor(int id)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            Professores professor = new Professores();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"Select * From professores Where id='{id}'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        professor.id = Convert.ToInt32(dataReader["id"]);
                        professor.nome = Convert.ToString(dataReader["nome"]);
                        professor.especialidade = Convert.ToString(dataReader["especialidade"]);
                    }
                }
                connection.Close();
            }

            return View(professor);
        }
        [HttpPost]
        [ActionName("EditProfessor")]
        public IActionResult EditProfessor_Post(Professores professor)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"Update professores SET nome='{professor.nome}', especialidade='{professor.especialidade}' Where Id='{professor.id}'";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return RedirectToAction("Index");
        }
    }
}