using System.Collections.Generic;
using System;

public class Product
{
    private string _prodName;
    private string _prodId;
    private float _prodPrice;
    private int _prodQ = 1;
    

    private float _totalPrice = 0;
    private static List<Product> products = new List<Product>();

    public string GetProdName()
    {
        return _prodName;
    }

    public void SetProdName(string prodName)
    {
        _prodName = prodName;
    }

    public string GetProdId()
    {
        return _prodId;
    }

    public void SetProdId(string prodId)
    {
        _prodId = prodId;
    }

    public float GetProdPrice()
    {
        return _prodPrice;
    }

    public void SetProdPrice(float prodPrice)
    {
        _prodPrice = prodPrice;
    }

    public int GetProdQ()
    {
        return _prodQ;
    }

    public void SetProdQ(int prodQ)
    {
        _prodQ = prodQ;
    }


    public float GetTotalPrice()
    {
        return _totalPrice;
    }

    public void SetTotalPrice(float totalPrice)
    {
        _totalPrice = totalPrice;
    }

    public Product(string prodName, string prodId, float prodPrice)
    {
        _prodName = prodName;
        _prodId = prodId;
        _prodPrice = prodPrice;
    }

    public void DisplayProdDescription()
    {
        Console.WriteLine($"Name: {_prodName} > ID: {_prodId} > Price: ${_prodPrice}");
    }

    public float CalculateProductTotalPrice(int quantity)
    {
        return _prodPrice * quantity;
    }


    public static void AddProduct(Product product)
    {
        products.Add(product);
    }

    public static List<Product> GetProducts()
    {
        return products;
    }
}
