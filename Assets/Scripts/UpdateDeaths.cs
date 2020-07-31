using UnityEngine.UI;
using UnityEngine;
public class UpdateDeaths : MonoBehaviour
{
    public Text deathsText;

    // Update is called once per frame
    void Update()
    {
        deathsText.text = GameData.PlayerDeaths.ToString();
    }
    
}

