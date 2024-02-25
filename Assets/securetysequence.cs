using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class securetysequence : MonoBehaviour
{
    public bippyScript BS;

    public void One()
    {
        BS.BippySay("You failed the seccond caption?! How?? that was so easy!", 1);
    }

    public void Two()
    {
        BS.BippySay("Thats it! you must not actually BE human.", 3);
    }

    public void Three()
    {
        BS.BippySay("I must encrypt these files to protect them from malicious software like you.", 1);
    }

    public void EndSequence()
    {
        //End sequence here
        BS.transform.GetChild(0).gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
