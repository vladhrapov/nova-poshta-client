using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Props.ExpressWaybill
{
    public sealed class GetDocumentDeliveryDateProps
    {
        /// <summary>
        /// Document creation date.
        /// </summary>
        public string DateTime { get; private set; }

        /// <summary>
        /// Delivery type for the parcel(warehouse doors, etc).
        /// </summary>
        public string ServiceType { get; private set; }

        /// <summary>
        /// City id of the sender person.
        /// </summary>
        public Guid CitySender { get; private set; }

        /// <summary>
        /// City id of the recipient person.
        /// </summary>
        public Guid CityRecipient { get; private set; }

        /// <summary>
        /// Constructor with all required params.
        /// </summary>
        /// <param name="serviceType">Delivery type for the parcel(warehouse doors, etc).</param>
        /// <param name="citySender">City of the sender person.</param>
        /// <param name="cityRecipient">City id of the recipient person.</param>
        public GetDocumentDeliveryDateProps(string serviceType, Guid citySender, Guid cityRecipient)
        {
            ServiceType = serviceType;
            CitySender = citySender;
            CityRecipient = cityRecipient;
        }

        /// <summary>
        /// Constructor with all params.
        /// </summary>
        /// <param name="serviceType">Delivery type for the parcel(warehouse doors, etc).</param>
        /// <param name="citySender">City of the sender person.</param>
        /// <param name="cityRecipient">City id of the recipient person.</param>
        /// <param name="dateTime">Document creation date.</param>
        public GetDocumentDeliveryDateProps(string serviceType, Guid citySender, Guid cityRecipient, string dateTime)
            : this(serviceType, citySender, cityRecipient)
        {
            DateTime = dateTime;
        }
    }
}
