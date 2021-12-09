namespace Thanos.Stones;

public abstract partial record InfinityStone
{
    /// <summary>
    /// Represents all the available colors for Infinity Stones.
    /// </summary>
    public enum StoneColor
    {
        /// <summary>A blue Infinity Stone.</summary>
        Blue = 1,

        /// <summary>A yellow Infinity Stone.</summary>
        Yellow,

        /// <summary>A red Infinity Stone.</summary>
        Red,

        /// <summary>A purple Infinity Stone.</summary>
        Purple,

        /// <summary>A green Infinity Stone.</summary>
        Green,

        /// <summary>An orange Infinity Stone.</summary>
        Orange,
    }
}
