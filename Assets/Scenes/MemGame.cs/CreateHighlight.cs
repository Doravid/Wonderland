using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHighlight : MonoBehaviour
{
    public GameObject highlight;
public void createHighlight()
    {
        Debug.Log(highlight.name);
        Debug.Log(highlight == null);
        Instantiate(highlight, this.transform.position, this.transform.rotation, this.transform);



    }

}
