using System;
class UserErrExeption:ApplicationException{
    public UserErrExeption(string s) : base(s){}
}
class UserException{
    public static void Main(String[] args){
        try{
            throw new UserErrExeption("throw a excepction with a message");
        }catch(UserErrExeption e){
            Console.Writeline(e.Message);
        }
    }
}