using System;
using JetBrains.Annotations;
using SQLite.Net.Interop;

namespace SQLite.Net.Attributes {
    [PublicAPI]
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyAttribute : IndexedAttribute
    {
        public OnDeleteAction OnDeleteAction { get; set; }

        public ForeignKeyAttribute(Type foreignType)
        {
            ForeignType = foreignType;
        }

        public Type ForeignType { get; private set; }
    }
}
