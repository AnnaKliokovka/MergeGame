using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutGame : MonoBehaviour
{
    public static bool Win = false;
    public static bool StartGame = false;

    public static float time = 3;
//-------------------------------------------------------------------------------------------------------
    /// <summary>
    /// �������� - �������� �� ����� �� ����
    /// </summary>
    public static void CheckWin()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (Enemies.Length ==0 )
        {
            Win = true;
        }
    }
}
