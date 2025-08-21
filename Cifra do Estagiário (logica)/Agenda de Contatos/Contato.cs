using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Contatos
{
    internal class Contato
    {
        public String Nome { get; set; }
        public int Telefone { get; set; }
        public String Email { get; set; }

        public Contato(String Nome, int Telefone, String Email) 
        {
            this.Nome = Nome; 
            this.Telefone = Telefone; 
            this.Email = Email;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
        }
        
    }
   

}
