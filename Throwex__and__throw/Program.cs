namespace Throwex__and__throw
{
    /// <summary>
    /// difference between “throw ex” and “throw”
    /// </summary>

    //Throw keyword preserve the whole stack trace and give more information about the error.
    //But throw ex will give limited information about the error.

    //Its a best practice to use throw as it preserve the whole stack trace
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivideZerobyZero();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void DivideZerobyZero()
        {
            try
            {
                int i = 0, j = 0;
                int k = i / j;
            }
            catch (Exception ex)
            {
                //throw ex;  // Resets the stack trace to this line
                throw; // Re-throws the original exception
            }
        }
    }
}
