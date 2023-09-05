using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" bonjour");
            while (true)
                
            {
                Console.WriteLine("nombre 1 pls");
                int ch1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" votre opérateur svp (*,+,-,/)");

                string operateur = Console.ReadLine();

                Console.WriteLine("nombre 2 pls");
                int ch2 = Convert.ToInt32(Console.ReadLine());
                /* Les commandes d'en dessus me permet de definir le numéro numéro1 et le 2 et ën meme temps de les convertir de string a int. les phrases d'en dessus me permet aussi de définir  l'opérateur
                 grace au console.readlines qui prend la réponse utilisateur et la retrenscri en  variable*/
                
                
                switch (operateur)
                {


                    case "*":
                        Console.WriteLine("la réponse est");
                        Console.WriteLine(ch1 * ch2);

                        Console.ReadLine();
                        break;
                    case "+":
                        Console.WriteLine("la réponse est");
                        Console.WriteLine(ch1 + ch2);
                        Console.ReadLine();
                        break;
                    case "-":
                        Console.WriteLine("la réponse est");
                        Console.WriteLine(ch1 - ch2);

                        Console.ReadLine();
                        break;
                    case "/":
                        Console.WriteLine("la réponse est");
                        Console.WriteLine(ch1 / ch2);

                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine(" mais mais un chiffre c pas compliqué");
                        break;
                        

                }
                

            } 
             
            
            
            
            }

        
        

        
        
        
        
        

   
    }
}
