﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopContactApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dBName = "ContactsDB";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string subFolderName = "C#Assignments";
        public static string DBPath = System.IO.Path.Combine(folderPath,subFolderName, dBName);
    }
}
