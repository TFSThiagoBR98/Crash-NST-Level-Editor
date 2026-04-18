namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CPlayerAttackComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _heightToBeginJumpAttacks = 100.0f;
        [FieldAttr(nst: 32, ctr: 24)] public CPlayerAttackDataTable? _dataTable;
    }
}
