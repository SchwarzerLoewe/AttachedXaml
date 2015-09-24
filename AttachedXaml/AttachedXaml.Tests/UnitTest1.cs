using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.DOM;
using System;
using System.Xaml;
using System.Linq;

namespace AttachedXaml.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SetValue_ShouldThrowXamlException()
        {
            var p = Environment.CurrentDirectory + "\\Sample.xaml";

            var result = ((Canvas)XamlServices.Load(p));
            var v = result.Childs.First().GetValue(Canvas.TopProperty);
            result.SetValue(Canvas.TopProperty, 100);
        }
    }
}