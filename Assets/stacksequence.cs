using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stacksequence : MonoBehaviour
{
    public TransparentWindow tw;
    public bippyScript BS;

    public GameObject CarryingFolder;
    public GameObject Instructions;

    public void One()
    {
        BS.BippySay("You failed to complete the captcha...", 1);
    }

    public void Two()
    {
        BS.BippySay("That can only mean one thing...", 2);
    }

    public void Three()
    {
        BS.BippySay("You just need to try again!", 0);
    }

    public void StartStack()
    {
        tw.WindowsMessage("Start the captcha.", "Prompt", 0);
        Instructions.SetActive(true);
        BS.transform.GetChild(0).gameObject.SetActive(false);
        CarryingFolder.SetActive(true);
        Destroy(gameObject);
    }
}
