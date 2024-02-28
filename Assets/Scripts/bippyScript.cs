using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class bippyScript : MonoBehaviour
{
    int index;
    public string[] messagelist;
    public int[] facelist;
    public GameObject TextBubble;
    public TMP_Text txt;
    public Image Sprite;
    public Sprite[] Faces;

    public void ShowTextBox(bool progress)
    {
        TextBubble.SetActive(true);
        if (progress == true)
        {
            Next();
        }
    }

    public void BippySay(string message, int Face)
    {
        Sprite.sprite = Faces[Face];
        ShowTextBox(false);
        txt.text = message;
    }
    public void Next()
    {
        BippySay(messagelist[index], facelist[index]);
        index ++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
