using System.Threading;

namespace Birch.Compose
{
    /// <summary>
    /// Each stateful container will have one of these.
    /// </summary>
    /// <remarks>The identifier is used to uniquely identify the
    /// model for the associated stateful container.</remarks>
    public sealed class BuildContext:IBuildContext
    {
        private static int _id;

        /// <summary>
        /// Unique identifier of this build context
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The associated <see cref="BuildOwner"/>
        /// </summary>
        public BuildOwner Owner { get; set; }


        private BuildContext(int id, BuildOwner owner)
        {
            Id = id;
            Owner = owner;
        }

        /// <summary>
        /// Create and instance for a specified <see cref="BuildOwner"/>
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static BuildContext Create(BuildOwner owner)
        {
            var newId = Interlocked.Increment(ref _id);

            return new BuildContext(newId,owner);
        }
    }
}