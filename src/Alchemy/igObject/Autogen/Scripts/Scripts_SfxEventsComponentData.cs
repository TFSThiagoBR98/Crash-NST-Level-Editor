namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_SfxEventsComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_SfxEventsComponent_
    {
        [FieldAttr(nst: 40)] public bool SoundIsStreamed;
        [FieldAttr(nst: 41)] public bool StopOnDeathRemove;
        [FieldAttr(nst: 42)] public bool StopSfxWithFade;
        [FieldAttr(nst: 43)] public bool NullSoundInstanceOnPlay;
        [FieldAttr(nst: 44)] public float TouchInterval;
        [FieldAttr(nst: 48)] public igHandleMetaField SfxOnAct = new();
        [FieldAttr(nst: 56)] public igHandleMetaField SfxOnActivate = new();
        [FieldAttr(nst: 64)] public igHandleMetaField SfxOnInit = new();
        [FieldAttr(nst: 72)] public igHandleMetaField SfxOnDamage = new();
        [FieldAttr(nst: 80)] public igHandleMetaField SfxOnDeath = new();
        [FieldAttr(nst: 88)] public igHandleMetaField SfxOnEnter = new();
        [FieldAttr(nst: 96)] public igHandleMetaField SfxOnExit = new();
        [FieldAttr(nst: 104)] public igHandleMetaField SfxOnTouch = new();
        [FieldAttr(nst: 112)] public igHandleMetaField SfxOnRemove = new();
        [FieldAttr(nst: 120)] public igHandleMetaField SfxOnMessage = new();
        [FieldAttr(nst: 128)] public CEntityMessage? ReceivingMessage;
        [FieldAttr(nst: 136)] public igHandleMetaField LoopingSfx = new();
        [FieldAttr(nst: 144)] public CEntityMessage? StartLoopMessage;
        [FieldAttr(nst: 152)] public CEntityMessage? StopLoopMessage;
    }
}
