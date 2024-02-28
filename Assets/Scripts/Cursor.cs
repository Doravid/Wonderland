using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public GameObject CursorObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CursorObj.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CursorObj.transform.position = new Vector3(CursorObj.transform.position.x, CursorObj.transform.position.y, 0);
    }
}
