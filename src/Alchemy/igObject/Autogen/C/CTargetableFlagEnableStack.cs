namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CTargetableFlagEnableStack : CEnableStack
    {
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _entity = new();
    }
}
