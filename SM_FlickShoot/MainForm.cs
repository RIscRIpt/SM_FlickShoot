using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_FlickShoot
{
    public partial class MainForm : Form
    {
        private int bindKey = 'Q';
        private IntPtr hookId = IntPtr.Zero;
        private float angleCooef;
        private int screenVCenter;
        private int screenHCenter;

        public MainForm()
        {
            InitializeComponent();

            screenHCenter = Screen.PrimaryScreen.Bounds.Height / 2;
            screenVCenter = Screen.PrimaryScreen.Bounds.Width / 2;
            angleCooef = (float)screenVCenter / 90.0f;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            hookId = Win32.SetHook(HookCallback);
            gbSettings.Enabled = true;

            btnEnable.Enabled = false;
            btnDisable.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            Win32.UnhookWindowsHookEx(hookId);
            hookId = IntPtr.Zero;
            gbSettings.Enabled = false;

            btnDisable.Enabled = false;
            btnEnable.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e) { }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(hookId != IntPtr.Zero)
                Win32.UnhookWindowsHookEx(hookId);
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if(nCode >= 0 && wParam == (IntPtr)Win32.WM_KEYDOWN) {
                int vkCode = Marshal.ReadInt32(lParam);
                if(vkCode == bindKey)
                    doFlickShoot();
                else if(vkCode == 'Q')
                    customAngle.Value = -customAngle.Value;
            }

            return Win32.CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            bindKey = (int)e.KeyCode;
            txtKey.Text = e.KeyCode.ToString();
        }

        private void doFlickShoot()
        {
            //TODO: calcualte angle more percise
            int move = (int)((float)customAngle.Value * angleCooef);
            Win32.mouse_event(0, move, 0, 0, UIntPtr.Zero);
            //System.Threading.Thread.Sleep(10);
            Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
            Win32.mouse_event(Win32.MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
            System.Threading.Thread.Sleep(16);
            Win32.mouse_event(0, -move, 0, 0, UIntPtr.Zero);
        }
    }
}
