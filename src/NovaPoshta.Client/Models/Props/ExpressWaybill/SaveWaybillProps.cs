using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NovaPoshta.Client.Models.Props.ExpressWaybill
{
    public sealed class SaveWaybillProps
    {
        //"PayerType": "Sender",
        public string PayerType { get; private set; }
        //"PaymentMethod": "Cash",
        public string PaymentMethod { get; private set; }
        //"DateTime": "02.03.2015",
        public string DateTime { get; private set; }
        //"CargoType": "Cargo",
        public string CargoType { get; private set; }
        //"VolumeGeneral": "0.1",
        public double? VolumeGeneral { get; private set; } // ToDo: check
        //"Weight": "10",
        public double Weight { get; private set; }
        //"ServiceType": "WarehouseDoors",
        public string ServiceType { get; private set; }
        //"SeatsAmount": "1",
        public int SeatsAmount { get; private set; }
        //"Description": "абажур",
        public string Description { get; private set; }
        //"Cost": "500",
        public double Cost { get; private set; }
        //"CitySender": "8d5a980d-391c-11dd-90d9-001a92567626",
        public Guid CitySender { get; private set; }
        //"Sender": "6e9acced-d072-11e3-95eb-0050568046cd",
        public Guid Sender { get; private set; }
        //"SenderAddress": "01ae2635-e1c2-11e3-8c4a-0050568002cf",
        public Guid SenderAddress { get; private set; }
        //"ContactSender": "d0b9f592-b600-11e4-a77a-005056887b8d",
        public Guid ContactSender { get; private set; }
        //"SendersPhone": "380678734567",
        public string SendersPhone { get; private set; }
        //"CityRecipient": "db5c8892-391c-11dd-90d9-001a92567626",
        public Guid CityRecipient { get; private set; }
        //"Recipient": "d00f2319-b743-11e4-a77a-005056887b8d",
        public Guid Recipient { get; private set; }
        //"RecipientAddress": "511fcfbd-e1c2-11e3-8c4a-0050568002cf",
        public Guid RecipientAddress { get; private set; }
        //"ContactRecipient": "bc7b61ea-b6eb-11e4-a77a-005056887b8d",
        public Guid ContactRecipient { get; private set; }
        //"RecipientsPhone": "380631112223"
        public string RecipientsPhone { get; private set; }

        #region Optional params

        public int OptionsSeat { get; private set; }

        public Guid? ThirdPerson { get; private set; }

        public string RedBoxBarcode { get; private set; }

        #endregion

        private SaveWaybillProps(string payerType,
            string paymentMethod,
            DateTime dateTime,
            string cargoType,
            double weight,
            string serviceType,
            int seatsAmount,
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
            PayerType = payerType;
            PaymentMethod = paymentMethod;
            DateTime = dateTime.ToString("dd.MM.yyyy", CultureInfo.CurrentCulture);
            CargoType = cargoType;
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

        public SaveWaybillProps(string payerType,
            string paymentMethod,
            DateTime dateTime,
            string cargoType,
            double volumeGeneral,
            double weight,
            string serviceType,
            int seatsAmount,
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
            string recipientsPhone,
            Guid? thirdPerson = null,
            string redBoxBarcode = null)
                : this(payerType,
                      paymentMethod,
                      dateTime,
                      cargoType,
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
                      cityRecipient,
                      recipient,
                      recipientAddress,
                      contactRecipient,
                      recipientsPhone)
        {
            VolumeGeneral = volumeGeneral;
            ThirdPerson = thirdPerson;
            RedBoxBarcode = redBoxBarcode;
        }

        public SaveWaybillProps(string payerType,
            string paymentMethod,
            DateTime dateTime,
            string cargoType,
            int optionsSeat,
            double weight,
            string serviceType,
            int seatsAmount,
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
            string recipientsPhone,
            Guid? thirdPerson = null,
            string redBoxBarcode = null)
                : this(payerType,
                      paymentMethod,
                      dateTime,
                      cargoType,
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
                      cityRecipient,
                      recipient,
                      recipientAddress,
                      contactRecipient,
                      recipientsPhone)
        {
            OptionsSeat = optionsSeat;
            ThirdPerson = thirdPerson;
            RedBoxBarcode = redBoxBarcode;
        }
    }
}
