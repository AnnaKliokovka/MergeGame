using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveMe : MonoBehaviour
{
    public void Update()
    {
        //if (Input.touchCount>0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

        //    switch(touch.phase)
        //    {
        //        case TouchPhase.Began:
        //            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //            RaycastHit raycastHit;
        //            if (Physics.Raycast(raycast, out raycastHit))
        //            {
        //                Debug.Log("Something Hit " + raycastHit.collider.name);
        //                if (raycastHit.collider.name == gameObject.name)
        //                {
        //                    print("Enemy");
                            
        //                    SceneInfo.MoveAllowed = true;
        //                }                       
        //            }
        //            break;
        //        case TouchPhase.Moved:                    
        //                Debug.Log("Something Hit and drag "+ MoveAllowed);
        //                if (MoveAllowed)
        //                {
        //                    print("I try 2 move");
        //                // gameObject.transform.position += new Vector3((float)(touchPos.x- deltax), 0, (float)(touchPos.y - deltay));
        //                    touchPos = Camera.main.ScreenToWorldPoint(touch.position);
        //                Vector2 dx = touch.deltaPosition;
        //                double dt = touch.deltaTime;
        //                    gameObject.transform.position = new Vector3(dx.x*0.1f, 4, dx.y * 0.1f);
        //                gameObject.transform.eulerAngles = new Vector3(0,0,0);
                        
        //                }
        //            break;
        //        case TouchPhase.Ended:
        //            MoveAllowed = false;
        //            break;

        //    }
        //}    
    }

}
