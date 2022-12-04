using System;
using System.Threading;
class Program{
    public static void Main(String[] args){ // 메인문
        Thread myThread = new Thread(Func);
        myThread.Start(7);
        for(int i=0;i<3;i++){
            Console.Writeline(i+1);
            Thread.Sleep(100);
        }
        Console.Writeline("메인쓰레드 종료"); // 메인쓰레드 종료문장
    }
    private static void Func(object obj){
        int num = (int)obj;
        for(int i=0;i<num;i++){ // 반복문 num까지
            Console.Writeline(i + 1); 
            Thread.Sleep(100); // 공백시간
        }
    }

}

