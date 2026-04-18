namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CKartCollisionMaterialSlipperyData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _collisionMaterial = new();
        [FieldAttr(ctr: 24)] public float _turnRateSlip;
        [FieldAttr(ctr: 28)] public float _sideSlip;
        [FieldAttr(ctr: 32)] public float _forwardNeutralSlip;
        [FieldAttr(ctr: 36)] public float _forwardAccelerationSlip;
        [FieldAttr(ctr: 40)] public bool _disableBrakeDeceleration;
    }
}
