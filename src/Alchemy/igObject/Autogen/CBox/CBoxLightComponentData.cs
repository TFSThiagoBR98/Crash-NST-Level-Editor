namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 96, align: 16)]
    public class CBoxLightComponentData : igComponentData
    {
        [FieldAttr(nst: 32, ctr: 16)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 48, ctr: 32)] public float _intensity = 1.0f;
        [FieldAttr(nst: 52, ctr: 36)] public igVec3fMetaField _dimensions = new();
        [FieldAttr(nst: 64, ctr: 48)] public float _nearAttenuation;
        [FieldAttr(nst: 68, ctr: 52)] public float _attenuation;
        [FieldAttr(nst: 72, ctr: 56)] public float _xFalloff;
        [FieldAttr(nst: 76, ctr: 60)] public float _yFalloff;
        [FieldAttr(nst: 80, ctr: 64)] public float _wrap;
        [FieldAttr(nst: 88, ctr: 72)] public string? _cookieTextureName = "loosetextures";
        [FieldAttr(nst: 96, ctr: 80)] public igVfxAnimatedFrame? _uvAnimation;
        [FieldAttr(nst: 104, ctr: 88)] public EBakeLight _lightBakeType;
        [FieldAttr(nst: 108, ctr: 92)] public bool _distanceCull = true;
    }
}
