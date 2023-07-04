using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    int countDownStartValue;
    public Text timmer;
    public GameObject gamepanel;
    public Text pointtext;
    public static int countstart1 = 300, countstart2 = 180, countstart3 = 120;
    public void Start()
    {
        countDownTimer();
    }

   void countDownTimer()
    {   //timer for easy level
        if (SAVESELECTEDTOGGLE.togglevalue == 0.10f)
        {

            if (countstart1 > 0)
            {   //it is taking seconds as a perimeter and converting it into minutes : seconds format
                TimeSpan spanTime = TimeSpan.FromSeconds(countstart1);
                timmer.text = "TIMER : " + spanTime.Minutes + ":" + spanTime.Seconds;
                countstart1--;
                Invoke("countDownTimer", 1.0f);
            }
            else
            {
                Playfield.uncoverMines();

                // game over
                print("you lose");
                pointtext.text = Element.score.ToString() + " POINTS";
                gamepanel.SetActive(true);
            }
        }
        //timer for medium level
        else if (SAVESELECTEDTOGGLE.togglevalue == 0.20f)
        {

            if (countstart2 > 0)
            {
                TimeSpan spanTime = TimeSpan.FromSeconds(countstart2);
                timmer.text = "TIMER : " + spanTime.Minutes + ":" + spanTime.Seconds;
                countstart2--;
                Invoke("countDownTimer", 1.0f);
            }
            else
            {
                Playfield.uncoverMines();

                // game over
                print("you lose");
                pointtext.text = Element.score.ToString() + " POINTS";
                gamepanel.SetActive(true);
            }
        }
        //timer for hard level
        else if (SAVESELECTEDTOGGLE.togglevalue == 0.30f)
        {

            if (countstart3 > 0)
            {
                TimeSpan spanTime = TimeSpan.FromSeconds(countstart3);
                timmer.text = "TIMER : " + spanTime.Minutes + ":" + spanTime.Seconds;
                countstart3--;
                Invoke("countDownTimer", 1.0f);
            }
            else
            {
                Playfield.uncoverMines();

                // game over
                print("you lose");
                pointtext.text = Element.score.ToString() + " POINTS";
                gamepanel.SetActive(true);
            }
        }

    }
}