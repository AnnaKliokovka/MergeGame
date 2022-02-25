using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AddAtScene : MonoBehaviour, IPointerClickHandler
{
    public GameObject hero;
    public double Cost;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (SpaceOnScene.IsFree() && MyMoney.Cash>=Cost)
        {
            SceneInfo.AddAllow = true;
            SceneInfo.AddMe = hero;
            SceneInfo.Cost = Cost;
            gameObject.GetComponent<Outline>().enabled = true;
            gameObject.GetComponent<Outline>().effectColor = new Color(1, 1, 1);
            gameObject.GetComponent<Outline>().effectDistance = new Vector2(3, -3);
        }
    }
}
