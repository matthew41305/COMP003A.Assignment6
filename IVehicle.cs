namespace COMP003A.Assignment6
{
    /// <summary>
    /// Interfaces are contracts that inheriting class has to implement. 
    /// Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abst
ract-types-and-interfaces
    /// </summary>
    internal interface IVehicle
    {
        /// <summary
        /// this method is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();

    }
}
