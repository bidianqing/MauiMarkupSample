using CommunityToolkit.Maui.Markup;

namespace MauiMarkupSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        var vm = new ViewModel();
        base.BindingContext = vm;

        var entry = new Entry
        {
            Placeholder = "请输入内容"
        }.Bind(Entry.TextProperty, (ViewModel vm) => vm.RegistrationCode);

        var button = new Button
        {
            Text = "Click me",
            Command = vm.TestCommand
        };

        var verticalStackLayout = new VerticalStackLayout
        {
            VerticalOptions = LayoutOptions.Center,
        };

        verticalStackLayout.Add(entry);
        verticalStackLayout.Add(button);
        

        var ScrollView = new ScrollView
        {
            Content = verticalStackLayout
        };

        base.Content = ScrollView;
    }
}

