namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CVScriptFindGroundQueryHolder : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _query = new();
        [FieldAttr(nst: 24)] public igVscVec3fDelegateMetaField _groundPositionCallback = new();
        [FieldAttr(nst: 40)] public igVscVec3fDelegateMetaField _groundNormalCallback = new();
        [FieldAttr(nst: 56)] public igVscDelegateMetaField _finishedCallback = new();
        [FieldAttr(nst: 72)] public igVscDelegateMetaField _failedCallback = new();
    }
}
