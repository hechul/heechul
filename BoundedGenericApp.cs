using System;
class GenericType<T> where T : SystemException{
    private T value;
    public GenericType(T v){
        value = v;
    }
    override public String ToString(){
        return "Type is " + value.GetType();
    }
}
public class BoundedGeneicApp{
    public static void Main(String[] args){
        GenericType<NullReferenceException>(new NullReferenceException());
        new GenericType<IndexOutOfRangeExeption> gIndexEx
    
    
    }
}