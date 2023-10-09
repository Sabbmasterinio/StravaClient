namespace StravaClient
{
    /// <summary>
    /// Provides enumeration over the climb category.
    /// </summary>
    /// <remarks>
    /// <para>
    /// ie. 5 is Hors catégorie, 0 is uncategorized in climb_category.
    /// </para>
    /// <para>
    /// If climb_category = 5, climb_category_desc = HC. 
    /// </para>
    /// <para>
    /// If climb_category = 2, climb_category_desc = 3.
    /// </para>
    /// </remarks>
    public enum ClimbCategory
    {
        /// <summary>
        /// No category
        /// </summary>
        NoCategory = 0,

        /// <summary>
        /// One
        /// </summary>
        One = 1,
        
        /// <summary>
        /// Two
        /// </summary>
        Two = 2,

        /// <summary>
        /// Three
        /// </summary>
        Three = 3,
        
        /// <summary>
        /// Four
        /// </summary>
        Four = 4,

        /// <summary>
        /// Hors categorie
        /// </summary>
        HorsCategory = 5
    }

}