namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 16)]
    public class COutdoorLightComponentData : igComponentData
    {
        [FieldAttr(nst: 32)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 48)] public float _intensity = 1.0f;
        [FieldAttr(nst: 64)] public igVec4fMetaField _bias = new();
        [FieldAttr(nst: 80)] public float _shadowRange = 3000.0f;
        [FieldAttr(nst: 84)] public float _shadowSplitDistribution = 0.89999998f;
    }
}
