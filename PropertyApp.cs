using System;
class Fraction{
    private int numerator;
    private int denominator;
    public int Numerator{
        get {return numerator;}
        set {numerator = value;}
    }
    public int Denominator{
        get {return denominator;}
        set {denominator = value;}
    }
   override public string ToString(){
    return (numerator + "/" + denominator);
   }
}
class PropertyApp{
    public static void Main(String[] args){
        Fraction f = new Fraction(); 
        int i=0;
        f.Numerator = 1;
        i = f.Numerator + 1;
        f.Denominator = i;
        Console.WriteLine(f.ToString());
    }
}