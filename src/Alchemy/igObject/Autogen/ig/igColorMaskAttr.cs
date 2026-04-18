namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class igColorMaskAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 17)] public bool _red = true;
        [FieldAttr(nst: 25, ctr: 18)] public bool _green = true;
        [FieldAttr(nst: 26, ctr: 19)] public bool _blue = true;
        [FieldAttr(nst: 27, ctr: 20)] public bool _alpha = true;
        [FieldAttr(nst: 28, ctr: 24)] public uint _unused;
    }
}
