namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CScreenspaceTarget : igObject
    {
        public enum EScreenspaceTargetShape
        {
            eSSTS_Box = 0,
            eSSTS_Circle = 1,
        }

        [FieldAttr(nst: 16)] public CScreenspaceTargetShape? _shape;
        [FieldAttr(nst: 24)] public float _depth;
        [FieldAttr(nst: 32)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 40)] public bool _isVisible;
        [FieldAttr(nst: 41)] public bool _isOnScreen;
        [FieldAttr(nst: 42)] public bool _isObscured;
        [FieldAttr(nst: 43)] public bool _isInRange;
        [FieldAttr(nst: 44)] public igVec3fMetaField _cachedEntityCenter = new();
        [FieldAttr(nst: 56)] public uint _updateIndex;
        [FieldAttr(nst: 64, refCount: false)] public CHavokQuery? _obscuredQuery;
    }
}
