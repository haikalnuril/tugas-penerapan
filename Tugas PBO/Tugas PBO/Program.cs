using jenis;
using Benda;

class Program
{
    static void Main(string[] args)
    {
        prasejarah zaman1 = new prasejarah();
        benda benda1 = new benda();
        zaman1.setType();
        benda1.display();
        //int input = int.Parse(Console.ReadLine());
        //benda1.display(input);
    }
}