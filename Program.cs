using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09EstoqueProdutos
{
    class Program
    {     
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> { "Camiseta", "Calça" };
            Console.WriteLine(" Bem-vindo ao Conrado Store");


            while (true)
            {

                Console.WriteLine(" Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();

                if ( resposta == "1")
                {

                    Console.WriteLine(" Digite o nome do produto:");
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();
                    produtos.Add(produto);

                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine(" Esse item já existe na lista... ");

                        

                    }
                    else
                    { 
                        
                        
                        produtos.Add(produto);
                        Console.WriteLine(" Produto adicionado!");
                            
                            
                            
                             
                    }

                }
                else
                {
                    string texto = "";
                    int contador = 0;
                    while( contador < produtos.Count)
                    {
                       string primeiraletra = texto.Substring(0, 1);
                        primeiraletra = primeiraletra.ToUpper();
                        texto += produtos[contador] + " , ";
                        
                        string segundaparte = texto.Substring(1, texto.Length);
                        string palavracompleta = primeiraletra + segundaparte;


                        texto += palavracompleta + " ,";
                        contador++;

                    }

                    texto= texto.Substring(0, texto.Length - 2);

                    Console.WriteLine(texto);


                }


                
            
            
            
            
            
            
            
            
            }


            Console.ReadKey();


        }
    }
}
