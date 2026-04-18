namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_BoltEntityComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_BoltEntityComponent_
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _EntityToBoltTo = new();
        [FieldAttr(nst: 48)] public bool AttachToParent;
        [FieldAttr(nst: 56)] public CBoltPoint? cBoltPoint;
        [FieldAttr(nst: 64)] public bool bCollision;
        [FieldAttr(nst: 65)] public bool bPositionOffset;
        [FieldAttr(nst: 66)] public bool bSingleFrame;
        [FieldAttr(nst: 67)] public bool bKeepAngles;
        [FieldAttr(nst: 68)] public bool AuthorityOnly;
    }
}
