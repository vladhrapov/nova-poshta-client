using System;

namespace NovaPoshta.Client.Models.Props.ExpressWaybill
{
    public sealed class UpdateWaybillProps
    {
        /// <summary>
        /// Waybill id.
        /// </summary>
        public Guid Ref { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string PayerType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string PaymentMethod { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string DateTime { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string CargoType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public double VolumeGeneral { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public double Weight { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string ServiceType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ushort SeatsAmount { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public double Cost { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CitySender { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid Sender { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid SenderAddress { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ContactSender { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string SendersPhone { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid CityRecipient { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid Recipient { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid RecipientAddress { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid ContactRecipient { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientsPhone { get; private set; }

        /// <summary>
        /// Constructor with all params.
        /// </summary>
        /// <param name="waybillRef"></param>
        /// <param name="payerType"></param>
        /// <param name="paymentMethod"></param>
        /// <param name="dateTime"></param>
        /// <param name="cargoType"></param>
        /// <param name="volumeGeneral"></param>
        /// <param name="weight"></param>
        /// <param name="serviceType"></param>
        /// <param name="seatsAmount"></param>
        /// <param name="description"></param>
        /// <param name="cost"></param>
        /// <param name="citySender"></param>
        /// <param name="sender"></param>
        /// <param name="senderAddress"></param>
        /// <param name="contactSender"></param>
        /// <param name="sendersPhone"></param>
        /// <param name="cityRecipient"></param>
        /// <param name="recipient"></param>
        /// <param name="recipientAddress"></param>
        /// <param name="contactRecipient"></param>
        /// <param name="recipientsPhone"></param>
        public UpdateWaybillProps(Guid waybillRef,
            string payerType,
            string paymentMethod,
            string dateTime,
            string cargoType,
            double volumeGeneral,
            double weight,
            string serviceType,
            ushort seatsAmount,
            string description,
            double cost,
            Guid citySender,
            Guid sender,
            Guid senderAddress,
            Guid contactSender,
            string sendersPhone,
            Guid cityRecipient,
            Guid recipient,
            Guid recipientAddress,
            Guid contactRecipient,
            string recipientsPhone)
        {
            Ref = waybillRef;
            PayerType = payerType;
            PaymentMethod = paymentMethod;
            DateTime = dateTime;
            CargoType = cargoType;
            VolumeGeneral = volumeGeneral;
            Weight = weight;
            ServiceType = serviceType;
            SeatsAmount = seatsAmount;
            Description = description;
            Cost = cost;
            CitySender = citySender;
            Sender = sender;
            SenderAddress = senderAddress;
            ContactSender = contactSender;
            SendersPhone = sendersPhone;
            CityRecipient = cityRecipient;
            Recipient = recipient;
            RecipientAddress = recipientAddress;
            ContactRecipient = contactRecipient;
            RecipientsPhone = recipientsPhone;
        }
    }
}
