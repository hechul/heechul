using System;
class Color{
    private string[] color = new string[5];
    public string this[int index]{
        get {return color[index];}
        set {color[index] = value;}
    }
}
class IndexrApp{
    public static void Main(){
        Color c = new Color();
        c[0] = "WHITE";
        c[1] = "RED";
        c[2] = "YELLOW"
    }
}