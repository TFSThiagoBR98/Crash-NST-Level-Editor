namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_PlayLoopingAnimation_OnEnter_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public bool _Bool_0x40;
        [FieldAttr(nst: 65)] public bool _Bool_0x41;
        [FieldAttr(nst: 68)] public float _Float;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
    }
}
