namespace Thanos;

using System.IO;

/// <summary>
/// Represents a Mad Titan.
/// </summary>
public sealed class MadTitan
{
    /// <summary>
    /// Gets the <see cref="InfinityGauntlet" /> currently in use by the mad titan.
    /// </summary>
    public InfinityGauntlet? Gauntlet { get; private set; }

    /// <param name="location">
    /// The location to snappen.
    /// </param>
    ///
    /// <summary>
    /// Snappen a location. Go straight to the snappening without worrying about infinity stones.
    /// </summary>
    ///
    /// <remarks>
    /// Will always work, regardless of presence of an <see cref="InfinityGauntlet" /> or stones.
    /// Use <see cref="Snap(string)" /> to enforce the gauntlet and stone validation checks.
    /// </remarks>
    ///
    /// <seealso cref="Snap(string)" />
    public static void Snappen(string location)
    {
        // Check if the location is valid.
        if (location.Trim() == string.Empty)
        {
            return;
        }

        var random = new Random();
        var files = Directory.GetFiles(path: location)
            .OrderBy(keySelector: _ => random.Next());
        files.Take(count: (int)Math.Ceiling((double)files.Count() / 2))
            .ToList().ForEach(action: File.Delete);
    }

    /// <param name="gauntlet">
    /// An <see cref="InfinityGauntlet" /> to give to the mad titan.
    /// </param>
    ///
    /// <summary>
    /// Give the mad titan an <see cref="InfinityGauntlet" />.
    /// </summary>
    public void Give(InfinityGauntlet gauntlet) => this.Gauntlet = gauntlet;

    /// <param name="location">
    /// Location to snap in.
    /// </param>
    ///
    /// <returns>
    /// true if the snap in <paramref name="location" /> is successful; otherwise false.
    /// </returns>
    ///
    /// <summary>
    /// Make the mad titan snap his fingers.
    /// </summary>
    ///
    /// <remarks>
    /// Will only work if the mad titan has an <see cref="InfinityGauntlet" /> with all the stones.
    /// Use <see cref="Give(InfinityGauntlet)" /> to give the mad titan a gauntlet, or
    /// <see cref="Snappen(string)" /> to skip the gauntlet and stone validation checks.
    /// </remarks>
    ///
    /// <seealso cref="Snappen(string)" />
    public bool Snap(string location)
    {
        // Check if a gauntlet is present.
        if (this.Gauntlet is null)
        {
            return false;
        }

        // Check if the gauntlet has all the stones.
        if (this.Gauntlet.Stones.Count < 6)
        {
            return false;
        }

        // Snap in the location.
        Snappen(location: location);
        return true;
    }
}
