using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using Parcial1._2_AP1.Entidades;
using Parcial1._2_AP1;

namespace Parcial1._2_AP1.DAL
{
    public class Contexto
    {
        public class Contexto : DbContext
        {
            public DbSet<>  { get; set; }
            
            public Contexto() : base("ConStr")
            {

            }

        }
    }

}
