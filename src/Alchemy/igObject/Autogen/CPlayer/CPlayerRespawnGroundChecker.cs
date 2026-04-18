namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CPlayerRespawnGroundChecker : igObject
    {
        public enum EResult
        {
            eR_None = 0,
            eR_Pending = 1,
            eR_Success = 2,
            eR_Failure = 3,
        }

        [FieldAttr(nst: 16)] public igHandleMetaField _activeQuery = new();
        [FieldAttr(nst: 24)] public EResult _result;
        [FieldAttr(nst: 28)] public igVec3fMetaField _groundPosition = new();
        [FieldAttr(nst: 40)] public bool _isLandVehicle;
    }
}
