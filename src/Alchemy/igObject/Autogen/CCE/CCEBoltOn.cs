namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8)]
    public class CCEBoltOn : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public string? mModelName = null;
        [FieldAttr(nst: 88)] public string? mSkinName = null;
        [FieldAttr(nst: 96)] public CBoltPoint? mBoltPoint;
        [FieldAttr(nst: 104)] public EBoltonModels mBoltOnSlot;
        [FieldAttr(nst: 108)] public bool mRemoveBoltOn;
        [FieldAttr(nst: 109)] public bool mReplaceCurrent;
    }
}
