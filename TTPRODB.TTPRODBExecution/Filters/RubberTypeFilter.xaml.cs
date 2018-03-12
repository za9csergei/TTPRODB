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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TTPRODB.TTPRODBExecution.Filters
{
    /// <summary>
    /// Interaction logic for RubberTypeFilter.xaml
    /// </summary>
    public partial class RubberTypeFilter : UserControl
    {
        public RubberTypeFilter()
        {
            InitializeComponent();
        }

        private void TensorRadioButtonOnChecked(object sender, RoutedEventArgs e)
        {
            if ((bool) AntiRadioButton.IsChecked)
            {
                AntiRadioButton.IsChecked = false;
            }

            TensorRadioButton.IsChecked = true;

        }

        private void AntiRadioButtonOnChecked(object sender, RoutedEventArgs e)
        {
            if ((bool)TensorRadioButton.IsChecked)
            {
                TensorRadioButton.IsChecked = false;
            }

            AntiRadioButton.IsChecked = true;
        }
    }
}