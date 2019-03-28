using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsService.Models
{
    public interface IPatientsRepository
    {
        IEnumerable<string> GetCities();
    }
}
