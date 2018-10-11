using System;
using ObjCRuntime;

namespace Xamarin.Bindings.LUNSegmentedControl
{
    [Native]
    public enum LUNSegmentedControlTransitionStyle : ulong
    {
        None = 0,
        Slide,
        Fade
    }

    [Native]
    public enum LUNSegmentedControlShapeStyle : ulong
    {
        RoundedRect,
        Liquid
    }

    [Native]
    public enum LUNSegmentedControlBounce : ulong
    {
        Left,
        Right
    }
}