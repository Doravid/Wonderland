using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentWindow : MonoBehaviour
{

    [DllImport("user32.dll")]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    [DllImport("user32.dll")]
    public static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    public static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    [DllImport("user32.dll")]
    public static extern int SetLayeredWindowAttributes(IntPtr hWnd, uint crkey, byte bAlpha, uint dwFlags);

    public struct MARGINS {
        public int cxLeftWidth;
        public int cxRightWidth;

        public int cyTopHeight;
        public int cyBottomHeight;
    }

    [DllImport("Dwmapi.dll")]
    public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);

    const int GWL_EXSTYLE = -20;
    const uint WS_EX_LAYERED = 0x00080000;
    const uint WS_EX_TRANSPARENT = 0x00000020;

    static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

    const uint LWA_COLORKEY = 0x00000001;

    public void WindowsMessage(string message, string title, uint typeofmessage)
    {
        MessageBox(new IntPtr(0), message, title, typeofmessage);
    }

    void Start()
    {
        IntPtr hWnd = GetActiveWindow();

        #if !UNITY_EDITOR
        MARGINS margins = new MARGINS {cxLeftWidth = -1};
        DwmExtendFrameIntoClientArea(hWnd, ref margins);

        SetWindowLong(hWnd, GWL_EXSTYLE, WS_EX_LAYERED);
        SetLayeredWindowAttributes(hWnd, 0, 0, LWA_COLORKEY);

        SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, 0);

        #endif

        Application.runInBackground = true;
    }
}
