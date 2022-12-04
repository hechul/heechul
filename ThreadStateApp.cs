using System;
using System.Threading;
class ThreadState{
    public void ThreadBody(){
        while (true){
            // ... infinite loop ...
        }
    }
}
class ThreadStateApp{
    public static void Main(String[] args){
        ThreadState obj = new ThreadState(); // 스레드상태
        ThreadStart ts = new ThreadStart(obj.ThreadBody);
        Thread t = new Thread(ts);
        Console.WriteLine("Step 1: " + t.ThreadState);
        t.Start();
        Thread.Sleep(100); //공백시간
        Console.WriteLine("Step 2: " + t.ThreadState);
        t.Suspend();
        Thread.Sleep(100);//공백시간
        Console.WriteLine("Step 3: " + t.ThreadState);
        t.Resume();
        Thread.Sleep(100);  //공백시간
        Console.WriteLine("Step 4: " + t.ThreadState);
        t.Abort();
        Thread.Sleep(100);//공백시간
        Console.WriteLine("Step 5: " + t.ThreadState);

    }
}