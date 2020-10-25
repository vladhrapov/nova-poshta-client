using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models.Data.ExpressWaybill
{
    public sealed class GetDocumentListData
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? PreferredDeliveryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public uint? SeatsAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public uint? IntDocNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CitySender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CityRecipient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? SenderAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecipientAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CostOnSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PayerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? AfterpaymentOnGoodsCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public uint? PackingNumber { get; set; }

        // ToDo: Figure out types for the props.
        // "Number": null,
        // "Posted": null,
        // "DeletionMark": null,
        // "CargoType": null,
        // "Route": null,
        // "EWNumber": null,
        // "Description": null,
        // "SaturdayDelivery": null,
        // "ExpressWaybill": null,
        // "CarCall": null,
        // "ServiceType": null,
        // "DeliveryDateFrom": null,
        // "Vip": null,
        // "AdditionalInformation": null,
        // "LastModificationDate": null,
        // "ReceiptDate": null,
        // "LoyaltyCard": null,
        // "Sender": null,
        // "ContactSender": null,
        // "SendersPhone": null,
        // "Recipient": null,
        // "ContactRecipient": null,
        // "RecipientsPhone": null,
        // "Redelivery": null,
        // "SaturdayDeliveryString": null,
        // "Note": null,
        // "ThirdPerson": null,
        // "Forwarding": null,
        // "NumberOfFloorsLifting": null,
        // "StatementOfAcceptanceTransferCargoID": null,
        // "StateId": 1,
        // "StateName": "Замовлення в обробці",
        // "RecipientFullName": null,
        // "RecipientPost": null,
        // "RecipientDateTime": null,
        // "RejectionReason": null,

        /// <summary>
        /// 
        /// </summary>
        public string CitySenderDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CityRecipientDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SenderDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientContactPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientContactPerson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SenderAddressDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RecipientAddressDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public uint? Printed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public uint? Fulfillment { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateLastUpdatedStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ScanSheetNumber { get; set; } // ToDo: check out type

        /// <summary>
        /// 
        /// </summary>
        public string InfoRegClientBarcodes { get; set; } // ToDo: check out type

        /// <summary>
        /// 
        /// </summary>
        public uint? StatePayId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StatePayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackwardDeliveryCargoType { get; set; }
    }
}
