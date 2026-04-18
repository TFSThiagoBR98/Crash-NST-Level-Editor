namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 96, align: 8)]
    public class igVfxCylindricalSpawnLocationData : igVfxVolumetricSpawnLocationData
    {
        [FieldAttr(nst: 88, ctr: 76)] public float _height = 50.0f;
        [FieldAttr(nst: 92, ctr: 80)] public float _bottomRadius = 25.0f;
        [FieldAttr(nst: 96, ctr: 84)] public float _topRadius = 25.0f;
        [FieldAttr(nst: 100, ctr: 88)] public igRangedFloatMetaField _theta = new();
    }
}
