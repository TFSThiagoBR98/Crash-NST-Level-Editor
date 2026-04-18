namespace Alchemy
{
    [ObjectAttr(nst: 232, ctr: 224, align: 8)]
    public class CDynamicClipEntity : CGameEntity
    {
        [ObjectAttr(size: 2)]
        public class ClipTypeStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _clipTeamHero;
            [FieldAttr(offset: 1, size: 1)] public bool _clipNPCEnemies;
            [FieldAttr(offset: 2, size: 1)] public bool _clipPlayers;
            [FieldAttr(offset: 3, size: 1)] public bool _clipNPCAltEnemies;
            [FieldAttr(offset: 4, size: 1)] public bool _clipWorld;
        }

        [FieldAttr(nst: 224, ctr: 220)] public bool _clipEnabled = true;
        [FieldAttr(nst: 226, ctr: 222)] public ClipTypeStorage _clipTypeStorage = new();
    }
}
