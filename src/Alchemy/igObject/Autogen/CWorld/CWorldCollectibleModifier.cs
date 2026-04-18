namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CWorldCollectibleModifier : igObject
    {
        [FieldAttr(ctr: 16)] public string? _modelName;
        [FieldAttr(ctr: 24)] public igStringRefList? _modelNames;
        [FieldAttr(ctr: 32)] public CWorldCollectibleModifierItemList? _items;
        [FieldAttr(ctr: 40)] public igEntity? _collectibleReplacementEntity;
        [FieldAttr(ctr: 48)] public float _awardValueOverride;
        [FieldAttr(ctr: 52)] public float _alternateAwardValueOverride;
        [FieldAttr(ctr: 56)] public float _attractRadiusOverride;
    }
}
