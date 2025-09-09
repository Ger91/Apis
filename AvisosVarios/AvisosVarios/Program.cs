
using System.Runtime.CompilerServices;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.mostrarAviso();
            AvisosTrafico av2 = new AvisosTrafico("Jefatura provincial de VillaConejos", "Sancion de 121212 euros a pagar por  Ainhoa petardolid", "12/12/12");
            av2.mostrarAviso();

        }
    }
}