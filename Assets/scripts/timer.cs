using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Image timerbar;
    public static float maxtime;
    public static float timelift;
    public float time_to_end = 1;
    //private GameConterolerFromMenu gp;

    public void Awake()
    {
        maxtime = time_to_end;
        timerbar = GetComponent<Image>();
        timelift = maxtime;
        //gp = GameObject.Find("Gameplay Controller gp").GetComponent<GameConterolerFromMenu>();
    }


    void Update()
    {
        //
        if (timelift > 0)
        {
            timelift -= Time.deltaTime;
            timerbar.fillAmount = timelift / maxtime;

        }
    }

}