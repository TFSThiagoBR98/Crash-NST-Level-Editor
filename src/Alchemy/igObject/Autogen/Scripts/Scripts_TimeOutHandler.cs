namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_TimeOutHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public RangedFloat? TimeOutTime;
        [FieldAttr(nst: 88)] public float InputCheckTime = 1.0f;
        [FieldAttr(nst: 92)] public bool AllowRandomStartState = true;
    }
}
