using System;
using System.Globalization;

namespace NovaPoshta.Client.Models.Props.ExpressWaybill
{
    public sealed class SaveWaybillByPostOfficeProps
    {
        /// <summary>
        /// 
        /// </summary>
        public byte NewAddress { get; private set; }

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
        public string RecipientCityName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientArea { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientAreaRegions { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientAddressName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientHouse { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientFlat { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientsPhone { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string DateTime { get; private set; }

        #region Optional params

        /// <summary>
        /// 
        /// </summary>
        public Guid? OwnershipForm { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientContactName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string EDRPOU { get; private set; }

        #endregion

        /// <summary>
        /// Constructor with required params.
        /// </summary>
        /// <param name="newAddress"></param>
        /// <param name="payerType"></param>
        /// <param name="paymentMethod"></param>
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
        /// <param name="recipientCityName"></param>
        /// <param name="recipientArea"></param>
        /// <param name="recipientAreaRegions"></param>
        /// <param name="recipientAddressName"></param>
        /// <param name="recipientHouse"></param>
        /// <param name="recipientFlat"></param>
        /// <param name="recipientName"></param>
        /// <param name="recipientType"></param>
        /// <param name="recipientsPhone"></param>
        /// <param name="dateTime"></param>
        public SaveWaybillByPostOfficeProps(bool newAddress,
            string payerType,
            string paymentMethod,
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
            string recipientCityName,
            string recipientArea,
            string recipientAreaRegions,
            string recipientAddressName,
            string recipientHouse,
            string recipientFlat,
            string recipientName,
            string recipientType,
            string recipientsPhone,
            DateTime dateTime)
        {
            NewAddress = (byte)(newAddress ? 1 : 0);
            PayerType = payerType;
            PaymentMethod = paymentMethod;
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
            RecipientCityName = recipientCityName;
            RecipientArea = recipientArea;
            RecipientAreaRegions = recipientAreaRegions;
            RecipientAddressName = recipientAddressName;
            RecipientHouse = recipientHouse;
            RecipientFlat = recipientFlat;
            RecipientName = recipientName;
            RecipientType = recipientType;
            RecipientsPhone = recipientsPhone;
            DateTime = dateTime.ToString("dd.MM.yyyy", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Constructor with all params.
        /// </summary>
        /// <param name="newAddress"></param>
        /// <param name="payerType"></param>
        /// <param name="paymentMethod"></param>
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
        /// <param name="recipientCityName"></param>
        /// <param name="recipientArea"></param>
        /// <param name="recipientAreaRegions"></param>
        /// <param name="recipientAddressName"></param>
        /// <param name="recipientHouse"></param>
        /// <param name="recipientFlat"></param>
        /// <param name="recipientName"></param>
        /// <param name="recipientType"></param>
        /// <param name="recipientsPhone"></param>
        /// <param name="dateTime"></param>
        /// <param name="ownershipForm"></param>
        /// <param name="recipientContactName"></param>
        /// <param name="edrpou"></param>
        public SaveWaybillByPostOfficeProps(bool newAddress,
            string payerType,
            string paymentMethod,
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
            string recipientCityName,
            string recipientArea,
            string recipientAreaRegions,
            string recipientAddressName,
            string recipientHouse,
            string recipientFlat,
            string recipientName,
            string recipientType,
            string recipientsPhone,
            DateTime dateTime,
            Guid? ownershipForm = null,
            string recipientContactName = null,
            string edrpou = null)
                : this(newAddress,
                      payerType,
                      paymentMethod,
                      cargoType,
                      volumeGeneral,
                      weight,
                      serviceType,
                      seatsAmount,
                      description,
                      cost,
                      citySender,
                      sender,
                      senderAddress,
                      contactSender,
                      sendersPhone,
                      recipientCityName,
                      recipientArea,
                      recipientAreaRegions,
                      recipientAddressName,
                      recipientHouse,
                      recipientFlat,
                      recipientName,
                      recipientType,
                      recipientsPhone,
                      dateTime)
        {
            OwnershipForm = ownershipForm;
            RecipientContactName = recipientContactName;
            EDRPOU = edrpou;
        }

    }
}
