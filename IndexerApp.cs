using System;
class Color{ // 컬러 클래스
    private string[] color = new string[5];
    public string this[int index]{
        get {return color[index];}
        set {color[index] = value;}
    }
}
class IndexrApp{ // 인덱스 클래스
    public static void Main(){
        Color c = new Color(); // 생성자
        c[0] = "WHITE";
        c[1] = "RED";
        c[2] = "YELLOW";
        c[3] = "BLUE";
        c[4] = "BLACK";
        for(int i=0;i<5;i++){
            Console.WriteLine("Color is " + c[i]);
        }
    }
}