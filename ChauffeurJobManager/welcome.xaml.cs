﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChauffeurJobManager
{
    /// <summary>
    /// Interaction logic for welcome.xaml
    /// </summary>
    public partial class welcome : Window
    {
        public welcome()
        {
            InitializeComponent();
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt - ") + "Welcome page loaded!");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
