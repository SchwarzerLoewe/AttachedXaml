﻿namespace AttachedXaml
{
    public class PropertyMetadata
    {
        public PropertyMetadata() { }

        public PropertyMetadata(object defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public PropertyMetadata(object defaultValue, PropertyChangedCallback callback)
        {
            DefaultValue = defaultValue;
            PropertyChangedCallback = callback;
        }

        public PropertyMetadata(PropertyChangedCallback callback)
        {
            PropertyChangedCallback = callback;
        }

        #region Eigenschaften

        public PropertyChangedCallback PropertyChangedCallback { get; set; }
        public object DefaultValue { get; set; }

        #endregion
    }
}