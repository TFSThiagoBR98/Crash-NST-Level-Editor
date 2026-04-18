namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class igCullFaceAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 17)] public bool _enabled = true;
        [FieldAttr(nst: 28, ctr: 20)] public EIG_GFX_CULL_FACE_MODE _mode;
    }
}
