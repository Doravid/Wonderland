using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    public GameObject Bippy;
    public GameObject CrashScreen;
    public GameObject RestartVid;

    public void StartupFunc()
    {
        RestartVid.SetActive(false);
        Bippy.SetActive(true);
    }
    public void RestartScreen()
    {
        CrashScreen.SetActive(false);
        RestartVid.SetActive(true);
        Invoke("StartupFunc", 29);
    }
    public void Crash()
    {
        CrashScreen.SetActive(true);
        Invoke("RestartScreen", 0.5f);
    }

    void Start()
    {
        Crash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
