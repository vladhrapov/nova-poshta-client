using System;

namespace NovaPoshta.Client.Models.Props.Address
{
    public sealed class DeleteContragentAddressProps
    {
        /// <summary>
        /// Contragent address id.
        /// </summary>
        public Guid Ref { get; private set; }

        private DeleteContragentAddressProps()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="addressRef">Contragent address id.</param>
        public DeleteContragentAddressProps(Guid addressRef)
        {
            Ref = addressRef;
        }
    }
}
