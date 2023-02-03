using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
 

public class Toolsc : MonoBehaviour
{
    public GameObject tooltip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          //  tooltip.SetActive();
        }
    }
}