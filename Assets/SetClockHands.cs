using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetClockHands : MonoBehaviour
{
    [SerializeField] private GameObject _minuteHand;
    [SerializeField] private GameObject _hourHand;
    [SerializeField] private GameObject _pivot;

    private const float HourToDegree = 30F;
    private const float MinuteToDegree = 6F;

    private uint _hour = 0;
    private uint _minute = 0;




    // Start is called before the first frame update
    void Start()
    {
        this._hour = 9;
        this._minute = 35;

        this._minuteHand.transform.RotateAround(this._pivot.transform.position, Vector3.forward, this._minute * MinuteToDegree);
        this._hourHand.transform.RotateAround(this._pivot.transform.position, Vector3.forward, this._hour * HourToDegree);
    }

}
