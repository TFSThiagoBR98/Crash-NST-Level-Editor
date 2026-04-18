namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CCutsceneUnlockDoorFaction : igObject
    {
        [FieldAttr(ctr: 12)] public EOctaneAdventureCutscene _adventureCutscene;
        [FieldAttr(ctr: 16)] public CEdcInfo? _edcUnlockDoor;
        [FieldAttr(ctr: 24)] public CSound? _edcUnlockDoorMusic;
        [FieldAttr(ctr: 32)] public CWaypoint? _playerPosition;
    }
}
