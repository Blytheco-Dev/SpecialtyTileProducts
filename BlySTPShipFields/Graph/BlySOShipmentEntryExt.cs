using System;
using PX.Data;
using PX.Objects.SO;

namespace BlySTPShipFields
{
    public class SOShipmentEntryExt : PXGraphExtension<SOShipmentEntry>
    {

        public delegate bool SetShipmentFieldsFromOrderDelegate(SOOrder order, SOShipment shipment,
                int? siteID, DateTime? shipDate, string operation, SOOrderTypeOperation orderOperation,
                bool newlyCreated);

        [PXOverride]
        public bool SetShipmentFieldsFromOrder(SOOrder order, SOShipment shipment,
                int? siteID, DateTime? shipDate, string operation, SOOrderTypeOperation orderOperation,
                bool newlyCreated, SetShipmentFieldsFromOrderDelegate baseMethod)
        {
            bool returnFlag = baseMethod(order, shipment, siteID, shipDate, operation, orderOperation, newlyCreated);

            shipment.GetExtension<SOShipmentExt>().UsrBlyDelAppt =
                order.GetExtension<SOOrderExt>().UsrBlyDelAppt;
            shipment.GetExtension<SOShipmentExt>().UsrBlyEmailShipNotify =
                order.GetExtension<SOOrderExt>().UsrBlyEmailShipNotify;

            return returnFlag;


    }
    }
}

