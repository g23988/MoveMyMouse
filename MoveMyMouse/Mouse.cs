using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MoveMyMouse
{
    static public class Mouse
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern Int32 SendInput(Int32 cInputs, ref INPUT pInputs, Int32 cbSize);

        [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
        public struct INPUT
        {
            [FieldOffset(0)]
            public INPUTTYPE dwType;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBOARDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct MOUSEINPUT
        {
            public Int32 dx;
            public Int32 dy;
            public Int32 mouseData;
            public MOUSEFLAG dwFlags;
            public Int32 time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct KEYBOARDINPUT
        {
            public Int16 wVk;
            public Int16 wScan;
            public KEYBOARDFLAG dwFlags;
            public Int32 time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct HARDWAREINPUT
        {
            public Int32 uMsg;
            public Int16 wParamL;
            public Int16 wParamH;
        }

        public enum INPUTTYPE : int
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }
        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);



        [Flags()]
        public enum MOUSEFLAG : int
        {
            MOVE = 0x1,
            LEFTDOWN = 0x2,
            LEFTUP = 0x4,
            RIGHTDOWN = 0x8,
            RIGHTUP = 0x10,
            MIDDLEDOWN = 0x20,
            MIDDLEUP = 0x40,
            XDOWN = 0x80,
            XUP = 0x100,
            VIRTUALDESK = 0x400,
            WHEEL = 0x800,
            ABSOLUTE = 0x8000
        }

        [Flags()]
        public enum KEYBOARDFLAG : int
        {
            EXTENDEDKEY = 1,
            KEYUP = 2,
            UNICODE = 4,
            SCANCODE = 8
        }

        public enum MouseEventTFlags
        { 
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x000000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        
        static public void LeftClick()
        {
            //LeftDown();
            mouse_event((int)(MouseEventTFlags.LEFTDOWN), 0, 0, 0, IntPtr.Zero);  // 按下

            //LeftUp();
            mouse_event((int)MouseEventTFlags.LEFTUP, 0, 0, 0, IntPtr.Zero); // 起來 
        }
    }
}
