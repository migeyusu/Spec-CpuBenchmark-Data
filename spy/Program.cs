﻿using System;
using System.Windows.Forms;

namespace SepcReptile
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var fm = new Form3();
            Application.Run(fm);
            fm.Database.Clear();
        }
    }
}
