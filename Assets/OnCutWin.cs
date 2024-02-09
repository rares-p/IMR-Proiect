using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCutWin : MonoBehaviour
{
    public UnityEvent OnWireCut;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "pliers")
            OnWireCut?.Invoke();
    }
}
