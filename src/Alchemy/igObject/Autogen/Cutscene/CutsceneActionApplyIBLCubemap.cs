namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CutsceneActionApplyIBLCubemap : CCutsceneAction
    {
        [FieldAttr(nst: 24)] public string? _cubemap = null;
        [FieldAttr(nst: 32)] public igObjectDirectory? _cubemapDirectory;
    }
}
