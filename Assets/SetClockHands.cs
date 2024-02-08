using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SetClockHands : MonoBehaviour
{
    [SerializeField] private GameObject _minuteHand;
    [SerializeField] private GameObject _hourHand;
    [SerializeField] private GameObject _pivot;

    private const float HourToDegree = 30F;
    private const float MinuteToDegree = 6F;
    private bool moved = false;

    [SerializeField]
    private uint _hour = 0;
    [SerializeField]
    private uint _minute = 0;


    void MoveToCorrectPosition()
    {
        this._minuteHand.transform.RotateAround(this._pivot.transform.position, Vector3.forward, this._minute * MinuteToDegree);
        this._hourHand.transform.RotateAround(this._pivot.transform.position, Vector3.forward, this._hour * HourToDegree);
    }

    void MoveToDefaultPosition()
    {
        this._minuteHand.transform.RotateAround(this._pivot.transform.position, Vector3.forward,  -this._minute * MinuteToDegree);
        this._hourHand.transform.RotateAround(this._pivot.transform.position, Vector3.forward, -this._hour * HourToDegree);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    async void OnCollisionEnter(Collision collision)
    {
        if (this.moved)
        {
            return;
        }

        this.moved = true;
        this.MoveToCorrectPosition();
        await Task.Delay(2000);
        MoveToDefaultPosition();
        this.moved = false;
    }

}
