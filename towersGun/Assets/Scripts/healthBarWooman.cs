using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarWooman : MonoBehaviour
{
    public Slider slider;
    public healthWooman playerHealth;

    private void Start()
    {
        SetMaxHealth(playerHealth.maxHp);
    }

    private void Update()
    {
        SetHealth(playerHealth.currentHp);
    }

    public void SetMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void SetHealth(int hp)
    {
        slider.value = hp;
    }
}
