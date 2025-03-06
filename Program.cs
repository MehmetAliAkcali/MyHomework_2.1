using System;

class Program
{
    static void Main(string[] args)
    {
        BMW bmw = new BMW();
        bmw.marka = "bmw";
        

        Porsche porsche = new Porsche();
        porsche.marka = "Porsche";
        

        Mercedes mercedes = new Mercedes();
        mercedes.marka = "Mercedes";
       


       bmw.YetenekleriYazdir("BMW");
       mercedes.YetenekleriYazdir("Mercedes");
       porsche.YetenekleriYazdir("Porsche");

       
        
    }
}