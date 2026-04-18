namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CStaticComponentData : igComponentData
    {
        [ObjectAttr(size: 4)]
        public class FlagsBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EDistanceCullImportance _distanceCullImportance;
            [FieldAttr(offset: 3, size: 1)] public bool _ignoreOcclusionBoxes;
            [FieldAttr(offset: 4, size: 1)] public bool _receiveDecals;
            [FieldAttr(offset: 5, size: 1)] public bool _disableVisual;
            [FieldAttr(offset: 6, size: 1)] public bool _castsShadows;
            [FieldAttr(offset: 7, size: 2)] public EMobileShadowState _mobileShadowState;
            [FieldAttr(offset: 9, size: 1)] public bool _includeInBake;
        }

        [FieldAttr(nst: 24, ctr: 16)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(nst: 32, ctr: 24)] public FlagsBitfield _flagsBitfield = new();
    }
}
