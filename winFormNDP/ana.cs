using System;
using System.Globalization;
using System.Security.Cryptography;
using winFormNDP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

public class Nokta3d
{
    int x, y, z;

    public Nokta3d()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public Nokta3d(int X, int Y, int Z)
    {
        x = X;
        y = Y;
        z = Z;
    }

    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public int Z { get => z; set => z = value; }
}

public class Yuzey
{
    int x, y, z, boy;
    public Yuzey() { 
    x = 0;
    y = 0;       
    z = 0;
    boy = 0;
    }

    public Yuzey(int X, int Y, int Z,int B)
    {
        x = X;
        y = Y;
        z = Z;
        boy = B;
    }
    public int X { get => x; set => x = value; }
    public int Y { get => y; set => y = value; }
    public int Z { get => z; set => z = value; }
    public int Boy { get => boy; set => boy = value; }
}


public class circle
{
    Nokta3d m; int r;
    public circle()
    {
        m = new Nokta3d();
        r = 0;
    }
    public circle(Nokta3d P, int R)
    {
        m = P;
        r = R;

    }
    public Nokta3d M { get => m; set => m = value;}
    public int R { get => r; set => r = value; }



}

public static class Carpisma
{
    public static bool cemberCarp(circle c1, circle c2) //Çember Çember
    {
        if (c1.M.Z != c2.M.Z)
            return false;
        float d = (float)Math.Sqrt(Math.Pow((c1.M.X - c2.M.X), 2) + Math.Pow((c1.M.Y - c2.M.Y), 2));
        return (c1.R + c2.R) > d;
    }
    public static bool cembernoktaCarp(circle c1, Nokta3d n)
    {

        double d = Math.Sqrt(Math.Pow(n.X - c1.M.X, 2) + Math.Pow(n.Y - c1.M.Y, 2));
        return d <= (c1.R)/2;


    }// Çember Nokta
    public static bool dikdortgennoktaCarp(dikdortgen d1, Nokta3d n)
    {
        if ((d1.M.X <= n.X) && (n.X <= (d1.M.X + d1.En)))
        {
            if ((d1.M.Y <= n.Y) && (n.Y <= (d1.M.Y + d1.Boy)))
                return true;
            else
                return false;
        }
        else
            return false;
    }//Dikdörtgen Nokta
    public static bool dikdortgencemberCarp(circle c1, dikdortgen d1)
    { 
        if(d1.M.Z != c1.M.Z) return false;

        float yakınX = Math.Min(Math.Max(c1.M.X, d1.Sol), d1.Sag);
        float yakınY = Math.Min(Math.Max(c1.M.Y, d1.Ust), d1.Alt);

        float dX = c1.M.X - yakınX;
        float dY = c1.M.Y - yakınY;

        float dKare = (dX * dX) + (dY * dY);
        return dKare < (c1.R * c1.R);

    }// Dikdörtgen Çember
    public static bool kureCarp(Kure k1, Kure k2)   //Küre Küre
    {
        float d = (float)Math.Sqrt(Math.Pow((k1.M.X - k2.M.X), 2) + Math.Pow((k1.M.Y - k2.M.Y), 2) + Math.Pow((k1.M.Z - k2.M.Z), 2));
        d = (float)Math.Sqrt(Math.Pow(d,2) + Math.Pow((k1.M.Z - k2.M.Z), 2));

        if ((k1.R/2 + k2.R/2) > d)
            return true;
        else
            return false;

    }
    public static bool kurenoktaCarp(Kure k1, Nokta3d n)
    { 

        int dKare = (n.X - k1.M.X) * (n.X - k1.M.X) +
                            (n.Y - k1.M.Y) * (n.Y - k1.M.Y) +
                            (n.Z - k1.M.Z) * (n.Z - k1.M.Z);

        int yaricapKare = k1.R * k1.R;

        return dKare <= yaricapKare;
    } //Küre Nokta  
    public static bool kuredikdortgenCarp(Kure k1, dikdortgen d1)
    {

        float yakınX = Math.Min(Math.Max(k1.M.X, d1.Sol), d1.Sag);
        float yakınY = Math.Min(Math.Max(k1.M.Y, d1.Ust), d1.Alt);
        float farkZ =  Math.Abs(k1.M.Z - d1.M.Z);

        float dX = k1.M.X - yakınX;
        float dY = k1.M.Y - yakınY;
        float dKare = (float)Math.Sqrt((dX * dX) +Math.Sqrt(dY * dY));
        dKare = (dKare * dKare) + (farkZ * farkZ);
        return dKare < (k1.R * k1.R);


    } //Küre Dikdörtgen
    public static bool kuresilindirCarp(Kure k1, silindir s1)
    {
        float dX = s1.M.X - k1.M.X;
        float dY = s1.M.Y - k1.M.Y;
        float dZ = s1.M.Z - k1.M.Z;
        float d = (float)Math.Sqrt(dX * dX + dY * dY + dZ * dZ);
        return d <= (s1.R + k1.R);

    } //Küre Silindir
    public static bool dikdortgenCarp(dikdortgen d1, dikdortgen d2)
    {
        int Xa = d1.M.X + d1.En ;
        int Ya = d1.M.Y + d1.Boy ;
        int Xb = d2.M.X + d2.En ;
        int Yb = d2.M.X + d2.Boy ;

        if ((Math.Abs(Xa - Xb) < (d1.En  + d2.En) && Math.Abs(Ya - Yb) < (d1.Boy  + d2.Boy )))
            return true;
        else
            return false;
    } // Dikdörtgen Dikdörtgen
    public static bool silindirCarp(silindir k1, silindir k2)
    {
        Nokta3d pa = new Nokta3d(k1.M.X, k1.M.Y + k1.H / 2, k1.M.Z);
        Nokta3d pb = new Nokta3d(k2.M.X, k2.M.Y + k2.H / 2, k2.M.Z);

        float d = (float)Math.Sqrt(Math.Pow((pa.X - pb.X), 2) + Math.Pow((pa.Y - pb.Y), 2) + Math.Pow((pa.Z - pb.Z), 2));
        if ((k1.R + k2.R) > d && Math.Abs(pa.Y - pb.Y) < ((k1.H + k2.H) / 2))
            return true;
        else
            return false;
    } // Silindir Silindir
    public static bool silindirnoktaCarp(silindir k1, Nokta3d n)
    {
        if(k1.M.Y - k1.H / 2 <= n.Y && n.Y <= k1.M.Y + k1.H / 2)
        {
            float farkD = (float)Math.Sqrt(Math.Pow(n.X - k1.M.X, 2)+ Math.Pow(n.Z - k1.M.Z, 2));
            return k1.R >= farkD;

        }
        else return false;
    } //Nokta Silindir
    public static bool silindirdikdortgenCarp(silindir k1, dikdortgen d1)
    {
        if (k1.M.Y - k1.H/2 / 2 <= d1.M.Y && d1.M.Y <= k1.M.Y + k1.H / 2)
        {
            float yakınX = (float)Math.Min(Math.Max(k1.M.X, d1.Sol), d1.Sag);
            float dx = Math.Abs(k1.M.X - yakınX);
            float dz = Math.Abs(k1.M.Z - d1.M.Z);
            float d = (float)Math.Sqrt(dx*dx + dz*dz);
            return d <= k1.R ;
        }
        else  return false; 
    } //Silindir Dikdörtgen
    public static bool kurecemberCarp(Kure k1, circle c1)
    {
        float d = (float)Math.Sqrt(Math.Pow((k1.M.X - c1.M.X), 2) + Math.Pow((k1.M.Y - c1.M.Y), 2));
        d = (float)Math.Sqrt(Math.Pow(d, 2) + Math.Pow((k1.M.Z - c1.M.Z), 2));
        return k1.R + c1.R > d;

    } //Küre çember
    public static bool yuzeynoktaCarp(Yuzey y1, Nokta3d n) {
        if (y1.X == n.X)
        {
            if (y1.Y < n.Y && n.Y <= y1.Y + y1.Boy)
            {
                return (0 < n.Z && n.Z <= y1.Z);
            }
            else return false;
        }
        else return false;
        
    } // Yüzey nokta
    public static bool yuzeydikdortgenCarp(Yuzey y1, dikdortgen d1)
    { 
       if(d1.M.X<=y1.X && y1.X <= d1.M.X + d1.En)
        {
            if(d1.M.Y < y1.X && y1.X < d1.En + d1.M.Y + y1.Boy)
            {
                return d1.M.Z < y1.Z;
            }
            else return false;

        }
       else return false;

    } //Yüzey dikdörtgen
}