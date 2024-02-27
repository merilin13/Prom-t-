
namespace hindelinetöö
{
    using System;
    using System.Runtime.Intrinsics.X86;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Valige Ruudu, teemandi, ristküliku ja kolmnurga vahel");
            string kujund = Console.ReadLine().ToLower();

            switch (kujund)
            {
                case "ruut":
                    Ruut();
                    break;
                case "teemant":
                    Teemand();
                    break;
                case "ristkylik":
                    Ristkülik();
                    break;
                case "kolmnurk":
                    Kolmnurk();
                    break;
                default:
                    Console.WriteLine("Sellist kujundit ei ole valikus.");
                    break;
            }
        }

        static void Ruut()
        {
            Console.WriteLine("Sisesta ruudu külje pikkus:");
            int külg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ruut:");
            for (int i = 0; i < külg; i++)
            {
                for (int j = 0; j < külg; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            int ümbermoot = 4 * külg;
            int pindala = külg * külg;
            Console.WriteLine($"Ruudu ümbermõõt on {ümbermoot} ja pindala on {pindala} ühikut.");
        }

        static void Teemand()
        {
            Console.WriteLine("Sisesta teemanti diagonaalide pikkused (vaheldumisi):");
            int diag1 = Convert.ToInt32(Console.ReadLine());
            int diag2 = Convert.ToInt32(Console.ReadLine());

            int pooldiag1 = diag1 / 2;

            Console.WriteLine("Teemant:");

            for (int i = 0; i <= pooldiag1; i++)
            {
                for (int j = 0; j <= pooldiag1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = pooldiag1 - 1; i >= 0; i--)
            {
                for (int j = 0; j <= pooldiag1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int ümbermoot = 2 * (diag1 + diag2);
            int pindala = (diag1 * diag2) / 2;
            Console.WriteLine($"Teemandi ümbermõõt on {ümbermoot} ja pindala on {pindala} ühikut.");
        }

        static void Ristkülik()
        {
            Console.WriteLine("Sisesta ristküliku pikkus ja laius:");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            int laius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ristkülik:");

            for (int i = 0; i < laius; i++)
            {
                for (int j = 0; j < pikkus; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int ümbermoot = 2 * (pikkus + laius);
            int pindala = pikkus * laius;
            Console.WriteLine($"Ristküliku ümbermõõt on {ümbermoot} ja pindala on {pindala} ühikut.");
        }

        static void Kolmnurk()
        {
            Console.WriteLine("Sisesta kolmnurga alus ja kõrgus:");
            int alus = Convert.ToInt32(Console.ReadLine());
            int korgus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kolmnurk:");

            for (int i = 0; i < korgus; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int ümbermoot = alus + korgus + (int)Math.Sqrt(Math.Pow(alus, 2) + Math.Pow(korgus, 2));
            double pindala = (alus * korgus) / 2.0;
            Console.WriteLine($"Kolmnurga ümbermõõt on {ümbermoot} ja pindala on {pindala} ühikut.");
        }
    }
}


