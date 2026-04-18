namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, meta: true)]
    public class CPlayerMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public EPlayerId _player = EPlayerId.EPLAYERID_NONE;
    }
}
