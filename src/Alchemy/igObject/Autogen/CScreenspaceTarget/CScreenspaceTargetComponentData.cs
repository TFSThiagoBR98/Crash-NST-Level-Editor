namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4)]
    public class CScreenspaceTargetComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igVec3fMetaField _targetingBoxDimensions = new();
        [FieldAttr(nst: 36)] public bool _targetingBoxOffsetIsWorld = true;
        [FieldAttr(nst: 40)] public igVec3fMetaField _targetingBoxOffset = new();
        [FieldAttr(nst: 52)] public CScreenspaceTarget.EScreenspaceTargetShape _shapeType;
        [FieldAttr(nst: 56)] public bool _requireVisible = true;
        [FieldAttr(nst: 57)] public bool _useTargetingBoxCenter;
    }
}
