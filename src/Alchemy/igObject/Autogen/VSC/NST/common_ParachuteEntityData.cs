namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_ParachuteEntityData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
    }
}
