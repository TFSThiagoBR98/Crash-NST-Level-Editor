namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CCharacterAttribute : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public ECharacterAttribute _attribute = ECharacterAttribute.eCA_MaximumHealth;
        [FieldAttr(nst: 20, ctr: 16)] public float _value;
    }
}
