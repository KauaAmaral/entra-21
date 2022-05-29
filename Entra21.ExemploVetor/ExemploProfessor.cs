using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploVetor
{
    internal class ExemploProfessor
    {
        public void Executar()
        {
            var table = new ConsoleTable("one", "two", "three");
            table.AddRow(1, 2, 3)
                 .AddRow("Oi", "Meu nome é", "Kauã")
                 .AddRow("Xau", "Para", "Você");

            table.Write();
            

        }
    }
}
