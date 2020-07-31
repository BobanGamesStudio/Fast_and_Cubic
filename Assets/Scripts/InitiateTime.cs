using UnityEngine;
using System.Collections.Generic;

public class InitiateTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameData.GameTime = 0.0f;
        GameData.PlayerDeaths = 0;
    }

}
