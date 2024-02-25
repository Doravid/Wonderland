using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileAccess : MonoBehaviour
{
    private string spaceA = "\u0020";
    // Update is called once per frame
    void Update()
    {
        string witnessReport = "Witness" + spaceA + "Report.txt";
        string chemistryAnalysis = "Chemistry" + spaceA + "Analysis.txt";
        string suspectList = "Suspect" + spaceA + "List.txt";
        string sceneLog = "Scene" + spaceA + "Log.txt";
        string fingerprintRecords = "Fingerprint" + spaceA + "Records.txt";
        string culprit = "Culprit" + spaceA + ".txt";
        //Check Witness Report
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + witnessReport)) 
        {
            Debug.Log(witnessReport + " Exists");
        }
        //Check Chemistry
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + chemistryAnalysis))
        {
            Debug.Log(chemistryAnalysis + " Exists");
        }
        //Check Suspect List
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + suspectList))
        {
            Debug.Log(suspectList + " Exists");
        }
        //Check Scene Log
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + sceneLog))
        {
            Debug.Log(sceneLog + " Exists");
        }
        //Check Fingerprint Records
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + fingerprintRecords))
        {
            Debug.Log(fingerprintRecords + " Exists");
        }   
        //Check Culprit
        if (File.Exists(@System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Desktop\Investigation\" + culprit))
        {
            Debug.Log(culprit + " Exists");
        }
    }
        
        



    }

