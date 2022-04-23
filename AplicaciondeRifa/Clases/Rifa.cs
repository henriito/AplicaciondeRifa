using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciondeRifa.Clases
{
    internal class Rifa
    {

        public string[] premios = { "Lavadora", "Licuadora", "Vajilla de Ceramica", "Set de vasos" };


        public int GeneraNumero(int n1, int n2)
        {

            Random r = new Random();
            return r.Next(n1, n2);

        }
        public int GeneraPremio()
        {
            Random prix = new Random();
            return prix.Next(1, 5);

        }

        public void rifa(string[] Concursantes, int Premios)
        {
            string premio, ganador;
            premio = ganador = "";
            int tombola = 0;
            int i;
            for (i = 1; i <= Premios; i++)
            {
                tombola = GeneraNumero(0, Concursantes.Length - 1);
                Console.WriteLine($"Premio numero {i}: {premios[i - 1]}");
                Console.WriteLine($"Ganador: {Concursantes[tombola]}");
            }

        }
    }
}
