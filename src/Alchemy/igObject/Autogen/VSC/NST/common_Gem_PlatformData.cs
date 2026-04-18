namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Gem_PlatformData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Rotates;
        [FieldAttr(nst: 41)] public bool _Bobs;
        [FieldAttr(nst: 44)] public float _BobHeight;
        [FieldAttr(nst: 48)] public float _BobDuration;
        [FieldAttr(nst: 56)] public igHandleMetaField _GemGameVariable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _StepReactionSFX = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _StepReactionVFX = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _GemNotCollectedVFX = new();
        [FieldAttr(nst: 88)] public int _Int;
        [FieldAttr(nst: 92)] public bool _Bool;
        [FieldAttr(nst: 96)] public EigEaseType _EaseTypeVariable_id_8t0z7rwu_variable;
    }
}
