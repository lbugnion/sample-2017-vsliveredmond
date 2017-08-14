﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HelloAndroid.ViewModel;

namespace HelloAndroid
{
    public class App
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator 
            => _locator ?? (_locator = new ViewModelLocator());
    }
}