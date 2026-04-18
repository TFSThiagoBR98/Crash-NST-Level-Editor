namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 48, align: 16)]
    public class CPointLightComponentData : igComponentData
    {
        [FieldAttr(nst: 32, ctr: 16)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 48, ctr: 32)] public float _intensity = 1.0f;
        [FieldAttr(nst: 52, ctr: 36)] public float _radius = 200.0f;
        [FieldAttr(nst: 56, ctr: 40)] public EBakeLight _lightBakeType;
        [FieldAttr(nst: 60, ctr: 44)] public bool _distanceCull = true;
    }
}
