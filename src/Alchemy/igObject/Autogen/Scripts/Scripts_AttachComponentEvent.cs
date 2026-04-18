namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, metaType: typeof(CDotNetCombatNodeEvent))]
    public class Scripts_AttachComponentEvent : CDotNetCombatNodeEvent
    {
        [FieldAttr(nst: 32)] public ECombatTargetSelect CombatTargets;
        [FieldAttr(nst: 40)] public CEntityComponentData? _componentToAttach;
        [FieldAttr(nst: 48)] public CEntityMessage? _entityMessage;
        [FieldAttr(nst: 56)] public bool _sendMessageToSponsor;
        [FieldAttr(nst: 60)] public CEntityMessage.ENetworkSendRestriction _networkComponentAttachment;
    }
}
