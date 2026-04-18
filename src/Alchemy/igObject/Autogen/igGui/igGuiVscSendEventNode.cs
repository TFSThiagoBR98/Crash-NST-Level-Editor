namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class igGuiVscSendEventNode : igVscSendMessageNode
    {
        [FieldAttr(nst: 80, ctr: 80)] public igVscBoolAccessor? _sendToChildren;
    }
}
