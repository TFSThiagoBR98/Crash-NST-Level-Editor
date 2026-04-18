namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_sprint_prototypeData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _SpeedBoost_CharacterAttributeList = new();
        [FieldAttr(nst: 48)] public float _Sprint_Cooldown_Duration;
        [FieldAttr(nst: 52)] public float _Sprint_Duration;
        [FieldAttr(nst: 56)] public string? _SprintStart = null;
        [FieldAttr(nst: 64)] public string? _SprintEnd = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_EffectVariable_id_cmpjcsln_variable = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_EffectVariable_id_sbxhg4f9_variable = new();
    }
}
