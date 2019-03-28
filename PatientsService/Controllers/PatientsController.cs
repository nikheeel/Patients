using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PatientsService.Models;

namespace PatientsService.Controllers
{
    public class PatientsController : ApiController
    {
        public IPatientsRepository _repo;
        public PatientsController(IPatientsRepository repo)
        {
            _repo = repo;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _repo.GetCities();
        }



    }
}
