using System;

namespace FSALib.AssetDefinitions
{
    /// <summary>
    /// Defines how a tile can be interacted with.
    /// </summary>
    [Flags]
    public enum InteractionFlags
    {
        /// <summary>
        /// The tile has no special interactions.
        /// </summary>
        None = 0,

        /// <summary>
        /// The tile can be picked up.
        /// </summary>
        Pickupable = 1 << 0,

        /// <summary>
        /// The tile can be affected by a sword slash.
        /// </summary>
        Slashable = 1 << 1,

        /// <summary>
        /// The tile can be affected by fire.
        /// </summary>
        Burnable = 1 << 2,

        /// <summary>
        /// The tile can be affected by a bomb.
        /// </summary>
        Bombable = 1 << 3,

        /// <summary>
        /// The tile can be affected by the hammer.
        /// </summary>
        Hammerable = 1 << 4,

        /// <summary>
        /// The tile can be dug.
        /// </summary>
        Diggable = 1 << 5,

        /// <summary>
        /// The tile triggers an effect when touched.
        /// </summary>
        Touch = 1 << 6,

        /// <summary>
        /// The tile can be destroyed by a sword slash, fire, bomb, or hammer.
        /// </summary>
        Destructible = Slashable | Burnable | Bombable | Hammerable,
    }
}
