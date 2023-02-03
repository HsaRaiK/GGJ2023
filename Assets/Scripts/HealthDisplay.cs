using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Text textBox;
    void Start()
    {
        textBox = GetComponent<Text>();
    }
    void Update()
    {
        textBox.text = "Player Health : " + PlayerHealth.health;
        
    }
}
