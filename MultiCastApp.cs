using System;
delegate void MultiCastDelegate();
class Schedule{
    public void Now(){
        Console.WriteLine("Time : " + DateTime.Now.ToString());
    }
    public static void Today(){
        Console.WriteLine("Date : " + DateTime.Today.ToString());
    }
}
class MultiCastApp{
    public static void Main(){
        Schedule obj = new Schedule(); // 생성자 생성
        MultiCastDelegate mcd = new MultiCastDelegate(obj.Now); // 델리게이트로 NOW 불러오기
        mcd += new MultiCastDelegate(Schedule.Today); // 멀티캐스트 
        mcd(); 
    }
}