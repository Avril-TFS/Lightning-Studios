using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ScrollingText : MonoBehaviour
{

    public float speed = 15;

    void Update()
    {
        transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
    }
}
