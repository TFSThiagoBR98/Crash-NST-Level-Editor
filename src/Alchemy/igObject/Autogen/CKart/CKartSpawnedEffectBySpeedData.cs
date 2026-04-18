namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 16)]
    public class CKartSpawnedEffectBySpeedData : igObject
    {
        [FieldAttr(ctr: 16)] public CKartVfxObject? _frontEffect;
        [FieldAttr(ctr: 24)] public CKartVfxObject? _backEffect;
        [FieldAttr(ctr: 32)] public float _spawnSpeed;
        [FieldAttr(ctr: 36)] public float _killSpeed;
        [FieldAttr(ctr: 48)] public igVec4fMetaField _color = new();
        [FieldAttr(ctr: 64)] public bool _groundOnly;
    }
}
