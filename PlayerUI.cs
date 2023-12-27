using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI: MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounter;
    public Slider healthSlider;

    // Update is called once per frame
    void Update()
    {
        healthSlider.maxValue = player.MAXhealth;
        healthSlider.value = player.health;

        coinsCounter.text = player.coins.ToString();
        
    }
}
