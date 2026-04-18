namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CHubCollectibleData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _podiumAnimName;
        [FieldAttr(ctr: 24)] public CGameEntity? _collectibleEntity;
    }
}
