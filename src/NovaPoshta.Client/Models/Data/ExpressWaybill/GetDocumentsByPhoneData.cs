using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetDocumentsByPhoneData
    {
        public bool SenderArchive { get; set; }
        public string AttorneyDescription { get; set; }
        public string PayerType { get; set; } // "Sender"
        public string MoneyTransferPayerType { get; set; } // null
        public string SenderName { get; set; }
        public int SeatsAmount { get; set; }
        public string PhoneRecipient { get; set; }
        public string RecipientAddressDescription { get; set; }
        public decimal Cost { get; set; }
        public DateTime ScheduledDeliveryDate { get; set; }
        public DateTime DateTime { get; set; }
        public string CounterpartyRecipientDescription { get; set; }
        public string MoneyTransferAmount { get; set; } // null
        public decimal MoneyTransferCash2Card { get; set; } // "0"
        public string Number { get; set; }
        public bool RecipientArchive { get; set; }
        public decimal AfterpaymentOnGoodsCost { get; set; }
        public string PhoneSender { get; set; }
        public string RecipientName { get; set; }
        public decimal DocumentCost { get; set; }
        public Guid CityRecipient { get; set; }
        public Guid CounterpartyRecipient { get; set; }
        public Guid? LoyaltyCardRecipient { get; set; }
        public Guid? LoyaltyCardSender { get; set; }
        public bool DeletionMark { get; set; }
        public double VolumetricWeight { get; set; }
        public double FactualWeight { get; set; }
        public Guid CitySender { get; set; }
        public string CounterpartySenderDescription { get; set; }
        public Guid CounterpartySender { get; set; }
        public DateTime ReceivingDateTime { get; set; }
        public string CargoDescription { get; set; }
        public string Note { get; set; } // ""
        public string PaymentMethod { get; set; } // "Cash"
        public string SenderAddressDescription { get; set; }
        public string MoneyTransferPaymentMethod { get; set; } // null
        public string CargoType { get; set; } // "Parcel"
    }
}
