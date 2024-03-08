namespace luuletus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");

            FileWordReading();
        }


        static void FileWordReading()
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/luuletus.txt"))
                {
                    int cnt = 0;
                    while (sr.EndOfStream == false)
                    {
                        ++cnt;
                        line = sr.ReadLine();
                        int pikkus = line.Length;
                        Console.WriteLine(cnt + " " + line + " " + pikkus);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
    
}