namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_InWorldHealthHUD_componentData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _DisplayOnProximity;
        [FieldAttr(nst: 44)] public float _HealthHudVisibilityDuration;
        [FieldAttr(nst: 48)] public float _ProximityCheckUpdateFrequency;
        [FieldAttr(nst: 52)] public float _ProximityRange;
        [FieldAttr(nst: 56)] public igHandleMetaField _ProximityChecksEnabled = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _GuiProjectVariable_id_sc7bbthz_variable = new();
        [FieldAttr(nst: 72)] public igVec3fMetaField _WorldspaceOffset = new();
    }
}
