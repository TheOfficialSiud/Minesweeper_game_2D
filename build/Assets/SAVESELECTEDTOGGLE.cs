using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SAVESELECTEDTOGGLE : MonoBehaviour
{
    public Toggle toggle1, toggle2, toggle3;
    public static float togglevalue = 0.1f;
    // Start is called before the first frame update
    void Awake()
    {
        if (togglevalue == 0.10f)
        {
            toggle1.isOn = true;
            toggle2.isOn = false;
            toggle3.isOn = false;

        }
        else if (togglevalue == 0.20f)
        {
            Debug.Log("medium called");
            toggle1.isOn = false;
            toggle2.isOn = true;
            toggle3.isOn = false;
            

        }
        else if (togglevalue == 0.30f)
        {
            Debug.Log("hard called");
            toggle1.isOn = false;
            toggle2.isOn = false;
            toggle3.isOn = true;

        }
    }
    //using toggle difficulty level is being set here
    public void Toggle1Selected()
    {
        togglevalue = 0.10f;

    }
    public void Toggle2Selected()
    {
        togglevalue = 0.20f;

    }
    public void Toggle3Selected()
    {
        togglevalue = 0.30f;

    }
}