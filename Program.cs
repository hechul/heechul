using System;
class Program{
    public static void Main(String[] args){
        Thread myThread = new Thread(Func);
        myThread.Start(7);
        for(int i=0;i<3;)
    
    }
}
