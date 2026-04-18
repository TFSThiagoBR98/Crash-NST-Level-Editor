namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CGuiDamageNumberData : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _iconMaterial = new();
        [FieldAttr(nst: 24)] public int _damage;
        [FieldAttr(nst: 28)] public igVec2fMetaField _screenPosition = new();
        [FieldAttr(nst: 36)] public igVec3fMetaField _worldPosition = new();
        [FieldAttr(nst: 48)] public EDamageNumberType _damageNumberType = EDamageNumberType.eDNT_Damage;
        [FieldAttr(nst: 56)] public CCharacterAttributeList? _statBoostList;
        [FieldAttr(nst: 64)] public igHandleMetaField _targetEntity = new();
        [FieldAttr(nst: 72)] public igHandleMetaField cameraSystemInstance = new();
        [FieldAttr(nst: 80)] public string? _customAnimationName = null;
    }
}
