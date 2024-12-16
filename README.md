# Maui.Skeleton
Skeleton loader for  MAUI apps

## Usage
You must add this namespace to your xaml files:

```XML
xmlns:sk="clr-namespace:Maui.Skeleton;assembly=Maui.Skeleton"
```

Add the following properties to generate a loading animation:

```XML
<CollectionView
                SelectionMode="None"
                VerticalOptions="FillAndExpand"
                BackgroundColor="Transparent"
                ItemTemplate="{StaticResource ItemTemplate}"
                ItemsSource="{Binding Items}"
                sk:Skeleton.IsParent="True"
                sk:Skeleton.IsBusy="{Binding IsBusy}"/>
```

Add the following properties to set a loading animation with a specific background color:

```XML
<Border BackgroundColor="Transparent"
    StrokeShape="RoundRectangle 5"
    sk:Skeleton.IsBusy="{Binding IsBusy}"
    sk:Skeleton.BackgroundColor="#c6c6c5">
    <Label Text="{Binding Title}"
          TextColor="#000000"
          FontSize="20"
          FontAttributes="Bold"
          HorizontalOptions="Start"/>
</Border>
```
### Properties

#### IsParent (Boolean)
- Indicates if it is a parent control which has skeleton children controls.
- The default value is false.

#### IsBusy (Boolean)
- Indicates if the control is busy in a loading state.
- The default value is false.

#### BackgroundColor (Color)
- Control background color when is busy.
- The default value is the xamarin forms default color.

#### Hide (Boolean)
- Indicates if the control is hide when is busy.
- The default value is false.

#### Animation (BaseAnimation)
- Control animation when is busy.
- Possible values: None, Fade, Beat, HorizontalShake, VerticalShake and custom animation inheriting from BaseAnimation.
- The default value is None.

#### AnimationInterval (Int)
- Animation interval when is busy.
- Value in milliseconds.
- The default value is 500.

#### AnimationParameter (Double?)
- Animation parameter to modify the animation.
- The default value is null.
