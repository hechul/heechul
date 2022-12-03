using System;
class GenericMethodApp{
    static void Swap<DataType>(ref DataType x, ref DataType y){
        DataType temp; 
        temp = x; // x의 데이터를 temp에 저장
        x = y;    // y의 데이터를  x에 저장
        y = temp;
    }
    public static void Main(String[] args){
        int a = 1,b = 2;
        double c = 1.5 , d = 2.5;
        Console.WriteLine("Before : a = {0}, b = {1}",a,b);
    }
}