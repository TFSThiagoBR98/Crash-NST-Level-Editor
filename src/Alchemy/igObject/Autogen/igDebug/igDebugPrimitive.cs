namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class igDebugPrimitive : igObject
    {
        [FieldAttr(ctr: 12)] public int _framesRemaining;
        [FieldAttr(ctr: 16)] public EIG_GFX_DRAW _primType;
        [FieldAttr(ctr: 24)] public igVectorMetaField<igVec3fMetaField> _positions = new();
        [FieldAttr(ctr: 48)] public igVectorMetaField<uint> _colors = new();
    }
}
