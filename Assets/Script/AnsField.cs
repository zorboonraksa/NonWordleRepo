using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnsField : MonoBehaviour
{
    public TextMeshProUGUI ansLetter;
    public Image fieldImage;
    
    void Awake() 
    {
        ansLetter.text = ""; 
    }

    public void GetLetter(string letter)
    {
        ansLetter.text = letter;
    }

    public void ChangeColor(CheckingState checkCase)
    {
        switch (checkCase)
        {
            case CheckingState.Correct:
                fieldImage.color = new Color(0.6745098f,0.8392157f,0.2117647f,1);
                break;
            case CheckingState.WrongIndex:
                // fieldImage.color = new Color(0.7647059f,0.9882353f,0.172549f,1);
                fieldImage.color = new Color(0,0,1,1);
                break;
            case CheckingState.Wrong:
                fieldImage.color = new Color(0.6037736f,0.5718761f,0.5718761f,1);
                break;       
        }
    }
}
