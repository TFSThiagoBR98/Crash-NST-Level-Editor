namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVfxDrawDeathEffectOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 32, ctr: 24)] public uint _primitiveData;
    }
}
