using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class estudante
    {
        public int numero;
        public string data;
        public string hora;
        public char tipo_mov;

        public estudante() // construtor vazio
        {

        }

        public estudante(int numero, string data, string hora, char movimento)
        {         // construtor com inicialização da instância do objeto
            this.numero = numero;
            this.data = data;
            this.hora = hora;
            this.tipo_mov = movimento; 
        }



    }
}
