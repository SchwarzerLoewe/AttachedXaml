namespace AttachedXaml
{
    /// <summary>
    /// An abstract class to automatic add GetValue/SetValue to classes
    /// </summary>
    public abstract class DependencyObject
    {
        /// <summary>
        /// Change the value of the DependencyProperty
        /// </summary>
        /// <param name="prop">the Property to change</param>
        /// <param name="value">the value</param>
        /// <example>instance.SetValue(SampleClass.SampleProperty, 12);</example>
        public void SetValue(DependencyProperty prop, object value)
        {
            DependencyProperty.SetValue(prop, value);
        }

        /// <summary>
        /// Get the value of the DependencyProperty
        /// </summary>
        /// <param name="prop">the Property to change</param>
        /// <example>var val = instance.GetValue(SampleClass.SampleProperty);</example>
        public object GetValue(DependencyProperty prop)
        {
            return DependencyProperty.GetValue(prop);
        }
    }
}