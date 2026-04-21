using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 128, ctr: 128)]
    public class hkbProjectStringData : hkReferencedObject
    {
        public override uint Hash => 0xca08c2ba;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<string> _animationFilenames;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<string> _behaviorFilenames;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<string> _characterFilenames;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<string> _eventNames;
        [FieldAttr(nst: 80, ctr: 80)] public string? _animationPath;
        [FieldAttr(nst: 88, ctr: 88)] public string? _behaviorPath;
        [FieldAttr(nst: 96, ctr: 96)] public string? _characterPath;
        [FieldAttr(nst: 104, ctr: 104)] public string? _scriptsPath;
        [FieldAttr(nst: 112, ctr: 112)] public string? _fullPathToSource;
        [FieldAttr(nst: 120, ctr: 120)] public string? _rootPath;
    }
}