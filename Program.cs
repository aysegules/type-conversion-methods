internal class Program
{
    public static void Main(string[] args)
    {
        //Implicit Conversion(bilinçsiz ya da kapalı dönüşüm)
        Console.WriteLine("*****Implicit Conversion*****");

        byte a=5;
        sbyte b=30;
        short c=10;

        int d=a+b+c;
        Console.WriteLine("d:"+d);

        long h=d;
        Console.WriteLine("h:"+h);

        float i=h;
        Console.WriteLine("i:"+i);

        string str="aysegul";
        char chr='e';
        object object1=str+chr+d;
        Console.WriteLine("object1:"+object1);

        //Explicit Conversion(bilinçli ya da açık dönüşüm)
        Console.WriteLine("*****Explicit Conversion*****");

        int x=4;
        byte y=(byte)x;
        Console.WriteLine("y:"+y);

        int z=100;
        byte t=(byte)z;
        Console.WriteLine("t:"+t);

        float w=10.3f;
        byte v=(byte)w;
        Console.WriteLine("v:"+v);

        //ToString Method
        Console.WriteLine("*****ToString Method*****");

        int xx=6;
        string str1=xx.ToString();
        Console.WriteLine("str1:"+str1);

        string str2=12.5f.ToString();
        Console.WriteLine("str2:"+str2);

        //System.Convert
        Console.WriteLine("*****System.Convert*****");

        string str3="10", str4="30";
        int sayi1, sayi2;
        int toplam;

        sayi1=Convert.ToInt32(str3);
        sayi2=Convert.ToInt32(str4);
        toplam=sayi1+sayi2;
        Console.WriteLine("toplam:"+toplam);

        //Parse Method
        Console.WriteLine("*****Parse Method*****");
        ParseMethod();

    }
    public static void ParseMethod()
    {
        string s1="10";
        string s2="10.25";
        int int1;
        double double1;

        int1=Int32.Parse(s1);
        double1=Double.Parse(s2);

        Console.WriteLine("int1:"+int1);
        Console.WriteLine("double1:"+double1);
    }

}