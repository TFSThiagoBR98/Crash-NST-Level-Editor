namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_InvisibilityHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public bool RemainVisible;
        [FieldAttr(nst: 81)] public bool RemainTargetable;
        [FieldAttr(nst: 82)] public bool InvisibleOnStart = true;
        [FieldAttr(nst: 88)] public Scripts_StringMessage? ReturnVisibleMessage;
        [FieldAttr(nst: 96)] public Scripts_StringMessage? BecomeInvisibleMessage;
    }
}
