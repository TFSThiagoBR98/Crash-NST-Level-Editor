namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CVfxTextComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _enabledAtStart = true;
        [FieldAttr(nst: 32)] public string? _displayText = null;
        [FieldAttr(nst: 40)] public CVfxFont? _vfxFont;
        [FieldAttr(nst: 48)] public ETextAlignment _textAlignment;
        [FieldAttr(nst: 52)] public float _secondsPerCharacter;
        [FieldAttr(nst: 56)] public igHandleMetaField _startBolt = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _endBolt = new();
        [FieldAttr(nst: 72)] public float _maxWidth;
        [FieldAttr(nst: 76)] public float _maxHeight;
        [FieldAttr(nst: 80)] public float _curveRadius;
        [FieldAttr(nst: 84)] public bool _faceCamera;
    }
}
