using Microsoft.EntityFrameworkCore;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Data
{
    public class HospitalesContext: DbContext
    {
        //NECESITAMOS UN CONSTRUCTOR OBLIGATORIO QUE RECIBIRA
        //LAS OPCIONES PARA EL CONTEXT.
        public HospitalesContext
            (DbContextOptions<HospitalesContext> context) : base(context) { }

        //NECESITAMOS CADA ENTIDAD/MODELO DENTRO DE ESTA CLASE
        //REPRESENTADA EN COLECCIONES DbSet<> Y DEBEN SER PROPIEDADES
        //DE FORMA OBLIGATORIA
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
