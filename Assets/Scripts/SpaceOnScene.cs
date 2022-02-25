using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOnScene : MonoBehaviour
{
    public static int[,] FreeSpace = new int[,] { { 0,0,0,0,0 } , { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }};
//-----------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static int[] First_Free()
    {
        for (int i =0; i< 3; i++)
        {
            for (int j = 0; j< 5; j++)
            {
                if (FreeSpace[i,j] ==0)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1, -1 };
    }
//------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static bool IsFree()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (FreeSpace[i, j] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ij"></param>
    /// <returns></returns>
    public static bool IsTheiFree(int[] ij)
    {
        if (FreeSpace[ij[0],ij[1]] != 1)
            return true;
        return false;
    }
}
