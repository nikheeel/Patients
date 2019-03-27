using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Models;

namespace Microservice.Repository
{
    public interface IPatientRepository
    {
        void Create(Patient patient);
        void Get(Patient patient);
        void Update(Patient patient);
        void Delete(Patient patient);
    }
}
