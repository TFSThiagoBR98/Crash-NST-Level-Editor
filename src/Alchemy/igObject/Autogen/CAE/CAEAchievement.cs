namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 8)]
    public class CAEAchievement : igObject
    {
        [FieldAttr(ctr: 12)] public uint _id;
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public string? _displayName;
        [FieldAttr(ctr: 32)] public string? _description;
        [FieldAttr(ctr: 40)] public bool _displayVignette;
        [FieldAttr(ctr: 48)] public igHandleMetaField _currency = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _product = new();
        [FieldAttr(ctr: 64)] public CAEEventHandleList? _events;
        [FieldAttr(ctr: 72)] public igHandleMetaField _kind = new();
        [FieldAttr(ctr: 80)] public int _successLimit;
        [FieldAttr(ctr: 84)] public bool _requiresActivation;
        [FieldAttr(ctr: 88)] public igHandleMetaField _activationCost = new();
        [FieldAttr(ctr: 96)] public int _progressTargetValue;
        [FieldAttr(ctr: 104)] public CAEAchievementParamList? _paramList;
        [FieldAttr(ctr: 112)] public int _progressValue;
        [FieldAttr(ctr: 116)] public int _status;
        [FieldAttr(ctr: 120)] public int _cooldown;
    }
}
