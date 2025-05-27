using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class AreaTriangulo : MonoBehaviour
{

    public float b1;
    public float h1;
    public GameObject objt;
    public cores colorido;
    public Color colorMe;
    
    
    private int limits = 10;

    public enum cores
    {
        white,
        magenta,
        green,
        yellow,
        red,
        cyan,
        grey, 
        blue
    }



    // Start is called before the first frame update
    // |x1(y2-y3) + x2(y3-y1) + x3(y1-y2)|.1/2
    public float AreaTriangle() // (Vector2 a, Vector2 b, Vector3 c)
    {
        
        return (b1* h1)/2f; 
        
    }


    public float multiAB
    {
        get { return (b1 * h1); }
    }


    public int myLimit
    {
        get { return limits; }
    }


    public void create()
    {
        var ob =Instantiate(objt);
        ob.transform.position = new Vector3(Random.Range(-limits,limits),Random.Range(-limits,myLimit),0f);
        
        ob.GetComponent<SpriteRenderer>().color = PlayUtils.ColorString(colorido.ToString());
       
    }

    public string mycolor
    {
        get { return colorido.ToString(); }
    }

    public Color howColor()
    {
       
        return PlayUtils.ColorString(colorido.ToString());
    }

}
