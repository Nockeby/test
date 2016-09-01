Hello everybody,

I have a small problem with my wpf plugin. It has to do with the display of the wpf window when trying to use styles. 

I have recreated the problem [here](https://github.com/Nockeby/test), in case you want to look at it in depth.
The wpf window is opened with test.testCommand and it works fine until I try to apply a style to the wpf window (WpfApplication1.MainWindow.xaml):

```xaml
<Window x:Class="WpfApplication1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApplication1"
        mc:Ignorable="d"
        Title="MainWindow" Height="350" Width="525"
        Style="{StaticResource CustomWindow}">
</Window>
```

`Style="{StaticResource CustomWindow}"` naturally links to the App.xaml file but it crashes Rhino when executed this way. If `Style="{StaticResource CustomWindow}"` is omitted everything works again.

The App.xaml looks like this:
```xaml
<Application x:Class="WpfApplication1.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:WpfApplication1"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <Style x:Key="CustomWindow" TargetType="{x:Type Window}">
            <Setter Property="Background" Value="Yellow"/>
            <Setter Property="BorderBrush" Value="Green"/>
            <Setter Property="BorderThickness" Value="5"/>
            <Setter Property="Foreground" Value="DarkRed"/>
        </Style>
    </Application.Resources>
</Application>
```

I couldn't find anything about this online. Is this a known issue or am I forgetting something?
Thanks for your help!
