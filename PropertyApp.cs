using System;
class Fraction{
    private int numerator;
    private ine denominator;
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