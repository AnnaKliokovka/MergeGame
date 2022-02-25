using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollInfo : MonoBehaviour
{
    /// <summary>
    /// Индекс окошка скрола снизу
    /// </summary>
    public static int ScrollIndex = 1;
    public static int CountHeros = 8;
    /// <summary>
    /// Список, где 1 означает, что открыт герой, 0 - иначе
    /// </summary>
    public static double[] OpenedHeros = new double[] { 1, 1, 0, 0, 0, 0, 0, 0 };
//-----------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Сколько всего окошек скролла есть
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
    /// Подсчет активных персов
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
