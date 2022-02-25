using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Заполнение панели
        GameObject MyPanel = GameObject.Find("Panel");
        int CountAll = ScrollInfo.CountHeros;
        for (int i =1; i< CountAll; i++)
        {
            if (ScrollInfo.OpenedHeros[i] != 0 && i< 6)
            {
                MyPanel.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                MyPanel.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        //Установка денег 
        UnityEngine.UI.Text money = GameObject.Find("MoneyInfo").GetComponent<UnityEngine.UI.Text>();
        money.text = MyMoney.Cash.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit raycastHit;
                    if (Physics.Raycast(raycast, out raycastHit))
                    {
                        if (raycastHit.collider.tag == "Hero" && !SceneInfo.MoveAllow)
                        {
                            GameObject hero = raycastHit.collider.gameObject;      
                            Vector3 pos = hero.transform.position;
                            hero.transform.position = new Vector3(pos.x, 4, pos.z);
                            hero.GetComponent<Rigidbody>().useGravity = false;
                            SceneInfo.MoveAllow = true;
                            SceneInfo.MoveMe = hero;
                        }
                        else if (raycastHit.collider.tag == "Cell")
                        {
                            if (SceneInfo.MoveAllow)
                            {
                                GameObject cell = raycastHit.collider.gameObject;
                                int[] ij = WhichCell(cell);
                                int[] ij_hero =  SceneInfo.MoveMe.GetComponent<HeroInfo>().ij;
                                if (SpaceOnScene.IsTheiFree(ij) || ij[0]==ij_hero[0] && ij[1] == ij_hero[1])
                                {
                                    Vector3 pos = cell.transform.position;
                                    SceneInfo.MoveMe.transform.position = new Vector3(pos.x, 4, pos.z);
                                    SceneInfo.MoveMe.transform.eulerAngles = new Vector3(0, 0, 0);
                                    SceneInfo.MoveMe.GetComponent<Rigidbody>().useGravity = true;
                                    SpaceOnScene.FreeSpace[ij[0], ij[1]] = 1;
                                    SpaceOnScene.FreeSpace[ij_hero[0], ij_hero[1]] = 0;
                                    ij_hero[0] = ij[0];
                                    ij_hero[1] = ij[1];
                                    SceneInfo.MoveAllow = false;
                                    SceneInfo.MoveMe = null;
                                }
                            }
                            else if (SceneInfo.AddAllow)
                            {
                                GameObject cell = raycastHit.collider.gameObject;
                                int[] ij = WhichCell(cell);
                                if (SpaceOnScene.IsTheiFree(ij))
                                {
                                    Vector3 pos = cell.transform.position;
                                    GameObject go = Instantiate(SceneInfo.AddMe, new Vector3(pos.x, 4, pos.z), Quaternion.identity);
                                    go.tag = "Hero";
                                    go.transform.eulerAngles = new Vector3(0, 0, 0);
                                    SpaceOnScene.FreeSpace[ij[0], ij[1]] = 1;
                                    MyMoney.Cash -= SceneInfo.Cost;
                                    UnityEngine.UI.Text money = GameObject.Find("MoneyInfo").GetComponent<UnityEngine.UI.Text>();
                                    money.text = MyMoney.Cash.ToString();
                                    //Добавление класса обьекту
                                    go.AddComponent<HeroInfo>().ij = ij;
                                    SceneInfo.AddAllow = false;
                                    SceneInfo.AddMe = null;
                                }
                            }
                        }
                    }
                    break;
                //case TouchPhase.Moved:
                //    Debug.Log("Something Hit and drag " + MoveAllowed);
                //    if (MoveAllowed)
                //    {
                //        print("I try 2 move");
                //        // gameObject.transform.position += new Vector3((float)(touchPos.x- deltax), 0, (float)(touchPos.y - deltay));
                //        touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                //        Vector2 dx = touch.deltaPosition;
                //        double dt = touch.deltaTime;
                //        gameObject.transform.position = new Vector3(dx.x * 0.1f, 4, dx.y * 0.1f);
                //        gameObject.transform.eulerAngles = new Vector3(0, 0, 0);

                //    }
                //    break;
                //case TouchPhase.Ended:
                //    MoveAllowed = false;
                //    break;

            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="cell"></param>
    /// <returns></returns>
    private int[] WhichCell(GameObject cell)
    {
        string name = cell.name;
        return new int[2] { int.Parse(name[6].ToString())-1, int.Parse(name[8].ToString()) -1};
    }
}
