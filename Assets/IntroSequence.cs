using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
    public TransparentWindow tw;
    public bippyScript BS;

    public void NegativeOne()
    {
        BS.BippySay("Hi there, I'm Bippy! Bippy the Robo-Buddy!", 0);
    }
    public void One()
    {
        BS.BippySay("I am your new A.I assistant, I can help you with anything you need on windows!", 3);
    }

    public void Two()
    {
        BS.BippySay("But first, I need you to complete this captcha to prove you are human.", 0);
    }

    public void StartCaptcha()
    {
        tw.WindowsMessage("Start the captcha.", "Prompt", 0);
        //Start captcha here
    }
}
