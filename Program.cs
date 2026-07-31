using System;

// See https://aka.ms/new-console-template for more information
class conCenter

{ 
    public int w = 80;
    public int h = 25;
    public  String spaces(int a)
    {
        String s = "";
        for (int i = 0; i < a; i++)
        {
            s = s + " ";
        }
        return s;
    }
    public  String centers(String a)
    {
        String s = "";
        int b = w/2-a.Length/2;
        s = spaces(b);
        s = s + a;
        return s;
    }
}
class consoleCenters {
    public static void Main() 
    {
        String[] s = "hello world,im love c#,center string".Split(",");
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        conCenter cc= new conCenter();
        cc.w= Console.WindowWidth;
        foreach(var ss in s) 
        { 
            Console.WriteLine(cc.centers(ss));
        }
        
    
    
    }




}