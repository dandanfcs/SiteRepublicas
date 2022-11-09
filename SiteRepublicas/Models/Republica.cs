using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteRepublicas.Models
{
    public class Republicas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quartos { get; set; }
        public int Salas { get; set; }
        public int Banheiros { get; set; }
        public int Cozinha { get; set; }
        public int Numero_de_Vagas { get; set; }

        public int Garagem { get; set; }

        public int Valor { get; set; }
        public string Tipo { get; set; }
  
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }



    }
}
