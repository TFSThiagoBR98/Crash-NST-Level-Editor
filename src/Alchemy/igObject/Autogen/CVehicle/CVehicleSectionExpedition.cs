namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CVehicleSectionExpedition : CVehicleSection
    {
        [FieldAttr(nst: 72)] public bool _sea2dMovement = true;
        [FieldAttr(nst: 73)] public bool _playIntroAnimation = true;
        [FieldAttr(nst: 80)] public CEntityHandleList? _targetEntities;
        [FieldAttr(nst: 88)] public bool _disableWrongWay;
    }
}
