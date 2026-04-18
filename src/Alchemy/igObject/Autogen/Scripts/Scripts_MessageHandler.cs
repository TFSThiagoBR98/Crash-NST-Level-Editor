namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_MessageHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public CEntityMessage? ActivationMessage;
        [FieldAttr(nst: 88)] public CEntityMessage? DeactivationMessage;
    }
}
