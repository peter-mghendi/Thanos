namespace Thanos;

using Thanos.Stones;

/// <summary>
/// Am Infinity Gauntlet.
/// </summary>
public class InfinityGauntlet
{
    /// <summary>
    /// Gets a list of stones contained in this gauntlet.
    /// </summary>
    public HashSet<InfinityStone> Stones { get; } = new();

    /// <param name="stone">
    /// A stone to add to this gauntlet.
    /// </param>
    ///
    /// <summary>
    /// Adds the provided stone to the gauntlet if it does not already contain it.
    /// </summary>
    public void Add(InfinityStone stone) => _ = this.Stones.Add(stone);
}
