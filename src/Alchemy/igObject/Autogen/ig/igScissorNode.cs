namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 128, align: 16)]
    public class igScissorNode : igGroup
    {
        [FieldAttr(nst: 64, ctr: 64)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 76, ctr: 76)] public igVec3fMetaField _max = new();
        [FieldAttr(nst: 88)] public igVec2fMetaField _screenSize = new();
        [FieldAttr(ctr: 96)] public igVec4fMetaField _viewport = new();
        [FieldAttr(ctr: 112)] public bool _useMinMax;
    }
}
