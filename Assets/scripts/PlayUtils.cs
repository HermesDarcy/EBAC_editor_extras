using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEditor;


public static class PlayUtils 
{

#if UNITY_EDITOR_WIN  // usar para não dar bug na copilação
    [UnityEditor.MenuItem("EBAC/teste1")]
    public static void Teste1()
    {
        Debug.Log("teste1");
    }

    [UnityEditor.MenuItem("EBAC/teste2 #b")]
    public static void Teste2()
    {
        Debug.Log("teste1");
    }

    // Criação de atalhos no menu
    // % – CTRL on Windows / CMD on OSX
    //  # – Shift
    //  & – Alt

#endif

    public static void NScale(this Transform t, float scale = 1f)
    {
        t.localScale = Vector3.one * scale;
    }

    public static void NScale(this GameObject t, float scale = 1f)
    {
        t.transform.localScale = Vector3.one * scale;
    }


    public static void BasicColor(this Material mat, string color = "white")
    {
       mat.color = ColorString(color);
    }

    public static void BasicColor(this SpriteRenderer sr, string color ="white")
    {
        sr.color = ColorString(color);
    }


    public static void BasicColor(this Color cor, string color = "white")
    {
        cor = ColorString(color);
    }

    public static void GetColor(string color = "white")
    {
        Color cor =  ColorString(color);
    }

    public static T ObjsRandom<T> (this List<T> list)
    {
        if (list == null) return default(T);
        return list[Random.Range(0, list.Count)];
    }


    public static T ObjsRandom<T>(this T[] array)
    {
        if(array == null) return default(T);
        return array[Random.Range(0, array.Length)];
    }

   


    public static Color ColorString(string cor)
    {
        cor = cor.ToLower();
        Color color;
        if (cor == "blue")
        {
            color = Color.blue;
        }
        else if (cor == "green")
        {
            color = Color.green;
        }
        else if (cor == "red")
        {
            color = Color.red;
        }
        else if (cor == "gray")
        {
            color = Color.grey;
        }
        else if (cor == "yellow")
        {
            color = Color.yellow;
        }
        else if (cor == "cyan")
        {
            color = Color.cyan;
        }
        else if (cor == "magenta" || cor == "pink")
        {
            color = Color.magenta;
        }
        else { color = Color.white; }
        
        
        return color;
    }

}
