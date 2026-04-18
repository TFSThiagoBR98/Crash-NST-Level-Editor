namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class L332_EggipusRex_C3_LevelEndTeleporterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _VfxTeleporterData = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 72)] public float _Float;
    }
}
