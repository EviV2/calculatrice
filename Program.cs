using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Elias Veya
             ETML préap stage 1
             Projet commencé le 4 septembre
             finis le 7 septembre
             Programme: calculatrice*/

            /*int : c'est pour les chiffres
             double: c'est pour lwes chiffres a virgules
            char : c'est pour un seul charactère
            string: c'est pour une chaines de text
            bool: c pour une valeur vrai ou fausse:*/

            Console.WriteLine(" bonjour");




            string reco = "";// mettre la definition de ma fonction reco avec juste des "" me permet de faire en sort qu'il soit considerer comme un string sans lui donner de réel définition.
            do//La command do permet de faire le code dedans en fonction de la fonction while plus bas.
            {
                int result = 0;//,ettre la definition de ma fonction result avec juste un zero me permet de faire en sort qu'il soit considerer comme un int sans lui donner de réel définition.





                Console.WriteLine("nombre 1 pls");// je demand le premier numéro grace a la commande console.write line
                int ch1 = Convert.ToInt32(Console.ReadLine());// et la je  prend la réponse utilisateur grace au console.ReadLine qui sera instantanement convertie en int car c'est uin string de base.
                Console.WriteLine(" votre opérateur svp (*,+,-,/)");// la je demand l'opérateur

                string operateur = Console.ReadLine();// la je définis opérateur comme un string (une chaine de text)

                Console.WriteLine("nombre 2 pls");
                int ch2 = Convert.ToInt32(Console.ReadLine());
                /* Les commandes d'en dessus me permet de definir le numéro numéro1 et le 2 et ën meme temps de les convertir de string a int. les phrases d'en dessus me permet aussi de définir  l'opérateur
                 grace au console.readlines qui prend la réponse utilisateur et la retrenscri en  variable*/
               
                result = add(ch1, ch2);// faire cela me permettra que la fonction add ne sois pas considérer comme un boolean
                result = tim(ch1, ch2);// faire cela me permettra que la fonction tim ne sois pas considérer comme un boolean
                result = div(ch1, ch2);// faire cela me permettra que la fonction div ne sois pas considérer comme un boolean
                result = sub(ch1, ch2);// faire cela me permettra que la fonction sub ne sois pas considérer comme un boolean
                switch (operateur)// la je met un switch qui permettra de varrier la fonction opérateur en fonction de la réponse utilisateur
                    {


                        case "*": // la fonction case me permet de choisir un "scénario" en fonction de la réponse utiliateur.Par exemple la la personne a mis * donc ca fera des multiplications
                            Console.WriteLine("la réponse est");// ce text sera avant la réponse
                            Console.WriteLine(tim( ch1, ch2));// le je dit que ch1 sera multiplié par ch2 grace a la méthode tim
                        
                            break;// la fonction break me permet d'arreter une fonction case et de passer a la suivant ou de finir simplement la fonction case.
                        case "+":// la fonction case me permet de choisir un "scénario" en fonction de la réponse utiliateur.Par exemple la la personne a mis + donc ca fera des additions
                        Console.WriteLine("la réponse est");
                            Console.WriteLine(add(ch1, ch2)); ;// le je dit que ch1 sera additioné par ch2 grace a la méthode add

                        break;
                        case "-":// la fonction case me permet de choisir un "scénario" en fonction de la réponse utiliateur.Par exemple la la personne a mis - donc ca fera des soustractions
                        Console.WriteLine("la réponse est");
                            Console.WriteLine(sub(ch1, ch2)); ;// le je dit que ch1 sera soustrait par ch2 grace a la méthode sub

                        break;
                        case "/":// la fonction case me permet de choisir un "scénario" en fonction de la réponse utiliateur.Par exemple la la personne a mis / donc ca fera des divisions
                        Console.WriteLine("la réponse est");
                            Console.WriteLine(div(ch1, ch2)); ;// le je dit que ch1 sera divisé par ch2 grace a la méthode div

                        break;
                        default:// le default me permet de noter quelque chose si la personne ne marque pas une  réponse attendu.
                            Console.WriteLine(" mais mais un chiffre c pas compliqué");
                            break;
                    }

                    Console.WriteLine(" Tu veux recommencé? marque oui sinon appuie sur enter deux fois");
                    
                reco = Console.ReadLine();// la on dit que la variable reco est la réponse de l'utilisateur


                }
                while (reco == "oui");// la fonction while ici permet de dir que si la personne qui repond a la question prédent dit oui il recommencera la boucle depuis le do
               
                
                
                
                
                
                
                Console.ReadLine();// un console.ReadLine a la fin permet au code de ne pas bugger et de laisser les infos afficher quand on passe a la dernière étapes




                                                                                                                                                                                                                                                                                                                           

           
           

        }

        private static int add(int ch1, int ch2) //method addition
        {


            int result = ch1 + ch2;// la on dit que la variable result est égal a ch1 + ch2


            return result;// la commande return me permet de retourner une information final
        }
        private static int sub(int ch1, int ch2) // method soustraction
        {


            int result = ch1 - ch2;


            return result;
        }

        private static int tim(int ch1, int ch2) // method multiplication
        {


            int result = ch1 * ch2;


            return result;



        }

        private static int div(int ch1, int ch2) // method division
        {


            int result = ch1 / ch2;


            return result;
        }




    }

    }










       
    

