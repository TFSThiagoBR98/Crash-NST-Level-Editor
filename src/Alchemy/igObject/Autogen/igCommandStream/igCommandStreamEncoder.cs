namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 8)]
    public class igCommandStreamEncoder : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igSortKeyCommandInterpreter? _interpreter;
        [FieldAttr(nst: 24, ctr: 24)] public igAtomicHeapCommandStream[] _stream = new igAtomicHeapCommandStream[2];
        [FieldAttr(nst: 40, ctr: 40)] public igBitMask? _setEncoderFunctions;
        [FieldAttr(nst: 48)] public igVectorMetaField<igRawRefMetaField> _encoderFunctionsVector = new();
        [FieldAttr(nst: 72)] public igRawRefMetaField _encoderFunctions = new();
        [FieldAttr(nst: 80, ctr: 80)] public int _encoderFunctionsCount;
        [FieldAttr(nst: 88, ctr: 88)] public igCommandStreamEncoderPassState? _defaultPassState;
        [FieldAttr(nst: 96, ctr: 96)] public igCommandStreamEncoderPassState? _passState;
        [FieldAttr(nst: 104, ctr: 104, refCount: false)] public igGraphicsMaterial? _lastMaterial;
        [FieldAttr(nst: 112, ctr: 112, refCount: false)] public igGraphicsEffect? _lastEffect;
        [FieldAttr(nst: 120, ctr: 120)] public int _lastTechnique = -1;
        [FieldAttr(nst: 124, ctr: 124)] public u16 _lastTechniqueFlags;
    }
}
