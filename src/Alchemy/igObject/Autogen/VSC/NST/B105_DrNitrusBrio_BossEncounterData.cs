namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class B105_DrNitrusBrio_BossEncounterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Boss = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _IntroCutscene = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _BossDefeatDestructibleTemplateList = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _BossDefeatFallTrigger = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Waypoint = new();
    }
}
