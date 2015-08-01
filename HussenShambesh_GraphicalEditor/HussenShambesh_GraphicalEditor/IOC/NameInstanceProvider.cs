//-----------------------------------------------------------------------
// <copyright file="NameInstanceProvider.cs" author="Hussen Shambesh">
//     Copyright 2014, Argus Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace IOC
{
    using System.Linq;

    using Ninject.Extensions.Factory;

    /// <summary>
    /// The standard implementation of the instance provider for a given name
    /// </summary>
    public class NameInstanceProvider : StandardInstanceProvider
    {
        /// <summary>
        /// Gets the name that shall be used to request an instance for the specified
        /// method and arguments. Null if unnamed instances shall be requested.
        /// </summary>
        /// <param name="methodInfo">The method info of the method that was called on the factory.</param>
        /// <param name="arguments">The arguments that were passed to the factory.</param>
        /// <returns>
        /// The name that shall be used to request an instance for the specified method
        /// and arguments. Null if unnamed instances shall be requested.
        /// </returns>
        protected override string GetName(System.Reflection.MethodInfo methodInfo, object[] arguments)
        {
            return (string)arguments[0];
        }

        /// <summary>
        /// Gets the constructor arguments that shall be passed with the instance request.
        /// </summary>
        /// <param name="methodInfo">The method info of the method that was called on the factory.</param>
        /// <param name="arguments">The arguments that were passed to the factory.</param>
        /// <returns>
        /// The constructor arguments that shall be passed with the instance request.
        /// </returns>
        protected override Ninject.Parameters.IConstructorArgument[] GetConstructorArguments(System.Reflection.MethodInfo methodInfo, object[] arguments)
        {
            return base.GetConstructorArguments(methodInfo, arguments);
        }
    }
}