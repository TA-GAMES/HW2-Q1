using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component makes its object go
 * big and small like a beaten heart
 */

public class BeatenHeart : MonoBehaviour
{
    bool goBig = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x >= 1.5f)
            goBig = false;
        if (transform.localScale.x <= 0.5f)
            goBig = true;
       
        if (goBig)
            transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y + 0.01f, transform.localScale.z);
        else if (!goBig)
            transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f, transform.localScale.z);
        
    }
}
