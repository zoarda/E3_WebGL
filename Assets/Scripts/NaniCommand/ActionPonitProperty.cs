using Naninovel;

[CommandAlias("ActionPonitProperty")]
public class ActionPonitProperty : Command
{
    [ParameterAlias("Mode")]
    public StringParameter Mode;
    [ParameterAlias("Script")]
    public StringParameter Script;
    [ParameterAlias("ActionPonit")]
    public DecimalParameter ActionPonit;
    [ParameterAlias("ActionPonitlabel")]
    public StringParameter ActionPonitlabel;
    [ParameterAlias("UnActionPonitlabel")]
    public StringParameter UnActionPonitlabel;
    protected virtual string script => Script;
    protected virtual string actionPonitlabel => ActionPonitlabel;
    protected virtual string unActionPonitlabel => UnActionPonitlabel;
    protected virtual float actionPonit => ActionPonit;
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (Mode == "Set")
        {
            StartNani startNani = StartNani.Instance;
            startNani.SetActionPoint(actionPonit);
        }
        else if (Mode == "Get")
        {
            StartNani startNani = StartNani.Instance;
            startNani.GetActionPointScript(script,actionPonitlabel,UnActionPonitlabel,ActionPonit);
        }
        await UniTask.CompletedTask;
    }
}
