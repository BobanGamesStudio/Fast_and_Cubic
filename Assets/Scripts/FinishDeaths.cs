using UnityEngine.UI;
using UnityEngine;

public class FinishDeaths : MonoBehaviour
{
    public Text deathsText;
    // Start is called before the first frame update
    void Update()
    {   
        deathsText.text = GameData.PlayerDeaths.ToString();
    }
    
}
