namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shark shark = new Shark();
            Eagle eagle = new Eagle();
            Animal shark1 = new Shark(); 
            Animal eagle1 = new Eagle();
            ISwim TigerShark = new Shark();
            //Console.WriteLine(TigerShark.GetType());
            //Console.ReadKey();

            //shark.Eat();
            //shark1.Eat();
            //shark.Swim();
            //eagle.Fly();
            eagle.Eat(); // this hidden method
            eagle1.Eat();
            Console.ReadKey();

        }
    }
}
