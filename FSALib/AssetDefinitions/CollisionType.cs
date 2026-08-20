namespace FSALib.AssetDefinitions
{
    /// <summary>
    /// Defines the collision behavior of a tile.
    /// </summary>
    public enum CollisionType
    {
        /// <summary>
        /// The tile can be freely traversed.
        /// </summary>
        Walkable = default,

        /// <summary>
        /// The tile blocks movement.
        /// </summary>
        Solid,

        /// <summary>
        /// The tile is an impassable abyss.
        /// </summary>
        Abyss,

        /// <summary>
        /// The tile represents shallow water.
        /// </summary>
        ShallowWater,

        /// <summary>
        /// The tile represents deep water.
        /// </summary>
        DeepWater,

        /// <summary>
        /// The tile causes entities to slide across its surface.
        /// </summary>
        Slippery,

        /// <summary>
        /// The tile can harm entities that come into contact with it.
        /// </summary>
        Hazard,

        /// <summary>
        /// The tile has a drop-off that entities can jump down from.
        /// </summary>
        DropOff
    }
}
