namespace AttachedXaml
{
    public delegate void DependencyPropertyChangedEventHandler(object sender, DependencyPropertyChangedEventArgs e);
    public delegate void PropertyChangedCallback(
        DependencyObject d,
        DependencyPropertyChangedEventArgs e);

    public class DependencyPropertyChangedEventArgs
    {
        public DependencyPropertyChangedEventArgs(
            DependencyProperty property, object oldValue, object newValue)
        {
            Property = property;
            OldValue = oldValue;
            NewValue = newValue;
        }

        #region Eigenschaften

        public DependencyProperty Property { get; private set; }
        public object OldValue { get; private set; }
        public object NewValue { get; private set; }

        #endregion
    }
}