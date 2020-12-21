using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CrudTeste.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace CrudTeste.Controllers
{
    public class AlunosController : Controller
    {
        public IConfiguration Configuration { get; }
        public static int Professor { get; set; }
        public static DateTime bloqueio = DateTime.Now;
        public AlunosController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index(int id)
        {
            List<Alunos> listaAlunos = new List<Alunos>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            Professor = id;
            bloqueio = DateTime.Now.AddMinutes(-5);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"Select a.*, p.nome nomeprofessor, p.proximaimportacao From alunos a join professores p on p.id = a.idprofessor where idprofessor = {id}";
                MySqlCommand command = new MySqlCommand(sql, connection);

                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Alunos aluno = new Alunos();
                        aluno.id = Convert.ToInt32(dataReader["id"]);
                        aluno.nome = Convert.ToString(dataReader["nome"]);
                        aluno.mensalidade = Convert.ToDouble(dataReader["mensalidade"]);
                        aluno.vencimento = Convert.ToDateTime(dataReader["vencimento"]);
                        aluno.idprofessor = Convert.ToInt32(dataReader["idprofessor"]);
                        aluno.nomeprofessor = Convert.ToString(dataReader["nomeprofessor"]);
                        listaAlunos.Add(aluno);

                        DateTime.TryParse(dataReader["proximaimportacao"].ToString(), out bloqueio);
                    }
                }
                connection.Close();
            }

            return View(listaAlunos);
        }
        public IActionResult CreateAluno()
        {
            return View();
        }
        [HttpPost]
        [ActionName("CreateAluno")]
        public IActionResult CreateAluno_Post(Alunos aluno)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string sql = $"INSERT INTO alunos(idprofessor, nome, mensalidade, vencimento) VALUES ({Professor}, '{aluno.nome}', {aluno.mensalidade}, '{aluno.vencimento.ToString("yyyy-MM-dd")}');";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    return RedirectToAction("Index", new { id = Professor });
                }
            }
            else
                return View();
        }
        public IActionResult EditAluno(int id)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            Alunos aluno = new Alunos();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"Select * From alunos Where id='{id}'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                connection.Open();
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        aluno.id = Convert.ToInt32(dataReader["id"]);
                        aluno.nome = Convert.ToString(dataReader["nome"]);
                        aluno.mensalidade = Convert.ToDouble(dataReader["mensalidade"]);
                        aluno.vencimento = Convert.ToDateTime(dataReader["vencimento"]);
                    }
                }
                connection.Close();
            }

            return View(aluno);
        }
        [HttpPost]
        [ActionName("EditAluno")]
        public IActionResult EditAluno_Post(Alunos aluno)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"Update alunos SET nome='{aluno.nome}', mensalidade={aluno.mensalidade}, vencimento='{aluno.vencimento.ToString("yyyy-MM-dd")}' Where Id='{aluno.id}'";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return RedirectToAction("Index", new { id = Professor });
        }
        [HttpPost]
        public IActionResult ApagarAluno(int id)
        {
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"Delete From alunos Where Id='{id}'";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        ViewBag.Result = "Operation got error:" + ex.Message;
                    }
                    connection.Close();
                }
            }

            return RedirectToAction("Index", new { id = Professor });
        }
        public IActionResult ImportarAlunos()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadAlunos(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    String linha = reader.ReadLine();

                    string[] linhas = linha.Split("||");

                    if(linhas.Length == 3)
                    {
                        string nome = linhas[0];
                        double mensalidade = 0;
                        double.TryParse(linhas[1], out mensalidade);
                        DateTime vencimento = DateTime.Now.Date;
                        DateTime.TryParse(linhas[2], out vencimento);

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            string sql = $"INSERT INTO alunos(idprofessor, nome, mensalidade, vencimento) VALUES ({Professor}, '{nome}', {mensalidade}, '{vencimento.ToString("yyyy-MM-dd")}');";

                            using (MySqlCommand command = new MySqlCommand(sql, connection))
                            {
                                command.CommandType = System.Data.CommandType.Text;
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                    }
                }
            }

            int tempo = 0;
            int.TryParse(Configuration["TimeOutImportacao"], out tempo);
            bloqueio = DateTime.Now.AddMinutes(tempo);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"Update professores SET proximaimportacao='{bloqueio.ToString("yyyy-MM-dd HH:mm:ss")}' Where Id='{Professor}'";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return RedirectToAction("index", new { id = Professor });
        }
    }
}