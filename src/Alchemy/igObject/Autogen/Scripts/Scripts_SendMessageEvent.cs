namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8, metaType: typeof(CDotNetCombatNodeEvent))]
    public class Scripts_SendMessageEvent : CDotNetCombatNodeEvent
    {
        [FieldAttr(nst: 32)] public CEntityMessage? SendingMessage;
        [FieldAttr(nst: 40)] public bool ReturnMessage;
        [FieldAttr(nst: 41)] public bool SendToCombatTargets;
        [FieldAttr(nst: 44)] public ECombatTargetSelect CombatTargets;
    }
}
