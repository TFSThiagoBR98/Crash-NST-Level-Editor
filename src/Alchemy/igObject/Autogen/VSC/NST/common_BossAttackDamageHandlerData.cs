namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BossAttackDamageHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _AkuAkuMaskCount = new();
        [FieldAttr(nst: 48)] public string? _CrashDeathDefaultBehaviorEvent = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _CrashDeathCustomAttackIdentifierList_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _CrashDeathCustomBehaviorEventList = new();
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
        [FieldAttr(nst: 76)] public float _Float;
        [FieldAttr(nst: 80)] public igHandleMetaField _CrashDeathCustomAttackIdentifierList_0x50 = new();
        [FieldAttr(nst: 88)] public bool _Bool_0x58;
    }
}
