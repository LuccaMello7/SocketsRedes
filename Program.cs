using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Leitura2
{
    class Program
    {
        class Cliente
        {
            public int Id { get; set; }
            public string NomeCerveja { get; set; }
            public string Email { get; set; }
        }

        static void Main(string[] args)
        {
            
            List<Cliente> lista = new List<Cliente>();

            
            string[] array = File.ReadAllLines(@"C:\Sites\exemplo.txt");

            //percorro o array e para cada linha
            for (int i = 0; i < array.Length; i++)
            {
                //crio um objeto do tipo Cliente
                Cliente c = new Cliente();

                //Uso o método Split e quebro cada linha
                //em um novo array auxiliar, ou seja, cada
                //conteúdo do arquivo txt separado por '|' será
                //um nova linha neste array auxiliar. Assim sei que
                //cada índice representa uma propriedade
                string[] auxiliar = array[i].Split('|');

                //Aqui recupero os itens, atribuindo
                //os mesmo as propriedade da classe
                //Cliente correspondentes, ou seja,
                //o índice zero será corresponde ao Id
                //o um ao nome e o dois ao e-mail
                c.Id = Convert.ToInt32(auxiliar[0]);
                c.NomeCerveja = auxiliar[1];
                c.Email = auxiliar[2];

                //Adiciono o objeto a lista
                lista.Add(c);
            }

            //Para verificar o resultado percorro a lista
            //e exibo os valores recuparados pelo List<Cliente>
            foreach (var item in lista)
            {
                Console.WriteLine(@"Id: {0}; Nome: {1}; E-mail: {2};", item.Id, item.NomeCerveja, item.Email);
                Console.WriteLine(@"----------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}

