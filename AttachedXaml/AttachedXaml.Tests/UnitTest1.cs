using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.DOM;
using System;
using System.Xaml;

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
            result.SetValue(Canvas.TopProperty, 100);
        }
    }
}