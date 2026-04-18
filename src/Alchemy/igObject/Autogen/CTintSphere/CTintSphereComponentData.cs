namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CTintSphereComponentData : igComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public bool _ignoreOcclusionBoxes;
        [FieldAttr(ctr: 20)] public EDistanceCullImportance _distanceCullImportance;
        [FieldAttr(nst: 28, ctr: 24)] public float _radius = 1.0f;
        [FieldAttr(nst: 32, ctr: 28)] public igVec3fMetaField _color = new();
        [FieldAttr(nst: 44, ctr: 40)] public float _intensity = 1.0f;
        [FieldAttr(nst: 48, ctr: 44)] public float _additiveness;
        [FieldAttr(nst: 52, ctr: 48)] public bool _depthBlendingEnabled;
        [FieldAttr(nst: 56, ctr: 52)] public float _depthBlendingSoftness = 14.0f;
    }
}
