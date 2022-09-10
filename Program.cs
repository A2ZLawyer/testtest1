using System;
namespace ooplesson4task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings building = new(); 
            building.Add(2, 4, 3);

            Buildings building2 = new();
            building2.Add(4, 3, 8, 1);

            building.Print();
            building2.Print();
            building.Print();
        }
    }
}