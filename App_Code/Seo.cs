using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Seo
/// </summary>
public class Seo
{
    public Seo()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static string Temizle(string Metin)
    {
        string ifade = Metin;
        ifade = ifade.Replace(" ", "");
        ifade = ifade.Replace("'", "");

        ifade = ifade.Replace("%", "");

        ifade = ifade.Replace("<", "");

        ifade = ifade.Replace(">", "");

        ifade = ifade.Replace("{", "");

        ifade = ifade.Replace("}", "");
        return ifade;
    }
}