namespace NXT.DAL
{
    /// <summary>
    /// Denotes a class that can convert entities from one type to another.
    /// </summary>
    /// <remarks>
    /// Do not expose this outside of the DAL.
    /// </remarks>
    interface IEntityConverter
    {
        /// <summary>
        /// Convert from TIn to TOut.
        /// </summary>
        /// <typeparam name="TIn">The input type.</typeparam>
        /// <typeparam name="TOut">The output type.</typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        TOut Convert<TIn, TOut>(TIn input);
    }
}
