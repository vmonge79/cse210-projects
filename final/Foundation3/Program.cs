using System;

class Program
{
    static void Main(string[] args)
    {

        Address ad1 = new Address("Tres Ríos", "Cartago");
        Address ad2 = new Address("San Joaquín", "Heredia");
        Address ad3 = new Address("San Pedro", "San José");
        Address ad4 = new Address("San Carlos", "Alajuela");

        Console.WriteLine(ad1);
        Console.WriteLine(ad2);
        Console.WriteLine(ad3);
        Console.WriteLine(ad4);


    }
}
