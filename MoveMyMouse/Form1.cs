using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MoveMyMouse
{
    

    public partial class Form1 : Form
    {

        Point after = Cursor.Position;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = (CheckYourMouse.Interval / 1000).ToString();
            //KeyboardHook.globalControlOnly = false;  //只有Global KeyDown會起作用，其他程式不能攔截鍵盤事件
            //KeyboardHook.GlobalKeyDown += KeyboardHook_KeyDown; 
        }

        private void CheckYourMouse_Tick(object sender, EventArgs e)
        {
            //
            //listBox1.Items.Add(v.ToString());
            //listBox1.Items.Add(after.ToString());
            //if (v != after)
            //{
                
            //    
            //}
            
            //如果mouse 的位置跟三分鐘前的一樣
            //就啟動
            Point before = Cursor.Position;
            if(after == before){
                Point v = Cursor.Position;
                MoveMouse(v);
            }



          
        }
        private void changebackcolor_Tick(object sender, EventArgs e)
        {
            checkbackgroup();
            try
            {
                KeyboardHook.GlobalKeyDown += KeyboardHook_KeyDown;
            }
            catch (Exception)
            {
                GC.Collect();
            }
             
            
        }

        private void checkbackgroup() { 
            Point before = Cursor.Position;

            if(before == after ){
                panel1.BackColor = System.Drawing.Color.Peru;
                //this.BackColor = System.Drawing.Color.Pink;
                CheckYourMouse.Enabled = true;
                
                
            }
            else
            {
                panel1.BackColor = System.Drawing.Color.SeaGreen;
                //this.BackColor = System.Drawing.Color.SpringGreen;
                after = before;
                CheckYourMouse.Enabled = false;
                label1.Text = (CheckYourMouse.Interval / 1000).ToString();
            }
            
        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label1.Text) > 0)
            {
                label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
            }
        }


        private void MoveMouse(Point v) {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Point back = Cursor.Position;
            Cursor.Position = new Point(Cursor.Position.X - 10000, Cursor.Position.Y + 10000);
           // Cursor.Clip = new Rectangle(this.Location, this.Size);
            //Cursor.Position = new Point(-200,1000);
            Thread.Sleep(300);
            MoveMyMouse.Mouse.LeftClick();
            Thread.Sleep(600);
            MoveMyMouse.Mouse.LeftClick();
            Cursor.Position = new Point(back.X, back.Y);
            label1.Text = (CheckYourMouse.Interval / 1000).ToString();
            //自我毀滅並啟動(對應記憶體爆量)
            Application.ExitThread();
            Thread thtmp = new Thread(new ParameterizedThreadStart(run));
            object appName = Application.ExecutablePath;
            Thread.Sleep(1);
            thtmp.Start(appName);
            
        }

        static public void LeftDown()
        {
            MoveMyMouse.Mouse.INPUT leftdown = new MoveMyMouse.Mouse.INPUT();

            leftdown.dwType = 0;
            leftdown.mi = new MoveMyMouse.Mouse.MOUSEINPUT();
            leftdown.mi.dwExtraInfo = IntPtr.Zero;
            leftdown.mi.dx = 0;
            leftdown.mi.dy = 0;
            leftdown.mi.time = 0;
            leftdown.mi.mouseData = 0;
            leftdown.mi.dwFlags = MoveMyMouse.Mouse.MOUSEFLAG.LEFTDOWN;

            MoveMyMouse.Mouse.SendInput(1, ref leftdown, Marshal.SizeOf(typeof(MoveMyMouse.Mouse.INPUT)));
        }
        static public void LeftUp()
        {
            MoveMyMouse.Mouse.INPUT leftup = new MoveMyMouse.Mouse.INPUT();

            leftup.dwType = 0;
            leftup.mi = new MoveMyMouse.Mouse.MOUSEINPUT();
            leftup.mi.dwExtraInfo = IntPtr.Zero;
            leftup.mi.dx = 0;
            leftup.mi.dy = 0;
            leftup.mi.time = 0;
            leftup.mi.mouseData = 0;
            leftup.mi.dwFlags = MoveMyMouse.Mouse.MOUSEFLAG.LEFTUP;

            MoveMyMouse.Mouse.SendInput(1, ref leftup, Marshal.SizeOf(typeof(MoveMyMouse.Mouse.INPUT)));
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            //string key = e.KeyCode.ToString();  //取得KeyCode字串

            panel1.BackColor = System.Drawing.Color.SeaGreen;
            //this.BackColor = System.Drawing.Color.SeaGreen;
            CheckYourMouse.Enabled = false;
            label1.Text = (CheckYourMouse.Interval / 1000).ToString();
            //MessageBox.Show(key);
            //TODO: 加入處理KeyDown事件的程式
            try
            {
                KeyboardHook.GlobalKeyDown -= KeyboardHook_KeyDown;
            }
            catch (Exception)
            {
                GC.Collect();
            }
            //KeyboardHook.GlobalKeyDown -= KeyboardHook_KeyDown;

        }


        private void run(Object obj)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }






    }
}
