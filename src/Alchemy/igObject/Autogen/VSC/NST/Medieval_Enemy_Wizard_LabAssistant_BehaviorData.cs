namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Medieval_Enemy_Wizard_LabAssistant_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
    }
}
