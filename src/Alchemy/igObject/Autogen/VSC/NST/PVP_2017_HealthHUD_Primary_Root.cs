namespace Alchemy
{
    [ObjectAttr(nst: 200, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class PVP_2017_HealthHUD_Primary_Root : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _PlayerEntity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _HealthFillMiddle = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Background = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _HealthFillRight = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _TeamIdentifier = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _BackgroundAdd = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _HealthFillLeft = new();
        [FieldAttr(nst: 96)] public int _TeamNumber;
        [FieldAttr(nst: 104)] public igHandleMetaField _Team2Background = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Team1HealthBarMaterial = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Team2HealthBarMaterial = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _HealthBarMaterial = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Team2BackgroundAdd = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Team1Background = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Team1BackgroundAdd = new();
        [FieldAttr(nst: 160)] public igObject? _FirstPlayer = new();
        [FieldAttr(nst: 168)] public string? _TeamName = null;
        [FieldAttr(nst: 176)] public string? _FirstPlayerTeamName = null;
        [FieldAttr(nst: 184)] public string? _StringVariable_id_iww0vl5b_variable = null;
        [FieldAttr(nst: 192)] public igObject? _Internal_TimerAction_id_23knb0on_timer = new();
    }
}
