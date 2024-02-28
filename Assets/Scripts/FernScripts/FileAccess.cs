using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Video;

public class FileAccess : MonoBehaviour
{
    public GameObject rickRoll, jumpScareVideo;
    private bool rickRolled = false;
    private float rickrollTimer = 8f;

    private bool endingStarted = false;
    private float jumpscareTimer = 7.5f;
    private float endingTimer = 4f;
    private bool finalEnd = false;
    private bool hasSpammedError = false;
    private string spaceA = "\u0020";


    // Update is called once per frame
    void Update()
    {
        if (rickRolled) 
            rickrollTimer -= Time.deltaTime;
        
        if (endingStarted)
        {
            jumpscareTimer -= Time.deltaTime;
        }
        if (finalEnd)
        {
            endingTimer -= Time.deltaTime;
        }
        if(endingTimer <= 0)
        {
            Application.Quit();
        }
        if (rickrollTimer <= 0 &&  rickRoll.activeSelf)
        {
            Debug.Log("Deactivate");
            rickRoll.SetActive(false);
        }
        if(jumpscareTimer <= 0 && !jumpScareVideo.activeSelf)
        {
            jumpScareVideo.SetActive(true);
            GetComponent<TransparentWindow>().WindowsMessage("WARNING", "its too late", 0);
            finalEnd = true;
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            spamErorrs();
        }
    string suspectList = "Suspect_List.txt";
    string fingerprintRecords = "Fingerprint_Records.txt";
    string culprit = "Culprit_.txt";
        //Check Suspect List
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + suspectList) && !hasSpammedError)
        {
            hasSpammedError = true;
            spamErorrs();
        }
        //Check Fingerprint Records
        if (!rickRolled && File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + fingerprintRecords))
        {
            rickRolled = true;
            rickRoll.SetActive(true);
            rickRoll.GetComponent<VideoPlayer>().Play();
        }   
        //Check Culprit
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + culprit) && !endingStarted)
        {
            jumpScare();
        }



    }
    private void jumpScare()
    {
        endingStarted = true;
    }

    private void spamErorrs()
    {
        for(int i = 0; i < 9; i++)
        {
            GetComponent<TransparentWindow>().WindowsMessage("CAUTION", "CAUTION", 0);
        }
        GetComponent<TransparentWindow>().WindowsMessage("caution", "bippy was here", 0);
    }


}

