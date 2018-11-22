using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_com_mysql
{
    class ClassDTO
    {

        //get e set dos valores com o banco de dados

        public string modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public string data
        {
            get => data;
            set => data = value;
        }
        public string categoria
        {
            get => categoria;
            set => categoria = value;
        }
        public string altura
        {
            get => altura;
            set => altura = value;
        }
        public string nacionalidade
        {
            get => nacionalidade;
            set => nacionalidade = value;
        }
        public string preco
        {
            get => preco;
            set => preco = value;
        }
        public string id
        {
            get => id;
            set => id = value;
        }

    }
}   
