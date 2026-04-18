namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNTropy_SceneHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
    }
}
