using System;
delegate void MultiCaseDelegate();
class Schedule{
    public void Now(){
        Console.WriteLine("Time : " + DateTime.Now.ToString());
    }
}