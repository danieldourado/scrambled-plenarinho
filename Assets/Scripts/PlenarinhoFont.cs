using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class PlenarinhoFont : MonoBehaviour
{
    [SerializeField] int fontSize = 20; 
    [SerializeField] int charLimit = 140; 
    Text text;
    string originalText;
    void Awake()
    {
        text = GetComponent<Text>();
        originalText = text.text;
    }
    void Update()
    {
        if(charLimit < 1) charLimit = 1;
        if(fontSize < 1) fontSize = 1;
        
        text.resizeTextForBestFit = false;
        text.fontSize = fontSize;
        text.text = originalText.Substring(0, charLimit);
    }
}
