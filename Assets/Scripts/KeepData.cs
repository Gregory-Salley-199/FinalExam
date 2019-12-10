using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class KeepData : MonoBehaviour
{
    public static string Name = "Anonymous";
    public static float Speed;
    public static float Size;
    public static float Time;

    public InputField PlayerName;
    public Dropdown SpeedDropdown;
    public Dropdown TimeDropdown;
    public Slider SizeSlider;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        Name = PlayerName.text;
    }

    public void ChangeSpeed()
    {
        Speed = SpeedDropdown.value;
       
    }

    public void ChangeSize()
    {
        Size = SizeSlider.value;
    }

    public void ChangeTime()
    {
        Time = TimeDropdown.value;
    }

}
