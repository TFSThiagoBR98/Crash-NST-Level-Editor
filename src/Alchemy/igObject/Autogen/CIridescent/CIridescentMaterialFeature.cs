namespace Alchemy
{
    [ObjectAttr(nst: 312, ctr: 312, align: 8)]
    public class CIridescentMaterialFeature : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _owner = new();
        [FieldAttr(nst: 24, ctr: 24)] public igVfxRangedCurveMetaField _colorRed = new();
        [FieldAttr(nst: 108, ctr: 108)] public igVfxRangedCurveMetaField _colorGreen = new();
        [FieldAttr(nst: 192, ctr: 192)] public igVfxRangedCurveMetaField _colorBlue = new();
        [FieldAttr(nst: 276, ctr: 276)] public float _gloss = 0.8f;
        [FieldAttr(nst: 280, ctr: 280)] public float _metalness = 1.0f;
        [FieldAttr(nst: 284, ctr: 284)] public float _emissive;
        [FieldAttr(nst: 288, ctr: 288)] public float _distance;
        [FieldAttr(nst: 292, ctr: 292)] public float _falloff;
        [FieldAttr(nst: 296, ctr: 296)] public bool _flipFalloff;
        [FieldAttr(nst: 300, ctr: 300)] public float _overallContribution = 1.0f;
        [FieldAttr(nst: 304, ctr: 304)] public bool _useNormalMap = true;
        [FieldAttr(nst: 305, ctr: 305)] public bool _useHalfAngle;
        [FieldAttr(nst: 306, ctr: 306)] public bool _useFixedHalfAngle;
    }
}
