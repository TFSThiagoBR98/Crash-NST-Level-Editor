namespace Alchemy
{
    [ObjectAttr(nst: 448, align: 8)]
    public class CVfxDrawSweptForceOperator : CVfxDrawForceOperator
    {
        [ObjectAttr(size: 4)]
        public class SweptFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _endpoint1 = EReferenceFrame.eRF_Track1;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _endpoint2 = EReferenceFrame.eRF_World;
        }

        [FieldAttr(nst: 440)] public SweptFlags _sweptFlags = new();
    }
}
