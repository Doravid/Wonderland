using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class bippyScript : MonoBehaviour
{
    public GameObject TextBubble;
    public TMP_Text txt;
    public Image Sprite;
    public Sprite[] Faces;
    public void BippySay(string message, int Face)
    {
        Sprite.sprite = Faces[Face];
        TextBubble.SetActive(true);
        txt.text = message;
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
