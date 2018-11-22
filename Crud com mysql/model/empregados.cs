

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_com_mysql.model
{ //get e set de dados no salvamento
   public class empregados
    {
        internal string categoria;
        internal string data;

        public int Id_empregados { get; set; }

        public string modelo { get; set; }

        public string idade { get; set; }

        public string sexo { get; set; }

        public string altura { get; set; }

        public string nacionalidade { get; set; }

        public string preco { get; set; }

        public string id { get; set; }
    }
}
