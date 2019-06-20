using System;
using System.Collections.Generic;

namespace PoLaKoSz.WeAreOne.Models
{
    /// <summary>
    /// Used when the artist and the song title is not
    /// seperated in a recognizable format.
    /// </summary>
    public class Music : IEquatable<Music>
    {
        /// <summary>
        /// Full name of the song (artist(s) name + song title).
        /// </summary>
        public string Name { get; }



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="name">Non null string.</param>
        public Music(string name)
        {
            Name = name;
        }



#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public bool Equals(Music other)
        {
            if (other == null)
            {
                return false;
            }

            if (!Name.Equals(other.Name))
            {
                return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            var another = (Music)obj;

            return Equals(another);
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public override string ToString()
        {
            // Leave it like this for Unit tests!!
            return Name;
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
