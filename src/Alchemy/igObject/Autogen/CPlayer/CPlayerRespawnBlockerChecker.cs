namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CPlayerRespawnBlockerChecker : igObject
    {
        public enum EResult
        {
            eR_None = 0,
            eR_Pending = 1,
            eR_Blocked = 2,
            eR_Clear = 3,
        }

        [FieldAttr(nst: 16)] public igHandleMetaField _activeQuery = new();
        [FieldAttr(nst: 24)] public EResult _result;
        [FieldAttr(nst: 28)] public igVec3fMetaField _sourcePos = new();
    }
}
