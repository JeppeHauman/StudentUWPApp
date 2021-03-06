﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace StudentUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Student> OC_list_Students { get; }
            = new ObservableCollection<Student>();
        public MainPage()
        {
            this.OC_list_Students.Add(new Student() { Navn = "NAVN1", StudentID = 1234, MobilNummer = 26187823 });
            this.OC_list_Students.Add(new Student() { Navn = "NAVN2", StudentID = 2334, MobilNummer = 26187432 });
            this.OC_list_Students.Add(new Student() { Navn = "NAVN3", StudentID = 2342, MobilNummer = 26186533 });
            this.OC_list_Students.Add(new Student() { Navn = "NAVN4", StudentID = 3455, MobilNummer = 24567883 });
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
