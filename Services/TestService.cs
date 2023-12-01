using System.Reactive.Subjects;

public class TestService
{
    private readonly Subject<string> _dataChangedSubject = new Subject<string>();

    public IObservable<string> DataChanged => _dataChangedSubject;

    public void OnDataChanged(string data)
    {
        _dataChangedSubject.OnNext(data);
    }
}
