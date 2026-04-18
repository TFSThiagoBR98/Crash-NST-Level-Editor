namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igCheckerboardSetupCall : igDrawCall
    {
        [FieldAttr(nst: 24, ctr: 16)] public igCommandCopyTextureParametersMetaField _copyCommand = new();
    }
}
