namespace LiskovsExample
{
    /// <summary>
    /// The base mimum group size implementation
    /// </summary>
    public abstract class MimumGroupSize
    {
        /// <summary>
        /// Determines whether [is minum group size breached] [the specified current group size].
        /// </summary>
        /// <param name="currentGroupSize">Size of the current group.</param>
        /// <returns>
        ///   <c>true</c> if [is minum group size breached] [the specified current group size]; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMinumGroupSizeBreached(int currentGroupSize)
        {
            // if the group size is less than 20 its a breach.
            if (currentGroupSize < 20)
            {
                // make a note in the booking
                this.MakeaNote("this.Booking");
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Makeas the note.
        /// </summary>
        /// <param name="booking">The booking.</param>
        public void MakeaNote(string booking)
        {
            // made a note
        }
    }
}
