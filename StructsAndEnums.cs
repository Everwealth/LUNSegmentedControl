using System;
using ObjCRuntime;

[Native]
public enum LUNSegmentedControlTransitionStyle : nuint
{
	None = 0,
	Slide,
	Fade
}

[Native]
public enum LUNSegmentedControlShapeStyle : nuint
{
	RoundedRect,
	Liquid
}

[Native]
public enum LUNSegmentedControlBounce : nuint
{
	Left,
	Right
}
