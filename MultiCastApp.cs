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

}