namespace NetGore.World;

public abstract partial class GridSpatialCollectionBase
{
    /// <summary>
    /// A straight-forward implementation of the <see cref="IGridSpatialCollectionSegment"/>.
    /// </summary>
    class CollectionSegment : IGridSpatialCollectionSegment
    {
        readonly HashSet<ISpatial> _spatials = new HashSet<ISpatial>();

        #region IGridSpatialCollectionSegment Members

        /// <summary>
        /// Adds the <see cref="ISpatial"/> to the segment.
        /// </summary>
        /// <param name="spatial">The <see cref="ISpatial"/> to add.</param>
        public void Add(ISpatial spatial)
        {
            _spatials.Add(spatial);
        }

        /// <summary>
        /// Adds multiple <see cref="ISpatial"/>s to the segment.
        /// </summary>
        /// <param name="spatials">The <see cref="ISpatial"/>s to add.</param>
        public void AddRange(IEnumerable<ISpatial> spatials)
        {
            foreach (var spatial in spatials)
            {
                Add(spatial);
            }
        }

        /// <summary>
        /// Clears all <see cref="ISpatial"/>s from the segment.
        /// </summary>
        public void Clear()
        {
            _spatials.Clear();
        }

        /// <summary>
        /// Remove the <see cref="ISpatial"/> from the segment.
        /// </summary>
        /// <param name="spatial">The <see cref="ISpatial"/> to remove.</param>
        public void Remove(ISpatial spatial)
        {
            _spatials.Remove(spatial);
        }

        /// <summary>
        /// Gets if the given ISpatial is in this collection.
        /// </summary>
        public bool Contains(ISpatial spatial)
        {
            return _spatials.Contains(spatial);
        }

        /// <summary>
        /// Gets the ISpatials in this collection.
        /// </summary>
        public IEnumerable<ISpatial> Items { get { return _spatials; } }

        #endregion
    }
}