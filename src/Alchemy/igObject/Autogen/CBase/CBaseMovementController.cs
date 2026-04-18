namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CBaseMovementController : igObject
    {
        public enum EMovementControllerState
        {
            eMCS_Invalid = -1,
            eMCS_Active = 0,
            eMCS_Paused = 1,
            eMCS_Completed = 2,
            eMCS_Inactive = 3,
        }

        [FieldAttr(nst: 16, ctr: 12)] public bool _startEnabled;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 32, ctr: 24)] public EMovementControllerState _state = CBaseMovementController.EMovementControllerState.eMCS_Inactive;
        [FieldAttr(nst: 40, ctr: 32)] public igVscDelegateMetaField _finishedCallback = new();
    }
}
