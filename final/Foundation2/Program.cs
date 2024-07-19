using System;

class Program
{
    private static List<Order> orders = new List<Order>();
    static void Main(string[] args)
    {
        Product prod1 = new Product("orange", "A001", 3);
        Product prod2 = new Product("banana", "B002", 4);
        Product prod3 = new Product("apple", "C003", 4);
        Product prod4 = new Product("pineapple", "D004", 8);
        Product prod5 = new Product("watermelon", "E005", 8);
        Product prod6 = new Product("kiwi", "F006", 4);
        Product prod7 = new Product("strawberry", "A002", 4);
        Product prod8 = new Product("grapes", "B002", 5);
        Product prod9 = new Product("grapefruit", "C002", 2);
        Product prod10 = new Product("pomegranate", "D002", 4);

        Product.AddProduct(prod1);
        Product.AddProduct(prod2);
        Product.AddProduct(prod3);
        Product.AddProduct(prod4);
        Product.AddProduct(prod5);
        Product.AddProduct(prod6);
        Product.AddProduct(prod7);
        Product.AddProduct(prod8);
        Product.AddProduct(prod9);
        Product.AddProduct(prod10);

        Customer cust1 = new Customer("Viviana Monge");
        Customer cust2 = new Customer("Emily Duncan");
        Customer cust3 = new Customer("Miriam Marin");

        Address ad1 = new Address("31J", "Tres Ríos", "Cartago", "Costa Rica");
        Address ad2 = new Address("98", "Sabanilla", "San José", "Costa Rica");
        Address ad3 = new Address("ImpressionsDR", "Kearns", "Utah", "USA");


        Order order1 = new Order(cust1, ad1);
        order1.AddProductToOrder(prod1, 2);
        order1.AddProductToOrder(prod2, 3);
        order1.AddProductToOrder(prod3, 1);
        order1.AddProductToOrder(prod8, 3);
        order1.AddProductToOrder(prod10, 1);

        Order order2 = new Order(cust2, ad2);
        order2.AddProductToOrder(prod4, 2);
        order2.AddProductToOrder(prod6, 3);
        order2.AddProductToOrder(prod8, 1);
        order2.AddProductToOrder(prod3, 3);
        order2.AddProductToOrder(prod10, 1);

        Order order3 = new Order(cust3, ad3);
        order3.AddProductToOrder(prod1, 2);
        order3.AddProductToOrder(prod5, 3);
        order3.AddProductToOrder(prod3, 1);
        order3.AddProductToOrder(prod7, 3);
        order3.AddProductToOrder(prod3, 4);

        List<Order> orders = new List<Order> { order1, order2, order3 };


        foreach (var order in orders)
        {
        Console.WriteLine("------------------------------");
        order.DisplayShippingLabel();
        Console.WriteLine("------------ ORDER ------------");    
        order.DisplayPackingLabel();
        
        }

    }
}