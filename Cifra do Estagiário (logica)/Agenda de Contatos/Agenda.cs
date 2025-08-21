using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Contatos
{
    internal class Agenda
    {
        private List<Contato> contatos = new List<Contato>();
        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
            Console.WriteLine("Contato adicionado");
        }
        public void ListarContato()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato na agenda.");
                return;
            }
            Console.WriteLine("\n=== Lista de Contatos ===");
            foreach (var c in contatos)
            {
                Console.WriteLine(c);
            }
        }
        public void BuscarPorNome(string nome)
        {
            var resultados = contatos.Where(c => c.Nome.ToLower().Contains(nome.ToLower())).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("Contato não encontrado.");
                return;
            }

            Console.WriteLine("\n=== Contatos encontrados ===");
            foreach (var c in resultados)
            {
                Console.WriteLine(c);
            }
        }
        public void RemoverContato(string nome)
        {
            var contato = contatos.FirstOrDefault(c => c.Nome.ToLower() == nome.ToLower());
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado");
            }
        }
    }
}
