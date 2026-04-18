namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CKartCollisionMaterialBoostData : igObject
    {
        [FieldAttr(ctr: 16)] public CCollisionMaterial? _collisionMaterial;
        [FieldAttr(ctr: 24)] public CKartBoostData? _kartBoostData;
    }
}
