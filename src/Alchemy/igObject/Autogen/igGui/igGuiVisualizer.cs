namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 8)]
    public class igGuiVisualizer : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _drawEnable;
        [FieldAttr(nst: 17, ctr: 13)] public bool _drawFontNames;
        [FieldAttr(nst: 18, ctr: 14)] public bool _drawScreenSafe;
        [FieldAttr(nst: 19, ctr: 15)] public bool _fitToScreen;
        [FieldAttr(nst: 20, ctr: 16)] public bool _printEnable;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiContext? _context;
        [FieldAttr(nst: 32, ctr: 32)] public igAABox? _globalBoundMain;
        [FieldAttr(nst: 40, ctr: 40)] public igAABox? _globalBoundSub;
        [FieldAttr(nst: 48, ctr: 48)] public igVectorMetaField<igGuiPlaceable> _placeables = new();
        [FieldAttr(nst: 72, ctr: 72)] public igVec3fMetaField _scaleMain = new();
        [FieldAttr(nst: 84, ctr: 84)] public igVec3fMetaField _scaleSub = new();
    }
}
