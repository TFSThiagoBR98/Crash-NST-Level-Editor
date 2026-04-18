namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CVfxEnvironmentColorOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class EnvironmentColorFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EModulation _colorModulation = EModulation.kModulate;
            [FieldAttr(offset: 3, size: 1)] public bool _useEnvironmentColor = false;
            [FieldAttr(offset: 4, size: 1)] public bool _useSunColor = false;
            [FieldAttr(offset: 5, size: 1)] public bool _useOverrideCamera;
            [FieldAttr(offset: 6, size: 3)] public igVfxManager.EVfxCamera _overrideCamera;
        }

        [FieldAttr(nst: 24)] public EnvironmentColorFlags _environmentColorFlags = new();
    }
}
