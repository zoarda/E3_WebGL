using Naninovel;

[CommandAlias("DayProperty")]
public class DayProperty : Command
{
    [ParameterAlias("Mode")]
    public StringParameter Mode;
    [ParameterAlias("Script")]
    public StringParameter Script;
    [ParameterAlias("Day")]
    public DecimalParameter Day;
    [ParameterAlias("Daylabel")]
    public StringParameter DayLabel;
    [ParameterAlias("UnDaylabel")]
    public StringParameter UnDayLabel;
    protected virtual string script => Script;
    protected virtual string daylabel => DayLabel;
    protected virtual string undaylabel => UnDayLabel;
    protected virtual float day => Day;
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        if (Mode == "Set")
        {
            StartNani startNani = StartNani.Instance;
            startNani.SetDay(day);
        }
        else if (Mode == "Get")
        {
            StartNani startNani = StartNani.Instance;
            startNani.GetDayscript(script,daylabel,undaylabel,day);
        }
        await UniTask.CompletedTask;
    }
}
