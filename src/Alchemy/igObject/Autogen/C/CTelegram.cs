namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CTelegram : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CEntityMessage? _sendingMessage;
        [FieldAttr(nst: 24, ctr: 24)] public float _messageSendDelayOverride = -1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _randomMaxDelayOverride = -1.0f;
        [FieldAttr(nst: 32, ctr: 32)] public CEntityTargetList? _sendMessageTargets;
        [FieldAttr(nst: 40, ctr: 40)] public uint _additionalTargets;
        [FieldAttr(nst: 44, ctr: 44)] public bool _actOnTargets;
    }
}
