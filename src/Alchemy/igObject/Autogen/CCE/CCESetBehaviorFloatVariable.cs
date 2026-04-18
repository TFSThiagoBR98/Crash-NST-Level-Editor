namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CCESetBehaviorFloatVariable : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public string? _behaviorVariable = null;
        [FieldAttr(nst: 88)] public float _floatValue;
    }
}
