using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StartGame : MonoBehaviour, IPointerClickHandler
{
    private GameObject[] heros;
    public void OnPointerClick(PointerEventData eventData)
    {
        heros =  GameObject.FindGameObjectsWithTag("Hero");
        int count = heros.Length;
        if (count > 0)
        {
            AboutGame.StartGame = true;
            gameObject.GetComponent<Image>().enabled = false;
            gameObject.GetComponentInChildren<Text>().enabled = false;
            Game();
        }
        else
        {
            print("Нет героев");
        }
    }
    private void Game()
    {
        while (!AboutGame.Win)
        {
            StartCoroutine(WaitTime());
        }         
    }
    private void Step()
    {
        int count = heros.Length;
        for (int i = 0; i < count; i++)
        {
            heros[i].GetComponent<HeroInfo>().OneStep();
        }
    }
    IEnumerator WaitTime()
    {
        while (true)
        {
            //yield on a new YieldInstruction that waits for 5 seconds.
            yield return new WaitForSeconds(AboutGame.time);
            Step();
            AboutGame.CheckWin();
        }

    }
}
 