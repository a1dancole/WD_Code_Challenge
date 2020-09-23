using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ZombieDice.App.Extensions
{
    public static class ControlExtensions
    {
        public static void ThreadSafeInvoke(this Control control, MethodInvoker method)
        {
            if (control != null && !control.IsDisposed && control.IsHandleCreated)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(method);
                }
                else
                {
                    method();
                }
            }
        }
    }
}
