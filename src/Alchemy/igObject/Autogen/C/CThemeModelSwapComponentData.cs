namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CThemeModelSwapComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public EThemeModelType _swapType;
    }
}
