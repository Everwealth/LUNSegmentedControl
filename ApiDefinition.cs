using System;
using Foundation;
using LUNSegmentedControl;
using ObjCRuntime;
using UIKit;

namespace LUNSegmentedControl
{
    // @interface LUNGradientView : UIView
    [BaseType(typeof(UIView))]
    interface LUNGradientView
    {
    }

    // @protocol LUNSegmentedControlDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface LUNSegmentedControlDelegate
    {
        // @optional -(void)segmentedControl:(LUNSegmentedControl *)segmentedControl didChangeStateFromStateAtIndex:(NSInteger)fromIndex toStateAtIndex:(NSInteger)toIndex;
        [Export("segmentedControl:didChangeStateFromStateAtIndex:toStateAtIndex:")]
        void DidChangeStateFromStateAtIndex(LUNSegmentedControl segmentedControl, nint fromIndex, nint toIndex);

        // @optional -(void)segmentedControl:(LUNSegmentedControl *)segmentedControl willChangeStateFromStateAtIndex:(NSInteger)fromIndex;
        [Export("segmentedControl:willChangeStateFromStateAtIndex:")]
        void WillChangeStateFromStateAtIndex(LUNSegmentedControl segmentedControl, nint fromIndex);

        // @optional -(void)segmentedControl:(LUNSegmentedControl *)segmentedControl didScrollWithXOffset:(CGFloat)offset;
        [Export("segmentedControl:didScrollWithXOffset:")]
        void DidScrollWithXOffset(LUNSegmentedControl segmentedControl, nfloat offset);

        // @optional -(void)segmentedControl:(LUNSegmentedControl *)segmentedControl setupStateAtIndex:(NSInteger)stateIndex stateView:(UIView *)stateView selectedView:(UIView *)selectedView withSelectionPercent:(CGFloat)percent;
        [Export("segmentedControl:setupStateAtIndex:stateView:selectedView:withSelectionPercent:")]
        void SetupStateAtIndex(LUNSegmentedControl segmentedControl, nint stateIndex, UIView stateView, UIView selectedView, nfloat percent);

        // @optional -(void)segmentedControl:(LUNSegmentedControl *)segmentedControl resetStateAtIndex:(NSInteger)stateIndex stateView:(UIView *)stateView selectedView:(UIView *)selectedView;
        [Export("segmentedControl:resetStateAtIndex:stateView:selectedView:")]
        void ResetStateAtIndex(LUNSegmentedControl segmentedControl, nint stateIndex, UIView stateView, UIView selectedView);

        // @optional -(void)segmentedControl:(LUNSegmentedControl *)segmentedControl setupShadowView:(UIView *)shadowView;
        [Export("segmentedControl:setupShadowView:")]
        void SetupShadowView(LUNSegmentedControl segmentedControl, UIView shadowView);
    }

    // @protocol LUNSegmentedControlDataSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface LUNSegmentedControlDataSource
    {
        // @required -(NSInteger)numberOfStatesInSegmentedControl:(LUNSegmentedControl *)segmentedControl;
        [Abstract]
        [Export("numberOfStatesInSegmentedControl:")]
        nint NumberOfStatesInSegmentedControl(LUNSegmentedControl segmentedControl);

        // @optional -(NSArray<UIColor *> *)segmentedControl:(LUNSegmentedControl *)segmentedControl gradientColorsForStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:gradientColorsForStateAtIndex:")]
        UIColor[] SegmentedControl(LUNSegmentedControl segmentedControl, nint index);

        // @optional -(NSArray<UIColor *> *)segmentedControl:(LUNSegmentedControl *)segmentedControl gradientColorsForBounce:(LUNSegmentedControlBounce)bounce;
        [Export("segmentedControl:gradientColorsForBounce:")]
        UIColor[] SegmentedControl(LUNSegmentedControl segmentedControl, LUNSegmentedControlBounce bounce);

        // @optional -(NSString *)segmentedControl:(LUNSegmentedControl *)segmentedControl titleForStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:titleForStateAtIndex:")]
        string SegmentedControl(LUNSegmentedControl segmentedControl, nint index);

        // @optional -(NSAttributedString *)segmentedControl:(LUNSegmentedControl *)segmentedControl attributedTitleForStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:attributedTitleForStateAtIndex:")]
        NSAttributedString SegmentedControl(LUNSegmentedControl segmentedControl, nint index);

        // @optional -(NSString *)segmentedControl:(LUNSegmentedControl *)segmentedControl titleForSelectedStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:titleForSelectedStateAtIndex:")]
        string SegmentedControl(LUNSegmentedControl segmentedControl, nint index);

        // @optional -(NSAttributedString *)segmentedControl:(LUNSegmentedControl *)segmentedControl attributedTitleForSelectedStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:attributedTitleForSelectedStateAtIndex:")]
        NSAttributedString SegmentedControl(LUNSegmentedControl segmentedControl, nint index);

        // @optional -(UIView *)segmentedControl:(LUNSegmentedControl *)segmentedControl viewForStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:viewForStateAtIndex:")]
        UIView SegmentedControl(LUNSegmentedControl segmentedControl, nint index);

        // @optional -(UIView *)segmentedControl:(LUNSegmentedControl *)segmentedControl viewForSelectedStateAtIndex:(NSInteger)index;
        [Export("segmentedControl:viewForSelectedStateAtIndex:")]
        UIView SegmentedControl(LUNSegmentedControl segmentedControl, nint index);
    }

