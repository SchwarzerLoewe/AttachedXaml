using AttachedXaml;
using System.Collections.Generic;
using System.Windows.Markup;

namespace Sample.DOM
{
    [ContentProperty("Childs")]
    public class Canvas
    {
        public List<Button> Childs { get; set; }

        public Canvas()
        {
            Childs = new List<Button>();
        }

        //public static DependencyProperty TopProperty = DependencyProperty.RegisterAttached("Top", 0);

        /*public static int GetTop(object target)
        {
            return (int)DependencyProperty.GetValue(TopProperty);
        }

        public static void SetTop(object target, int value)
        {
            DependencyProperty.SetValue(TopProperty, value);
        }*/
    }
}