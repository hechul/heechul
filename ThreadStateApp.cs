using System; // 시스테
using System.Threading;
class ThreadState{
    public void ThreadBody(){
        while (true){ // 무한반복
            // ... infinite loop ...
        }
    }
}
class ThreadStateApp{
    public static void Main(String[] args){ // 메인문
        ThreadState obj = new ThreadState(); // 스레드상태
        ThreadStart ts = new ThreadStart(obj.ThreadBody);
        Thread t = new Thread(ts); // new
        Console.WriteLine("Step 1: " + t.ThreadState);
        t.Start(); // start
        Thread.Sleep(100); //공백시간
        Console.WriteLine("Step 2: " + t.ThreadState);
        t.Suspend(); //suspend
        Thread.Sleep(100);//공백시간
        Console.WriteLine("Step 3: " + t.ThreadState);
        t.Resume(); //Resume
        Thread.Sleep(100);  //공백시간
        Console.WriteLine("Step 4: " + t.ThreadState);
        t.Abort(); //Ab
        Thread.Sleep(100);//공백시간
        Console.WriteLine("Step 5: " + t.ThreadState);

    }
}