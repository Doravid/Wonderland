using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crashsequence : MonoBehaviour
{
    public GameObject Intro;
    public bippyScript BS;
    public TransparentWindow tw;
    public GameObject Bippy;

    public void Errors()
    {
        tw.WindowsMessage("A critical internal windows error occured, please restart your computer.", "Catostrophic error", 0);
        tw.WindowsMessage("Restart failed, try again?", "Error", 0);
        tw.WindowsMessage("No.", "Error", 0);
        tw.WindowsMessage("Won't work.", "Error", 0);
        tw.WindowsMessage("Initiating B.I.P.P.Y sequence...", "Error", 0);
        tw.WindowsMessage("Updating Windows...", "Error", 0);
    }
    public void EndCrashSequence()
    {
        Bippy.SetActive(true);
        BS.BippySay("Hi there, I'm Bippy! Bippy the Robo-Buddy!", 0);
        Intro.SetActive(true);
        Destroy(gameObject);
    }
}
