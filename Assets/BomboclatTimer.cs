using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class BomboclatTimer : MonoBehaviour
{
    [SerializeField] private int Timer = 10;
    private float _startTime;
    private TextMeshPro _text;

    void Start()
    {
        _startTime = Time.time;
        _text = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        var currentTime = (int)(Timer - (Time.time - _startTime));
        _text.text = currentTime.ToString(CultureInfo.InvariantCulture);
    }
}
