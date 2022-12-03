using System;
class GenericMethodApp{
    static void Swap<DataType>(ref DataType x, ref DataType y){
        DataType temp;
        temp = x;
        x = y;
        y = temp;
    }
    public static void Main(String[] args){
        int a = 1,b = 2;
        double c = 1.5
    }
}