using AttachedXaml;
using System.Windows.Markup;

namespace Sample.DOM
{
    [ContentProperty("Content")]
    public class Button : FrameworkElement
    {
        public string Content { get; set; }
    }
}