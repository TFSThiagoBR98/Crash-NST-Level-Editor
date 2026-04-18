namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 16)]
    public class igRenderLight : igNamedObject
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 60, ctr: 60)] public float _intensity = 1.0f;
        [FieldAttr(nst: 64, ctr: 64)] public uint _flags = 1;
    }
}
