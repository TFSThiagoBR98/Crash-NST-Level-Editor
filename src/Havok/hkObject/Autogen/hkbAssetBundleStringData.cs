using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkbAssetBundleStringData : hkObject
    {
        public override uint Hash => 0x46132bad;

        [FieldAttr(nst: 0, ctr: 0)] public string? _bundleName;
        [FieldAttr(nst: 8, ctr: 8)] public hkMemory<string> _assetNames;
    }
}