namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CCharacterInfo : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _frame;
        [FieldAttr(nst: 20, ctr: 16)] public float _widthAdjust;
        [FieldAttr(nst: 24, ctr: 20)] public float _kernTL;
        [FieldAttr(nst: 28, ctr: 24)] public float _kernTR;
        [FieldAttr(nst: 32, ctr: 28)] public float _kernBL;
        [FieldAttr(nst: 36, ctr: 32)] public float _kernBR;
        [FieldAttr(nst: 40, ctr: 40)] public string? _referenceCharacter = null;
    }
}
