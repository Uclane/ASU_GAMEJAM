using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.gameObject == gameObject)
                {
                    Debug.Log("1");
                }
            }
        }
       */
    }
    public void Onclick()
    {
        Debug.Log("Clicked");
    }
}