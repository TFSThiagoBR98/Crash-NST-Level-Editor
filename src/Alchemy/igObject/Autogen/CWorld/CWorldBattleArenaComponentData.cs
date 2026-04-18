namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CWorldBattleArenaComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public int _maxPlayers;
    }
}
