using MvcNetCoreEF2022.Data;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Repositories
{
    public class RepositoryHospitales
    {
        private HospitalesContext context;

        public RepositoryHospitales(HospitalesContext context)
        {
            this.context = context;
        }

        //REALIZAMOS UNA CONSULTA LINQ PARA DEVOLVER TODOS LOS HOSPITALES
        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int idhospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idhospital
                           select datos;
            //PODRIAMOS TENER HOSPITAL (UNO) O NO
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.First();
            }
        }
    }
}
