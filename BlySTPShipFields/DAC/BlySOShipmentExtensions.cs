using System;
using PX.Data;

namespace BlySTPShipFields
{ 
public class SOShipmentExt : PXCacheExtension<PX.Objects.SO.SOShipment>
{
    #region UsrBlyDelAppt
    [PXDBBool]
    [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName="Appointment Required")]

    public virtual bool? UsrBlyDelAppt { get; set; }
    public abstract class usrBlyDelAppt : PX.Data.BQL.BqlBool.Field<usrBlyDelAppt> { }
    #endregion

    #region UsrBlyEmailShipNotify
    [PXDBBool]
    [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName="Email Notification")]

    public virtual bool? UsrBlyEmailShipNotify { get; set; }
    public abstract class usrBlyEmailShipNotify : PX.Data.BQL.BqlBool.Field<usrBlyEmailShipNotify> { }
    #endregion
  }
}