using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodySleep : MonoBehaviour
{
    private int sleepCountdown = 4;
    private Rigidbody rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if(sleepCountdown > 0)
        {
            rigid.Sleep();
            sleepCountdown--;
        }
    }
}
