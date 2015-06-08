// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using SwashbuckleResponseCodeCustomization.Client;
using SwashbuckleResponseCodeCustomization.Client.Models;

namespace SwashbuckleResponseCodeCustomization.Client
{
    public static partial class ValuesExtensions
    {
        /// <param name='operations'>
        /// Reference to the
        /// SwashbuckleResponseCodeCustomization.Client.IValues.
        /// </param>
        /// <param name='id'>
        /// Required. The ID of the contact.
        /// </param>
        public static Contact Get(this IValues operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).GetAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// SwashbuckleResponseCodeCustomization.Client.IValues.
        /// </param>
        /// <param name='id'>
        /// Required. The ID of the contact.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Contact> GetAsync(this IValues operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<SwashbuckleResponseCodeCustomization.Client.Models.Contact> result = await operations.GetWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
