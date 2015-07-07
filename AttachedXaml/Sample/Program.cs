using System;
using System.Xaml;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Environment.CurrentDirectory + "\\Sample.xaml";

            var result = XamlServices.Load(p);
        }
    }
}