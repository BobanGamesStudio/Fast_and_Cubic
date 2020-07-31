using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicQuality : MonoBehaviour
{
    

    UnityEngine.Color color;
    private void Start() 
    {
        string[] names = QualitySettings.names;
        SetColor(names);
    }

    public void LowQual()
    {
        QualitySettings.SetQualityLevel(0, true);
        string[] names = QualitySettings.names;
        SetColor(names);
    }
    public void MediumQual()
    {
        QualitySettings.SetQualityLevel(1, true);
        string[] names = QualitySettings.names;
        SetColor(names);
    }
    public void UltraQual()
    {
        QualitySettings.SetQualityLevel(2, true);
    }
    private void Update() {
        string[] names = QualitySettings.names;
        SetColor(names);
    }

    private void SetColor(string[] names)
    {
        int qualityLevel = QualitySettings.GetQualityLevel();
        
        if(names[qualityLevel] == gameObject.name)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            
            cb.normalColor = new Color(215/255f, 215/255f, 215/255f);
            gameObject.GetComponent<Button>().colors = cb;
        }
        else
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(1f, 1f, 1f);
            gameObject.GetComponent<Button>().colors = cb;
        }
    }
}
