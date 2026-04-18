namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CVScriptCastQueryHolder : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _query = new();
        [FieldAttr(nst: 24)] public CNovaCollisionInfoListVscDelegateMetaField _collisionListDelegate = new();
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _finishedCallback = new();
        [FieldAttr(nst: 56)] public igVscDelegateMetaField _failedCallback = new();
    }
}
