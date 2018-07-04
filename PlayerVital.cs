using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerVital : MonoBehaviour
{
    public Slider EnergySlider;
    public int maxEnergy;
    public int EnergyFallRate;

    public Slider CO2Slider;
    public int maxCO2;
    public int CO2FallRate;

    public Slider comfortSlider;
    public int maxcomfort;
    public int ComfortFallRate;

    void Start()
    {
        EnergySlider.maxValue = maxEnergy;
        EnergySlider.value = maxEnergy;

        CO2Slider.maxValue = maxCO2;
        CO2Slider.value = maxCO2;

        comfortSlider.maxValue = maxcomfort;
        comfortSlider.value = maxcomfort;
    }

    void Update()
    {
        //ENERGY CONTROL SECTIONs
        if (EnergySlider.value >= 0)
        {
            EnergySlider.value -= EnergySlider.value-EnergyFallRate;
        }

        if (EnergySlider.value <= 0)
        {
            CharacterDeath();
        }
     

        //CO2 CONTROL SECTION
            if (CO2Slider.value <= 0)
        {
            CO2Slider.value -= Time.deltaTime + CO2FallRate;
        }

        //if (CO2Slider.value <= 0)
        //{
        //    CO2Slider.value = 0;
        //}

        //COMFORT CONTROL SECTION
        if (comfortSlider.value >= 0)
        {
            comfortSlider.value -= comfortSlider.value - ComfortFallRate * 5;
        }

        if (comfortSlider.value <= 0)
        {
            comfortSlider.value = 0;
        }

    }

    void CharacterDeath()
    {
        //Application.LoadLevel("");
    }
}
