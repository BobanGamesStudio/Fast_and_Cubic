using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class UpdateTime : MonoBehaviour
{
    public Text hourText, minuteText, secondText, milisecondText;
    private float t;

    // Update is called once per frame
    void Update()
    {   
        t = GameData.GameTime;
        hourText.text =         (Mathf.Floor(t/3600)).ToString("0") + ":";
        minuteText.text =       (Mathf.Floor((t%3600)/60)).ToString("0") + ":";
        secondText.text =       (t%60).ToString("0") + ":";
        milisecondText.text =   ((t*100)%100).ToString("0");
    }
}
