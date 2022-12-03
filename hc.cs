using System;
delegate void DelegateOne();
delegate void DelegateTwo(int i);
class DelegateClass{
    public void MethodA(){
        Console.WriteLine("In the DelegateClass.MethodA ...");
    }
    public void MethodB(int i){
        Console.WriteLine("DelegateClass.MethodB, i = " + i);
    }
}
class DelegateCallApp{
    public static void Main(){
        DelegateClass obj = new DelegateClass();
        DelegateOne d1 = new DelegateOne(obj.MethodA); //메소드 a
        DelegateTwo d2 = new DelegateTwo(obj.MethodB); //메소드 b
        d1();
        d2(20); // dd
    }
}