using System;

class Program : Fraction
{
    static void Main(string[] args)
    {
       Fraction n1 = new Fraction();
       Console.WriteLine(n1.fractionString());
       Console.WriteLine(n1.fractionDecimal());

       Fraction n2 = new Fraction(2); 
       Console.WriteLine(n2.fractionString()); 
       Console.WriteLine(n2.fractionDecimal());

       Fraction n3 = new Fraction(5,6);
       Console.WriteLine(n3.fractionString());
       Console.WriteLine(n3.fractionDecimal()); 

       Fraction n4 = new Fraction(1,7);
       Console.WriteLine(n4.fractionString());
       Console.WriteLine(n4.fractionDecimal());
        

    }
}
