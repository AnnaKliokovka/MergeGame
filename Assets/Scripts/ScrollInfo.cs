using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollInfo : MonoBehaviour
{
    /// <summary>
    /// ������ ������ ������ �����
    /// </summary>
    public static int ScrollIndex = 1;
    public static int CountHeros = 8;
    /// <summary>
    /// ������, ��� 1 ��������, ��� ������ �����, 0 - �����
    /// </summary>
    public static double[] OpenedHeros = new double[] { 1, 1, 0, 0, 0, 0, 0, 0 };
//-----------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// ������� ����� ������ ������� ����
    /// </summary>
    public static double ScrollMax()
    {
        double Ans = 1;
        for (int i = 1; i< CountHeros/6+1; i++)
        {
            if (OpenedHeros[i*6]!=0)
            {
                Ans = Ans + 1;
            }
        }
        return Ans;
    }
//-----------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// ������� �������� ������
    /// </summary>
    /// <returns></returns>
    public static int CountActive()
    {
        int Ans = 0;
        for (int i =0; i< CountHeros; i++)
        {
            if (OpenedHeros[i]!=0)
            {
                Ans = Ans + 1;
            }
        }
        return Ans;
    }
}
//-------------------------------------------------------------------------------------------------------------------------------------------
