using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenWrap : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x > 11)
        {
            transform.position = new Vector3(-11, transform.position.y, 0);
        }
        
        else if(transform.position.x < -11)
        {
            transform.position = new Vector3(11, transform.position.y, 0);
        }
        else if ( transform.position.y > 5.5)
        {
            transform.position = new Vector3 (transform.position.x, -5, 0);
        }
        else if (transform.position.y < -5.5)
        {
            transform.position = new Vector3(transform.position.x, 5, 0);
        }
    }
}
