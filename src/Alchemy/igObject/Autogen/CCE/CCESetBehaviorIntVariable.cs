namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CCESetBehaviorIntVariable : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public string? _behaviorVariable = null;
        [FieldAttr(nst: 88)] public int _intValue;
    }
}
