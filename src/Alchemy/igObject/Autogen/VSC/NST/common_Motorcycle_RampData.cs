namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Motorcycle_RampData : CVscComponentData
    {
        public enum ENewEnum9_id_17u0u40s
        {
            NoFade = 0,
            Small = 1,
            Large = 2,
            Medium = 3,
        }

        [FieldAttr(nst: 40)] public igVec3fMetaField _Vec_3F_0x28 = new();
        [FieldAttr(nst: 52)] public igVec3fMetaField _Vec_3F_0x34 = new();
        [FieldAttr(nst: 64)] public bool _Bool;
        [FieldAttr(nst: 68)] public ENewEnum9_id_17u0u40s _NewEnum9_id_17u0u40s;
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Waypoint = new();
    }
}
