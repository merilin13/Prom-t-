namespace tuttavad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            nimed();
        }

        static void nimed()
        {
           
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/tuttavad.txt"))
                {
                    string rida =sr.ReadToEnd();
                    string[] nimed = rida.Split('\n');

                    foreach (string name in nimed)
                    {
                        Console.WriteLine("lihtsalt list");
                        Console.WriteLine(name);
                    }

                    Array.Sort(nimed);
                    Console.WriteLine("----------------");
                    foreach (string name in nimed)
                    {
                        Console.WriteLine("sorteeritud");
                        Console.WriteLine(name);
                    }
                    sr.Close();
                    
                    using (StreamWriter kirjuta = new StreamWriter("C:/Users/opilane/Desktop/tuttavad1.txt"))
                    {
                        int i = 1;
                        Console.WriteLine("----------------");
                        Console.WriteLine("salvestatud ja sorteeritud");
                        foreach (string name in nimed)
                        {
                            
                            kirjuta.WriteLine(name);
                        }

                    }
                    sr.Close();
                      
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("faili ei loetud");
                Console.WriteLine(e.Message);
            }
        }
    }
}