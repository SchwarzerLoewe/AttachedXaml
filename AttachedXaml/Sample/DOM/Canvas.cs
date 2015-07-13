﻿using AttachedXaml;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Markup;

namespace Sample.DOM
{
    [ContentProperty("Childs")]
    public class Canvas : FrameworkElement
    {
        public List<FrameworkElement> Childs { get; set; }

        public Canvas()
        {
            Childs = new List<FrameworkElement>();
        }

        public static DependencyProperty TopProperty = DependencyProperty.RegisterAttached("Top", 0);

        public static object GetTop(DependencyObject target)
        {
            return DependencyProperty.GetValue(TopProperty);
        }

        public static void SetTop(DependencyObject target, int value)
        {
            DependencyProperty.SetValue(TopProperty, value);
        }
    }
}