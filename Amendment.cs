namespace LiskovsExample
{
    /// <summary>
    /// Amendment process implementation
    /// </summary>
    /// <seealso cref="LiskovsExample.MimumGroupSize" />
    public class Amendment : MimumGroupSize
    {
        /// <summary>
        /// Amends this booking
        /// </summary>
        public void Amend(string booking)
        {
            // implementation to amend a booking.

            // after amendment check if minimum group size is breached.
            this.IsMinumGroupSizeBreached(9);
        }

        /// <summary>
        /// Determines whether [is minum group size breached] [the specified current group size].
        /// </summary>
        /// <param name="currentGroupSize">Size of the current group.</param>
        /// <returns>
        ///   <c>true</c> if [is minum group size breached] [the specified current group size]; otherwise, <c>false</c>.
        /// </returns>
        public override bool IsMinumGroupSizeBreached(int currentGroupSize)
        {
            // please note the condition is changed but that is ok we are still not breaching LSP
            if (currentGroupSize < 10)
            {
                /* however the base class expects this event to be noted in the booking which this implementation is not 
                 this leads to different behaviour and maintenance issue hence LSP breach.*/
                return true;

                /* the above code smell is caused due to incorrect use of abstract class virutal method
                  what should have been done is the noting the implemtation to booking should have been made mandatory for all 
                  deriving classes. An interface and a derived base class that is inherted by other interface implementing classes comes to mind*/
            }

            return false;
        }
    }
}
