namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_LoopingVfxHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public CVfxEffectDotNetHandle? LoopingVfxData;
        [FieldAttr(nst: 88)] public CBoltPoint? LoopingVfxBoltPoint01;
        [FieldAttr(nst: 96)] public CBoltPoint? LoopingVfxBoltPoint02;
        [FieldAttr(nst: 104)] public bool HardKill;
    }
}
