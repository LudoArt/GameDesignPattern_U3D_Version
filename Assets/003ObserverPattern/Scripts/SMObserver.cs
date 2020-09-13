
public class SMObserver : Observer
{
    public override void OnNotify(CustomEvent _event)
    {
        switch (_event)
        {
            case CustomEvent.OPENTITLE:
                SoundManager.Instance.PlayTitleBGM();
                break;
            case CustomEvent.CLOSETITLE:
                SoundManager.Instance.PlayBGM();
                break;
            default:
                break;
        }
    }
}
