namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 8)]
    public class CGuiBehaviorReturnToMainMenuOnDisconnect : CGuiBehavior
    {
        [FieldAttr(ctr: 137)] public bool _requireLobbyOpen;
        [FieldAttr(ctr: 138)] public bool _connected;
    }
}
