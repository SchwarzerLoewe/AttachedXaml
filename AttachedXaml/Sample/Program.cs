using Sample.DOM;
using System;
using System.Windows.Markup;
using System.Xaml;

[assembly: XmlnsDefinition("http://sample.com/", "Sample.DOM")]

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Environment.CurrentDirectory + "\\Sample.xaml";

            var result = ((Canvas)XamlServices.Load(p));
            var r = result.GetValue(Canvas.TopProperty);
        }
    }
}