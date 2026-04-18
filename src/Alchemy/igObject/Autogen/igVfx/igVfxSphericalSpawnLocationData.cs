namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 96, align: 8)]
    public class igVfxSphericalSpawnLocationData : igVfxVolumetricSpawnLocationData
    {
        [FieldAttr(nst: 88, ctr: 76)] public float _radius = 50.0f;
        [FieldAttr(nst: 92, ctr: 80)] public igRangedFloatMetaField _cosPhi = new();
        [FieldAttr(nst: 100, ctr: 88)] public igRangedFloatMetaField _theta = new();
    }
}
