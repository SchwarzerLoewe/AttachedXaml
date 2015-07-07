namespace AttachedXaml
{
    public abstract class DependencyObject
    {
        public void SetValue(DependencyProperty prop, object value)
        {
            DependencyProperty._values.AddOrUpdate(prop, value, (_, __) => value);
        }

        public object GetValue(DependencyProperty prop)
        {
            object val;
            if (DependencyProperty._values.TryGetValue(prop, out val))
            {
                return val;
            }

            return prop.DefaultValue;
        }
    }
}