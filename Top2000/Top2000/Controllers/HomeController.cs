using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Top2000.Models;
using Microsoft.Extensions.Configuration;

namespace Top2000.Controllers
{
    public class HomeController : Controller
    {
        private SqlDataReader _dataReader;
        private SqlConnection _connection = new SqlConnection();

        private List<Song> songs = new List<Song>();

        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;

            _configuration = configuration;
            _connection.ConnectionString = configuration.GetConnectionString("DefaultConnection");

            if (songs.Count > 0)
            {
                songs.Clear();
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Song()
        {
            FetchData();
            return View(songs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void FetchData()
        {
            try
            {
                using (_connection)
                {
                    SqlCommand command = new SqlCommand("GET_FULL_INFORMATION", _connection);
                    command.CommandType = CommandType.StoredProcedure;
                    _connection.Open();
                    command.ExecuteNonQuery();

                    foreach (DataRow row in command.)
                    {

                    }

                    _connection.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
