using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weigh : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _weightText;
    private readonly Dictionary<string, uint> _weights = new()
    {
        {"basketball", 560},
        {"rubber_duck", 752},
        {"shoe", 320},
        {"potion", 310},
        {"flashlight", 542},
        {"remote", 561}
    };
    private uint _weight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Obiect Detectat");
        tag = collision.gameObject.tag;
        Debug.Log(tag);
        if (_weights.ContainsKey(tag))
            _weight += _weights[tag];
        _weightText.text = $"{_weight} G";
    }

    void OnCollisionExit(Collision collision)
    {
        tag = collision.gameObject.tag;
        if (_weights.ContainsKey(tag))
            _weight -= _weights[tag];
        _weightText.text = $"{_weight} G";
    }
}
