namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CInteractionComponentData : CEntityComponentData
    {
        public enum EOnlineRestriction
        {
            eOR_HostArbitrated = 0,
            eOR_LocalPlayerOnly = 1,
        }

        [FieldAttr(nst: 24, ctr: 16)] public float _delayToReactivate = -1.0f;
        [FieldAttr(nst: 28, ctr: 20)] public bool _disableAllInteraction;
        [FieldAttr(nst: 32, ctr: 24)] public CInteractionData? _interactionData;
        [FieldAttr(nst: 40, ctr: 32)] public bool _enabled = true;
        [FieldAttr(nst: 44, ctr: 36)] public float _autoEnableDuration;
        [FieldAttr(nst: 48, ctr: 40)] public EOnlineRestriction _onlineRestriction;
    }
}
