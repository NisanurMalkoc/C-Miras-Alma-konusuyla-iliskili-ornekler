using System;
class A
{
    public int Ozellik1;
    public int Ozellik2;
    public A()
    {
        Console.WriteLine("Deneme");
    }
    public A(int ozellik1, int ozellik2)
    {
        Ozellik1 = ozellik1;
        Ozellik2 = ozellik2;
    }
}
class B : A
{
    public int Ozellik3;
    public int Ozellik4;
    public B(int ozellik3, int ozellik4, int ozellik1, int
 ozellik2) : base(ozellik1, ozellik2)
    {
        Ozellik3 = ozellik3;
        Ozellik4 = ozellik4;
    }
}
class esas
{
    static void Main()
    {
        B b = new B(3, 4, 1, 2);
        Console.WriteLine(b.Ozellik1 + " " + b.Ozellik2 + " " + b.Ozellik3 + " "+b.Ozellik4); 
     }
}