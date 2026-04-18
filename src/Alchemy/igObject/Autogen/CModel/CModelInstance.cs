namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CModelInstance : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool mIsLinked;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public CGameEntity? mEntity;
        [FieldAttr(nst: 40, ctr: 40)] public igModelInstance? mIgModel;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public CModelInstance? mBoltTargetModel;
        [FieldAttr(nst: 56, ctr: 56)] public CBoltedModelList? mBoltedModels;
        [FieldAttr(nst: 64, ctr: 64)] public EAnimationEventMask _animationEventMask;
    }
}
