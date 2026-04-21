using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 224, ctr: 224)]
    public class hkbCharacterStringData : hkReferencedObject
    {
        public override uint Hash => 0xb9d8a52;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbCharacterStringDataFileNameMeshNamePair> _skinNames;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<hkbCharacterStringDataFileNameMeshNamePair> _boneAttachmentNames;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkbAssetBundleStringData> _animationBundleNameData;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<hkbAssetBundleStringData> _animationBundleFilenameData;
        [FieldAttr(nst: 80, ctr: 80)] public hkMemory<string> _characterPropertyNames;
        [FieldAttr(nst: 96, ctr: 96)] public hkMemory<string> _retargetingSkeletonMapperFilenames;
        [FieldAttr(nst: 112, ctr: 112)] public hkMemory<string> _lodNames;
        [FieldAttr(nst: 128, ctr: 128)] public hkMemory<string> _mirroredSyncPointSubstringsA;
        [FieldAttr(nst: 144, ctr: 144)] public hkMemory<string> _mirroredSyncPointSubstringsB;
        [FieldAttr(nst: 160, ctr: 160)] public string? _name;
        [FieldAttr(nst: 168, ctr: 168)] public string? _rigName;
        [FieldAttr(nst: 176, ctr: 176)] public string? _ragdollName;
        [FieldAttr(nst: 184, ctr: 184)] public string? _behaviorFilename;
        [FieldAttr(nst: 192, ctr: 192)] public string? _luaScriptOnCharacterActivated;
        [FieldAttr(nst: 200, ctr: 200)] public string? _luaScriptOnCharacterDeactivated;
        [FieldAttr(nst: 208, ctr: 208)] public hkMemory<string> _luaFiles;
    }
}