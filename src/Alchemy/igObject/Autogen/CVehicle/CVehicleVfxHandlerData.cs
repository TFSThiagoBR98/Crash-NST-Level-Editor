namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVehicleVfxHandlerData : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 24)] public CBoltPoint? _bolt1;
        [FieldAttr(nst: 32)] public CBoltPoint? _bolt2;
    }
}
