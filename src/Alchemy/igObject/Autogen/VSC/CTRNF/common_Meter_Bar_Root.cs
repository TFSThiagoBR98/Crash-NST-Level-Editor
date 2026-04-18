namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Meter_Bar_Root : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igVec4ucMetaField _FillColor = new();
        [FieldAttr(ctr: 44)] public igVec4ucMetaField _SentColor = new();
        [FieldAttr(ctr: 48)] public float _CurrentFillAmt;
        [FieldAttr(ctr: 52)] public float _AnimDelta;
        [FieldAttr(ctr: 56)] public float _AnimIncrement;
        [FieldAttr(ctr: 60)] public float _Initial_Fill_Amount;
        [FieldAttr(ctr: 64)] public float _FloatVariable_id_vwrx11vt_variable;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Bar_Fill_Anim = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _GuiPlaceableVariable_id_j0cwne6i_variable = new();
        [FieldAttr(ctr: 88)] public igObject? _Internal_TimerAction_id_rumrs5d5_timer = new();
        [FieldAttr(ctr: 96)] public igObject? _Internal_TimerAction_id_sdvyvkos_timer = new();
        [FieldAttr(ctr: 104)] public float _SentEndAmt;
        [FieldAttr(ctr: 108)] public float _SentDuration;
        [FieldAttr(ctr: 112)] public igHandleMetaField _Vfx_Spawned_Effect = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _Sound_Instance = new();
    }
}
