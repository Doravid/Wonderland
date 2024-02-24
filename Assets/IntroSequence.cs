using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSequence : MonoBehaviour
{
    public bippyScript BS;
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
        //start it here
    }
}
