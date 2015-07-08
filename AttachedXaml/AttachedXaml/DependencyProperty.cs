using System.Collections.Concurrent;

namespace AttachedXaml
{
    /// <summary>
    /// An PropertyStorage
    /// </summary>
    public sealed class DependencyProperty
    {
        /// <summary>
        /// An Callback when a Property value is changed
        /// </summary>
        /// <param name="prop">the DepdendencyProperty</param>
        /// <param name="value">the changed value</param>
        public delegate void PropertyChangedCallback(DependencyProperty prop, object value);

        internal static ConcurrentDictionary<DependencyProperty, object> _values = new ConcurrentDictionary<DependencyProperty, object>();

        internal bool IsAttached{ get; set; }
        internal string Name { get; set; }
        internal bool IsReadOnly { get; set; }
        internal object DefaultValue { get; set; }
        internal PropertyChangedCallback changedCallback;

        /// <summary>
        /// Register an Attached Property
        /// </summary>
        /// <param name="name">the name of the property</param>
        /// <param name="defaultValue">the optional defaultvalue</param>
        /// <param name="propertyChanged">callback when the value is changed</param>
        /// <returns></returns>
        public static DependencyProperty RegisterAttached(string name, object defaultValue = null, PropertyChangedCallback propertyChanged = null)
        {
            var p = new DependencyProperty();
            p.IsAttached = true;
            p.Name = name;
            p.changedCallback = propertyChanged;

            _values.AddOrUpdate(p, defaultValue, (_, __) => defaultValue);

            return p;
        }

        /// <summary>
        /// Register an Attached Readonly Property
        /// </summary>
        /// <param name="name">the name of the property</param>
        /// <param name="defaultValue">the optional defaultvalue</param>
        /// <returns></returns>
        public static DependencyProperty RegisterAttachedReadonly(string name, object defaultValue = null)
        {
            var p = new DependencyProperty();
            p.IsAttached = true;
            p.IsReadOnly = true;
            p.Name = name;
            p.DefaultValue = defaultValue;

            _values.AddOrUpdate(p, defaultValue, (_, __) => defaultValue);

            return p;
        }

        /// <summary>
        /// Change the value of the DependencyProperty
        /// </summary>
        /// <param name="prop">the Property to change</param>
        /// <param name="value">the value</param>
        /// <example>depProp.SetValue(SampleClass.SampleProperty, 12);</example>
        public static void SetValue(DependencyProperty prop, object value)
        {
            if (!prop.IsReadOnly)
            {
                _values.AddOrUpdate(prop, value, (_, __) => value);
                prop.changedCallback?.Invoke(prop, value);
            }
            else
            {
                throw new DependencyException("Property " + prop.Name + " is readonly");
            }
        }

        /// <summary>
        /// Get the value of the DependencyProperty
        /// </summary>
        /// <param name="prop">the Property to get</param>
        /// <example>var val = depProp.GetValue(SampleClass.SampleProperty);</example>
        public static object GetValue(DependencyProperty prop)
        {
            object val;
            if(_values.TryGetValue(prop, out val))
            {
                return val;
            }

            return prop.DefaultValue;
        }
    }
}