using System.Collections.Concurrent;

namespace AttachedXaml
{
    public sealed class DependencyProperty
    {
        internal static ConcurrentDictionary<DependencyProperty, object> _values = new ConcurrentDictionary<DependencyProperty, object>();

        internal bool IsAttached{ get; set; }
        internal string Name { get; set; }
        internal bool IsReadOnly { get; set; }
        internal object DefaultValue { get; set; }

        public static DependencyProperty RegisterAttached(string name, object defaultValue = null)
        {
            var p = new DependencyProperty();
            p.IsAttached = true;
            p.Name = name;

            _values.AddOrUpdate(p, defaultValue, (_, __) => defaultValue);

            return p;
        }

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

        public static void SetValue(DependencyProperty prop, object value)
        {
            if (!prop.IsReadOnly)
            {
                _values.AddOrUpdate(prop, value, (_, __) => value);
            }
            else
            {
                throw new DependencyException("Property " + prop.Name + " is readonly");
            }
        }

        public static object GetValue(DependencyProperty prop, object target)
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