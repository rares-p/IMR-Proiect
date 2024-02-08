using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBox : MonoBehaviour
{
    [SerializeField] private GameObject _redWire;
    [SerializeField] private GameObject _blueWire;
    [SerializeField] private GameObject _greenWire;
    [SerializeField] private GameObject _yellowWire;
    [SerializeField] private GameObject _cover;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UncoverBox()
    {
        _cover.SetActive(false);
    }
}
