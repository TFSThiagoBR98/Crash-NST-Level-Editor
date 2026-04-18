namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CCombatTargetData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _targetEntity = new();
        [FieldAttr(ctr: 24)] public igVec3fMetaField _aimedPosition = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _targetNormal = new();
        [FieldAttr(ctr: 48)] public float _priority;
        [FieldAttr(ctr: 56)] public igHandleMetaField _registeredDelegatesComponent = new();
    }
}
