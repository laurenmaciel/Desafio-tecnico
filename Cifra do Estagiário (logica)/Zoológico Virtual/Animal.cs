using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoológico_Virtual
{
    internal class Animal
    {
        public String Nome { get; set; }
        public String Som { get; set; }

        public Animal(string nome, string som) 
        {
            Nome = nome;
            Som = som;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz: {Som}");
        }
    }
    class Leao : Animal
    {
        public Leao(string nome) : base(nome, "Rugido") { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} ruge: Roooar!");
        }
    }
    class Macaco : Animal
    {
        public Macaco(string nome) : base(nome, "Gritos") { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} grita: Uh Uh Ah Ah!");
        }
    }
    class Elefante : Animal
    {
        public Elefante(string nome) : base(nome, "Barulho de Trombeta") { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} trombeta: Prrrrrrr!");
        }
    }
    class Cobra : Animal
    {
        public Cobra(string nome) : base(nome, "sibilo") { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} sibilo: Ssssssss!");
        }
    }
}
