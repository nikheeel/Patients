using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientsService.Models
{
    public class PatientRepository : IPatientsRepository
    {
        public IEnumerable<string> GetCities()
        {
            return new string[] { "value1", "value2" };
        }
    }
}