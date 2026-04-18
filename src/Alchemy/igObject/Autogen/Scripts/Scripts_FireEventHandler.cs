namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_FireEventHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public string? _activateEvent = null;
        [FieldAttr(nst: 88)] public string? _deactivateEvent = null;
    }
}