    // @interface LUNSegmentedControl : UIView
    [BaseType(typeof(UIView))]
    interface LUNSegmentedControl
    {
        [Wrap("WeakDelegate")]
        LUNSegmentedControlDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<LUNSegmentedControlDelegate> delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<LUNSegmentedControlDataSource> dataSource __attribute__((iboutlet));
        [Export("dataSource", ArgumentSemantic.Weak)]
        LUNSegmentedControlDataSource DataSource { get; set; }

        // @property (assign, nonatomic) NSInteger currentState;
        [Export("currentState")]
        nint CurrentState { get; set; }

        // @property (assign, nonatomic) NSInteger statesCount;
        [Export("statesCount")]
        nint StatesCount { get; set; }

        // @property (assign, nonatomic) LUNSegmentedControlTransitionStyle transitionStyle;
        [Export("transitionStyle", ArgumentSemantic.Assign)]
        LUNSegmentedControlTransitionStyle TransitionStyle { get; set; }

        // @property (assign, nonatomic) LUNSegmentedControlShapeStyle shapeStyle;
        [Export("shapeStyle", ArgumentSemantic.Assign)]
        LUNSegmentedControlShapeStyle ShapeStyle { get; set; }

        // @property (assign, nonatomic) CGFloat transitionDuration;
        [Export("transitionDuration")]
        nfloat TransitionDuration { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic, strong) UIColor * selectedStateTextColor;
        [Export("selectedStateTextColor", ArgumentSemantic.Strong)]
        UIColor SelectedStateTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * selectorViewColor;
        [Export("selectorViewColor", ArgumentSemantic.Strong)]
        UIColor SelectorViewColor { get; set; }

        // @property (nonatomic) CGFloat selectorViewBorderWidth;
        [Export("selectorViewBorderWidth")]
        nfloat SelectorViewBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * selectorViewBorderColor;
        [Export("selectorViewBorderColor", ArgumentSemantic.Strong)]
        UIColor SelectorViewBorderColor { get; set; }

        // @property (nonatomic, strong) UIFont * textFont;
        [Export("textFont", ArgumentSemantic.Strong)]
        UIFont TextFont { get; set; }

        // @property (assign, nonatomic) BOOL applyCornerRadiusToSelectorView;
        [Export("applyCornerRadiusToSelectorView")]
        bool ApplyCornerRadiusToSelectorView { get; set; }

        // @property (nonatomic, strong) UIColor * gradientBounceColor;
        [Export("gradientBounceColor", ArgumentSemantic.Strong)]
        UIColor GradientBounceColor { get; set; }

        // @property (assign, nonatomic) CGFloat shadowShowDuration;
        [Export("shadowShowDuration")]
        nfloat ShadowShowDuration { get; set; }

        // @property (assign, nonatomic) CGFloat shadowHideDuration;
        [Export("shadowHideDuration")]
        nfloat ShadowHideDuration { get; set; }

        // @property (assign, nonatomic) BOOL shadowsEnabled;
        [Export("shadowsEnabled")]
        bool ShadowsEnabled { get; set; }

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();
    }

    // @interface LUNRemoveConstraints (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_LUNRemoveConstraints
    {
        // -(void)lun_removeConstraintsFromSubTree:(NSSet<NSLayoutConstraint *> *)constraints;
        [Export("lun_removeConstraintsFromSubTree:")]
        void Lun_removeConstraintsFromSubTree(NSSet<NSLayoutConstraint> constraints);
    }

    [Static]
    partial interface Constants
    {
        // extern double LUNSegmentedControlVersionNumber;
        [Field("LUNSegmentedControlVersionNumber", "__Internal")]
        double LUNSegmentedControlVersionNumber { get; }

        // extern const unsigned char [] LUNSegmentedControlVersionString;
        [Field("LUNSegmentedControlVersionString", "__Internal")]
        byte[] LUNSegmentedControlVersionString { get; }
    }
}