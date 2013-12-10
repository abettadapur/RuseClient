﻿using NodeGrooverClient.Model.LastFm;
using NodeGrooverClient.Net;
using System;
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

namespace NodeGrooverClient.Views
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class HomeWindow : Elysium.Controls.Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            API api = API.getInstance();
            api.connectSocket();
         
        }

        
        
    }
}
