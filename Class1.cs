using System;

public class Kup
{
    public static double PI = 3.1416;
    double magassag;
    double sugar;
    double alkoto;

    public Kup(double magassag=0, double sugar=0, double alkoto=0)
    {
        if (magassag > 0 && sugar > 0)
        {
            alkoto = Math.Sqrt(Math.Pow(magassag,2)-Math.Pow(sugar,2));
        }
        else if (magassag > 0 && alkoto > 0)
        {
            sugar = Math.Sqrt(Math.Pow(magassag,2)+Math.Pow(alkoto,2));
        }
        else if (sugar > 0 && alkoto > 0)
        {
            magassag = Math.Sqrt(Math.Pow(sugar, 2) - Math.Pow(alkoto, 2));
        }
        else
        {
            Console.WriteLine("Nincs ilyen");
        }
    }
    public string InfoToString()
    {
        return $"A kúp adatai\n\tmagassága {this.magassag}\n\tsugara {this.sugar}\n\talkotója {this.alkoto}";
    }
    public double Terfogat()
    {
        return this.sugar * this.sugar * Kup.PI * this.magassag / 3;
    }
}
