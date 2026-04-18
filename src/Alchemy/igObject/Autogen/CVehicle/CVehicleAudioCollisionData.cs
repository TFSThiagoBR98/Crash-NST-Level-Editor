namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CVehicleAudioCollisionData : igObject
    {
        [FieldAttr(ctr: 12)] public float _minImpactSpeed;
        [FieldAttr(ctr: 16)] public float _maxImpactSpeed;
        [FieldAttr(ctr: 24)] public igHandleMetaField _impactSound = new();
    }
}
