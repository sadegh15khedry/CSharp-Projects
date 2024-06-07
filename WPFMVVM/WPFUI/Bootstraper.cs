﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFUI.ViewModels;

namespace WPFUI;

public class Bootstraper : BootstrapperBase 
{
    public Bootstraper()
    {
        Initialize();
    }

    protected override void OnStartup(object sender, StartupEventArgs e)
    {
        DisplayRootViewForAsync<ShellViewModel>();
    }
}
