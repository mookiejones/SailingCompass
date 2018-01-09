using System;
using System.Windows;
using System.Windows.Controls;
using Kompass.Properties;

namespace Kompass.Shared.Controls
{
    [TemplatePart(Name=PART_AntiAliasing,Type=typeof(CheckBox))]
    [TemplatePart(Name=PART_CourseLine,Type=typeof(CheckBox))]
    [TemplatePart(Name=PART_TurningAngle,Type=typeof(CheckBox))]
    [TemplatePart(Name=Part_TrueBearing,Type=typeof(TextBox))]
    [TemplatePart(Name=PART_CourseUpMode,Type=typeof(CheckBox))]
    [TemplatePart(Name=PART_WindDirection,Type=typeof(CheckBox))]
    [TemplatePart(Name=PART_Opacity,Type=typeof(Slider))]
    public class Options:Control
    {
        #region · Constants ·

        public const string PART_Opacity = "PART_Opacity";
        public const string PART_AntiAliasing="PART_AntiAliasing";
        private const string PART_CourseLine="PART_CourseLine";
        private const string PART_TurningAngle="PART_TurningAngle";
        private const string Part_TrueBearing="Part_TrueBearing";
        private const string PART_CourseUpMode="PART_CourseUpMode";
        private const string PART_WindDirection="PART_WindDirection";
        #endregion


        #region · Members ·

        private CheckBox _antiAliasing;
        private CheckBox _courseLine;
        private CheckBox _turningAngle;
        private TextBox _trueBearing;
        private CheckBox _courseUp;
        private CheckBox _windDirection;
        private Slider _partOpacity;
        #endregion

        
        static Options()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Options), new FrameworkPropertyMetadata(typeof(Options)));

        }

        public Options()
        {

        }

        #region Overrides of FrameworkElement

        private void SetDefaultValues()
        {
            _antiAliasing.IsChecked = Settings.Default.AntiAlias;
            _partOpacity.Value = Settings.Default.Opacity;
         
        }

        private void RegisterEvents()
        {
            _antiAliasing.Click += OnAntiAliasingChanged;
            _courseLine.Click += OnCourselineChecked;
            _turningAngle.Click += OnTurningAngleChanged;
            _trueBearing.TextChanged += OnTrueBearingChanged;
            _courseUp.Click += OnCourseUpChanged;
            _windDirection.Click += OnWindDirectionChanged;
            _partOpacity.ValueChanged += OnOpacityChanged;
        }

        private void OnOpacityChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Settings.Default.Opacity = _partOpacity.Value;
            Opacity = _partOpacity.Value;
            Settings.Default.Save();
        }

        private void OnAntiAliasingChanged(object sender, RoutedEventArgs e)
        {
            Settings.Default.AntiAlias = _antiAliasing.IsChecked == true;
            Settings.Default.Save();
        }

        /// <summary>When overridden in a derived class, is invoked whenever application code or internal processes call <see cref="M:System.Windows.FrameworkElement.ApplyTemplate" />.</summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _antiAliasing = GetTemplateChild(PART_AntiAliasing) as CheckBox;
            _courseLine = GetTemplateChild(PART_CourseLine) as CheckBox;
            _turningAngle = GetTemplateChild(PART_TurningAngle) as CheckBox;
            _trueBearing = GetTemplateChild(Part_TrueBearing) as TextBox;
            _courseUp=GetTemplateChild(PART_CourseUpMode)as CheckBox;
            _windDirection = GetTemplateChild(PART_WindDirection) as CheckBox;
            _partOpacity=GetTemplateChild(PART_Opacity)as Slider;
          
            SetDefaultValues();
            RegisterEvents();
            


       

        }

        private void OnWindDirectionChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnCourseUpChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnTrueBearingChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnTurningAngleChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnCourselineChecked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
