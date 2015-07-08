namespace AttachedXaml
{
    public abstract class DependencyObject
    {
        public void SetValue(DependencyProperty prop, object value)
        {
            DependencyProperty.SetValue(prop, value);
        }

        public object GetValue(DependencyProperty prop)
        {
            return DependencyProperty.GetValue(prop);
        }
    }
}