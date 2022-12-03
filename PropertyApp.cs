using System;
class Fraction{
    private int numerator; // 프로퍼티 생성
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
        Fraction f = new Fraction(); // 생성자 생성
        int i=0;                     // Denominator에 값을 넣기위한 변수
        f.Numerator = 1;             //Numerator 프로퍼티를 이용해 1을 넣음
        i = f.Numerator + 1;         // Numerator 프로퍼티를 이용해 2를 받아옴
        f.Denominator = i;           // Denominator 프로퍼티를 이용해 2를 넣음
        Console.WriteLine(f.ToString()); //출력
    }
}