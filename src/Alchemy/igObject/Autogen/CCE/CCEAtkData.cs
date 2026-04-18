namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CCEAtkData : igObject
    {
        [FieldAttr(nst: 16)] public float _maxRange;
        [FieldAttr(nst: 20)] public float _dot;
        [FieldAttr(nst: 24)] public bool _ignoreHeroes;
        [FieldAttr(nst: 32)] public CAttackBone? _attackBone;
    }
}
