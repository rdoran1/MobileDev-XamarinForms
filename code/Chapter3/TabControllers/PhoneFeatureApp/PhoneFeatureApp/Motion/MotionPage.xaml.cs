﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhoneFeatureApp.Motion
{
    public partial class MotionPage : ContentPage
    {
        public MotionPage()
        {
            InitializeComponent();
            BindingContext = new MotionViewModel();
            this.IconImageSource = "motion.png";
        }
    }
}
