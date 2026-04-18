namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CtrLetter_R : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _common_CtrLetterDatas = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _common_CtrLetterDatas001 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _common_CtrLetterDatas002 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _common_CtrLetterDatas003 = new();
    }
}
