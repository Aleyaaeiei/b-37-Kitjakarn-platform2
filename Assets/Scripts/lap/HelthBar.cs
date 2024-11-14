using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthBar : MonoBehaviour
{
    //Helth bar

    public Slider slider;


    public void UpdateHealthBar(int currentHp) 
    {
        slider.value = currentHp;
    }

    public void SetMaxHP(int maxHp)
    {
        slider.maxValue = maxHp;
    }

}
