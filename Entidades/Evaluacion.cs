using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1._2_AP1.Entidades
{
    public class Evaluacion
    {
        [Key]
        public string Id { get; set; }
        public string Estudiante { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public decimal Logrado { get; set; }
        public decimal Perdido { get; set; }

        public Evaluacion()
        {
            Id = Id;
            Estudiante = string.Empty;
            Fecha = DateTime.Now;
            Valor = 0;
            Logrado = 0;
            Perdido = 0;
        }
            public Evaluacion (string id, string estudiante, decimal valor, decimal logrado, decimal perdido)
            {
                Id = id;
                Estudiante = estudiante;
                Valor = valor;
                Logrado = logrado;
                Perdido = perdido;

            }

        }
    }




 