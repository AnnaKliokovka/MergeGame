using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInfo : MonoBehaviour
{
    /// <summary>
    /// Выделен ли предмет для перемещения
    /// </summary>
   public static bool MoveAllow = false;
    public static bool AddAllow = false;
    public static GameObject MoveMe = null;
    public static GameObject AddMe = null;
    public static GameObject AtMyPlace = null;
    public static double Cost = 0;
}
