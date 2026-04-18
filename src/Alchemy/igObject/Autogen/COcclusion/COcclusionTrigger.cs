namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class COcclusionTrigger : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public OcclusionBoxList? _boxes;
        [FieldAttr(nst: 24, ctr: 24)] public uint _entered;
        [FieldAttr(nst: 28, ctr: 28)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 52, ctr: 52)] public igVec3fMetaField _scale = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 76, ctr: 76)] public igVec3fMetaField _max = new();
        [FieldAttr(nst: 88, ctr: 88)] public bool _ignoreDuringEngineCutscene;
        [FieldAttr(nst: 89, ctr: 89)] public bool _ignoreDuringMovieCutscene = true;
        [FieldAttr(nst: 90, ctr: 90)] public bool _useCameraPosition;
        [FieldAttr(nst: 91, ctr: 91)] public bool _state = true;
    }
}
