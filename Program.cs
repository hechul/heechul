using System;
class Program{
    public static void Main(String[] args){
        Thread myThread = new Thread(Func);
        myThread.Start(7);
        for(int i=0;i<3;i++){
            Console.Writeline(i+1);
            Thread.Sleep(100);
        }
        Console.Writeline("메인쓰레드 종료");
    }
    private static void Func(object obj){
        int num = (int)obj;
    }

}

