using PX.Data;

namespace BlySTPShipFields
{
    public class SOOrderExt : PXCacheExtension<PX.Objects.SO.SOOrder>
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