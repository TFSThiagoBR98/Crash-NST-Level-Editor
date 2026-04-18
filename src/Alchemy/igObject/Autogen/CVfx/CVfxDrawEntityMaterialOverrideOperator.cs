namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 40, align: 8)]
    public class CVfxDrawEntityMaterialOverrideOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 17)] public bool _applyToBoltOns = true;
        [FieldAttr(nst: 40, ctr: 24)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(nst: 48, ctr: 32)] public uint _primitive;
    }
}
