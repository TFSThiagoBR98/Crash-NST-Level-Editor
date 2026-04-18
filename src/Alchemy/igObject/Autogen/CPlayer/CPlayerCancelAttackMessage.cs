namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CPlayerCancelAttackMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public EPlayerCancelAttackReason _cancelReason = EPlayerCancelAttackReason.ePCAR_Other;
    }
}
