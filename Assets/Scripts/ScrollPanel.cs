using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollPanel : MonoBehaviour, IPointerClickHandler
{   
    public GameObject Panelka;
    public bool Left;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Left && ScrollInfo.ScrollIndex!=1)
        {
            for (int i = ScrollInfo.ScrollIndex * 6-6; i < ScrollInfo.ScrollIndex *6 ; i++)
            {
                if (i < ScrollInfo.CountHeros)
                {
                    Panelka.transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            ScrollInfo.ScrollIndex -= 1;
            for (int i = ScrollInfo.ScrollIndex * 6 -6; i < ScrollInfo.ScrollIndex *6 ; i++)
            {
                Panelka.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        else if (!Left && ScrollInfo.ScrollIndex < ScrollInfo.ScrollMax() )
        {            
            for (int i = ScrollInfo.ScrollIndex * 6 -6; i< ScrollInfo.ScrollIndex * 6; i++)
            {
                Panelka.transform.GetChild(i).gameObject.SetActive(false);
            }
            ScrollInfo.ScrollIndex += 1;
            for (int i = ScrollInfo.ScrollIndex*6-6; i< ScrollInfo.CountHeros; i++)
            {
                if (ScrollInfo.OpenedHeros[i] !=0)
                {
                    Panelka.transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        }
    }
}
