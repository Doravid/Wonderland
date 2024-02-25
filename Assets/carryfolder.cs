using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carryfolder : MonoBehaviour
{
    public GameObject Instructions;
    public GameObject RecycleBin;
    public GameObject SafetyFloor;
    public GameObject SecuretySequence;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (SafetyFloor != null && col.gameObject.name == "CursorObject")
        {
            Destroy(SafetyFloor);
        }
        
        if (col.gameObject.name == "GameFloor")
        {
            SecuretySequence.SetActive(true);
            Destroy(RecycleBin);
            Destroy(Instructions);
            Destroy(gameObject);
        }
    }
}
