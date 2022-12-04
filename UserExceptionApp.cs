using System;
class UserErrExeption:ApplicationException{
    public UserErrExeption(string s) : base(s){}
}
class UserException{ // 예외처리 클래스
    public static void Main(String[] args){
        try{
            throw new UserErrExeption("throw a excepction with a message");
        }catch(UserErrExeption e){
            Console.Writeline(e.Message);
        }
    }
}