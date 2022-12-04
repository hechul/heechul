using System;// 시스템
class DivByZeroExceptionApp{
    public static void Main(){
        int i = 1, j = 0,k; // 변수
        k = i/j; // 예외발생
    }
}