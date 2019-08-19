using System;
using System.Threading;

namespace Appium.Utils
{
    public static class Helpers
    {
        public static void Pause(int seconds) {
            try { Thread.Sleep(seconds * 1000); }
            catch (Exception err){ throw err; }
        }
    }
}
