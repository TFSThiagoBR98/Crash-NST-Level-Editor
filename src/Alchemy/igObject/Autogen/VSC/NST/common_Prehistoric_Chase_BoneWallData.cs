namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Prehistoric_Chase_BoneWallData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Sound = new();
    }
}
