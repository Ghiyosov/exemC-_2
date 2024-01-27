using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace _tast_7;

public class Math
{
    public double PI = 3.14;
    public double E = 2.71;


    public double Abs(double a)
    {
        if(a<0) return a*(-1);
        else return a;
    }
     public float Abs(float a)
    {
        if(a<0) return a*(-1);
        else return a;
    }
     public int Abs(int a)
    {
        if(a<0) return a*(-1);
        else return a;
    }
    public double Pow(double x, double y)
    {
        double b = x;
        for (int i = 0; i < y; i++)
        {
            x*=b;
        }
        if (y==0) return 1;
        else if (y==1) return b;
        else return x/b;
    }


    public int Max(int a, int b)
    {
        if(a>b) return a;
        if(b>a) return b;
        else return a;
    }
     public int Min(int a, int b)
    {
        if(a>b) return b;
        if(b>a) return a;
        else return a;
    }

    public int Sqrt(int q)
    {
        int s=1;
        while (true)
        {
            if((s*s)==q) return s;
            s++;
            if(s>q) 
            {
                return 0;
            }

        }
    }
    
}
