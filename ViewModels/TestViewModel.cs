using ReactiveUI;
using System;
using System.Reactive;
using System.Reactive.Linq;

public class TestViewModel : ReactiveObject
{
    private readonly TestService _testService;
    public ReactiveCommand<string, Unit> SomeCommand { get; }

    private string _customText = "";
    public string CustomText
    {
        get => _customText;
        set => this.RaiseAndSetIfChanged(ref _customText, value);
    }

    private bool _showAlert;
    public bool ShowAlert
    {
        get => _showAlert;
        set => this.RaiseAndSetIfChanged(ref _showAlert, value);
    }

    public TestViewModel(TestService testService)
    {
        _testService = testService;

        _testService.DataChanged
            .Subscribe(data =>
            {
                CustomText = data;
                ShowAlert = true;
            });

        SomeCommand = ReactiveCommand.Create<string, Unit>(ExecuteCommand);
    }

    private Unit ExecuteCommand(string newData)
    {
        _testService.OnDataChanged(newData);

        return Unit.Default;
    }
}
