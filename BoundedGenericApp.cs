using System;
class GenericType<T> where T : SystemException{
    private T value; // T를 자료형으로 한 필드생성
    public GenericType(T v){
        value = v;
    }
    override public String ToString(){
        return "Type is " + value.GetType();
    }
}
public class BoundedGeneicApp{
    public static void Main(String[] args){
        GenericType<NullReferenceException> gNullEx =
        new GenericType<NullReferenceException>(new NullReferenceException());
        GenericType<IndexOutOfRangeException> gIndexEx = 
        new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
        Console.WriteLine(gNullEx.ToString());
        Console.WriteLine(gIndexEx.ToString());
    }
}