namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNTropy_SceneManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
    }
}
