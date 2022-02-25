using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInfo : MonoBehaviour
{
    public double Heathy = 100;
    private double Force = 1;
    public int[] ij;
    public void OneStep()
    {
        gameObject.transform.position += new Vector3(0, 0, 1);
        
    }
}
