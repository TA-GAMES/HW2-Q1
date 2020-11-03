using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component alows the user make object
 * to be showen and hide by mouse click
 */

public class HideAndShown : MonoBehaviour
{
    public GameObject obj;
    bool isShowen = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isShowen)
        {
            obj.GetComponent<Renderer>().enabled = false;
            isShowen = false;
        }
        
        else if (Input.GetMouseButtonDown(0) && !isShowen)
        {
            obj.GetComponent<Renderer>().enabled = true;
            isShowen = true;
        }
    }
}
