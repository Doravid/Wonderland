using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentWindow : MonoBehaviour
{
    [DllImport("user32.dll")]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    void Start()
    {
        Debug.Log("hello");
        MessageBox(new IntPtr(0), "Sussy Baka", "The other thing", 0);
    }
}
