using UnityEngine.UI;
using UnityEngine;

public class FinishTime : MonoBehaviour
{
    public Text timeText;
    private float t;
    // Start is called before the first frame update
    void Update()
    {   
        t = GameData.GameTime;
        timeText.text = (t/3600).ToString("0") + ":" + ((t%3600)/60).ToString("0") + ":" + (t%60).ToString("0") + ":" + ((t*100)%100).ToString("0");
    }
    
}
