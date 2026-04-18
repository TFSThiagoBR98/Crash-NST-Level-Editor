namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igVfxDebugData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _spawnInvisiblePrimitives;
        [FieldAttr(nst: 17, ctr: 13)] public bool _usePriorities = true;
        [FieldAttr(nst: 18, ctr: 14)] public bool _hardKill = true;
        [FieldAttr(nst: 19, ctr: 15)] public bool _drawDebugFrames;
        [FieldAttr(nst: 20, ctr: 16)] public uint _filmstripRepeat;
        [FieldAttr(nst: 24, ctr: 20)] public igVfxBolt.ECullType _forceCull;
        [FieldAttr(nst: 28, ctr: 24)] public uint _debugVisualizationLevel;
        [FieldAttr(nst: 32, ctr: 32)] public string? _debugBoltBoneName = "";
        [FieldAttr(nst: 40, ctr: 40)] public string? _debugBolt2BoneName = "";
        [FieldAttr(nst: 48, ctr: 48)] public igVec3fMetaField _debugBoltOffset = new();
        [FieldAttr(nst: 60, ctr: 60)] public bool _debugBolt1UseManipulator;
        [FieldAttr(nst: 61, ctr: 61)] public bool _debugBolt2UseManipulator;
        [FieldAttr(nst: 62, ctr: 62)] public bool _debugBoltsHideManipulators;
        [FieldAttr(nst: 64, ctr: 64)] public u16 _spawnLayers = 65535;
        [FieldAttr(nst: 66, ctr: 66)] public bool _showBoltsOnSelection;
        [FieldAttr(nst: 67, ctr: 67)] public bool _boltSelectionMode;
    }
}
