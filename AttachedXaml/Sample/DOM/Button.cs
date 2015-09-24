using AttachedXaml;

namespace Sample.DOM
{
    [System.Windows.Markup.ContentProperty("Content")]
    public class Button : DependencyObject
    {
        public string Content { get; set; }
    }
}