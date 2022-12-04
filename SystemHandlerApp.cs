using System;
class SystemHandlerApp{
 public static void Main(String[] args){
    int[] vector = {1,2,3} // 인덱스 선언
    try{
      Console.Writeline("Here : 1");
      vector[4] = 4; //예외 발생
      Console.Writeline("Here : 2");
    
    }catch(IndexOutOfRangeException){
      Console.Writeline("Sys")
    }
 }
}