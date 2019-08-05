using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using ConsumeWebApi.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsumeWebApi.Controllers
{
    public class UsuariosController : Controller
    {
        string Baseurl = ".";

        public async Task<ActionResult> Index()
        {
            List<Usuarios> EmpInfo = new List<Usuarios>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/usuarios");


            }
        }

    }
}