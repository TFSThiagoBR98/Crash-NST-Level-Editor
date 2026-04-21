using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 208, ctr: 208)]
    public class hkbManualSelectorGenerator : hkbGenerator
    {
        public override uint Hash => 0xeed8d5cd;

        [FieldAttr(nst: 136, ctr: 136)] public hkMemory<hkbGenerator> _generators;
        [FieldAttr(nst: 152, ctr: 152)] public i16 _selectedGeneratorIndex;
        [FieldAttr(nst: 160, ctr: 160)] public hkbCustomIdSelector? _indexSelector;
        [FieldAttr(nst: 168, ctr: 168)] public bool _selectedIndexCanChangeAfterActivate;
        [FieldAttr(nst: 176, ctr: 176)] public hkbTransitionEffect? _generatorChangedTransitionEffect;
        [FieldAttr(nst: 184, ctr: 184)] public i16 _currentGeneratorIndex;
        [FieldAttr(nst: 186, ctr: 186)] public i16 _generatorIndexAtActivate;
        [FieldAttr(nst: 192, ctr: 192)] public hkMemory<uint> _activeTransitions;
    }
}