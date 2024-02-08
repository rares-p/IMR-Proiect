using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Safe : MonoBehaviour
{
    private GameObject _safeDoor;
    [SerializeField] private GameObject _pliers;

    void Start()
    {
        _safeDoor = this.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        
    }

    public void OpenSafe()
    {
        _safeDoor.transform.RotateAround(_safeDoor.transform.position, Vector3.down, 90);
        _pliers.SetActive(true);
    }
}
