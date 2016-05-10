using JetBrains.Annotations;

namespace SQLite.Net.Interop {
    [PublicAPI]
    public enum OnDeleteAction
    {
        None,
        /// <summary>
        ///     Don't allow deleting if the relationship
        ///     is set.
        /// </summary>
        Restrict,
        /// <summary>
        ///     Set foreign key to null.
        /// </summary>
        SetNull,
        /// <summary>
        ///     Delete the child entities.
        /// </summary>
        Cascade
    }
}
