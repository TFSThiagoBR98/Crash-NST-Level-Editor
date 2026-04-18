namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 24, align: 8)]
    public class CVfxDrawEntityFadeOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 17)] public bool _applyToBoltOns = true;
        [FieldAttr(nst: 36, ctr: 20)] public uint _primitive;
    }
}
