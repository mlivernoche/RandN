using System;

namespace RandN.Implementation
{
    /// <summary>
    /// Represents a block RNG that can be seeked.
    /// </summary>
    public interface ISeekableBlockRngCore<TItem, TBlockCounter> : IBlockRngCore<TItem>
        where TBlockCounter : notnull, IEquatable<TBlockCounter>
    {
        /// <summary>
        /// The current position of the RNG core.
        /// </summary>
        public TBlockCounter BlockCounter { get; set; }

        /// <summary>
        /// Regenerates the previous block and fills <paramref name="results"/> without advancing the counter.
        /// </summary>
        public void Regenerate(Span<TItem> results);
    }
}
