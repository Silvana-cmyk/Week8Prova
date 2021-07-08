using FinalFantasy.Core.Entities;
using FinalFantasy.RepositoryMock;
using System;

namespace FinalFantasy
{
    class Program
    {
        public static RepositoryUserMock repoUserM = new RepositoryUserMock();
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                continua = MenuPrincipale();
            }

        }

        private static bool MenuPrincipale()
        {
            Console.WriteLine("1. Accedi");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");
            int scelta = Helper.VerificaInput(3);
            var esito = AnalizzaScelta(scelta);
            return esito;
        }

        private static bool AnalizzaScelta(int scelta)
        {
            bool go = true;
            switch (scelta)
            {
                case 1:
                    Accedi();
                    break;
                case 2:
                    Registrati();
                    break;
                case 3:
                    go = false;
                    break;
                default:
                    go = false;
                    break;
            }
            return go;
        }

        private static void Registrati()
        {
            Console.WriteLine("Scegli nickname utente");
            String nickname = Console.ReadLine();
            User user = new User()
            {
                Nickname = nickname
            };
        }

        private static void Accedi()
        {
            Console.WriteLine("Inserisci nickname utente");
            String nickname = Console.ReadLine();
            bool flag = false;
            foreach(var item in repoUserM.GetAll())
            {
                if (item.Nickname.Equals(nickname))
                {
                    flag = true;
                }
            }
            if (flag == true)
            {
                //MENU GIOCA
            }
            else
            {
                Console.WriteLine("“Nickname errato”");
            }
        }
    }
}
