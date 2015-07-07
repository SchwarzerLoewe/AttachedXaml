using System;
using System.Windows.Markup;

namespace AttachedXaml.MarkupExtensions
{
    [MarkupExtensionReturnType()]
    public class Null : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return null;
        }
    }
}