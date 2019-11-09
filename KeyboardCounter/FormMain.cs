using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardCounter
{
    public partial class FormMain : Form
    {
        private readonly LowLevelKeyboardListener llkl = new LowLevelKeyboardListener();

        private DateTime lastRefresh;
        private int counter;

        private bool mouseDown = false;
        private Point lastMousePos = Cursor.Position;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - Width, Screen.PrimaryScreen.WorkingArea.Top);

            llkl.OnKeyPressed += Llkl_OnKeyPressed;

            lastRefresh = DateTime.Now;
            counter = 0;

            llkl.HookKeyboard();
            timerRefresh.Start();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerRefresh.Stop();
            llkl.UnHookKeyboard();
        }

        private void Llkl_OnKeyPressed(object sender, KeyPressedArgs e) => counter++;

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            labelCounter.Text = (counter / now.Subtract(lastRefresh).TotalSeconds).ToString("0.0");

            lastRefresh = now;
            counter = 0;
        }

        private void LabelCounter_MouseDown(object sender, MouseEventArgs e) => mouseDown = true;
        private void LabelCounter_MouseUp(object sender, MouseEventArgs e) => mouseDown = false;

        private void LabelCounter_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = Cursor.Position;

            if (mouseDown)
            {
                Location = new Point(Location.X + mousePos.X - lastMousePos.X, Location.Y + mousePos.Y - lastMousePos.Y);
            }

            lastMousePos = mousePos;
        }
    }
}
