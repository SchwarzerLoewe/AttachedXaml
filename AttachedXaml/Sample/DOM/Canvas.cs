using AttachedXaml;
using System.Collections.Generic;

namespace Sample.DOM
{
    [System.Windows.Markup.ContentProperty("Childs")]
    public class Canvas : DependencyObject
    {
        public List<DependencyObject> Childs { get; set; }

        public Canvas()
        {
            Childs = new List<DependencyObject>();
        }

        public static DependencyProperty TopProperty = DependencyProperty.RegisterAttached("Top", typeof(int), typeof(Canvas));

        public static object GetTop(DependencyObject target)
        {
            return target.GetValue(TopProperty);
        }

        public static void SetTop(DependencyObject target, int value)
        {
            target.SetValue(TopProperty, value);
        }
    }
}