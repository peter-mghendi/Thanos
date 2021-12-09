namespace Thanos.Stones;

/// <summary>
/// Class MindStone.
/// Implements <see cref="InfinityStone" />.
/// </summary>
public sealed record class MindStone : InfinityStone
{
    /// <inheritdoc/>
    public override StoneColor Color => StoneColor.Yellow;
}
