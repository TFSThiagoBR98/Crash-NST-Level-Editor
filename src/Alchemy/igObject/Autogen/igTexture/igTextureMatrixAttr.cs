namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 16)]
    public class igTextureMatrixAttr : igVisualAttribute
    {
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _m = new();
        [FieldAttr(nst: 96, ctr: 96)] public int _unitID = -1;
        [FieldAttr(nst: 100, ctr: 100)] public i16 _outputElementCount = -1;
        [FieldAttr(nst: 102, ctr: 102)] public bool _isProjective;
    }
}
