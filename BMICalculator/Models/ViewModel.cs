using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace BMICalculator
{
    public class ViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    #region Height

    public decimal? Height
    {
      get { return _Height; }
      set
      {
        _Height = value;
        PropertyChanged.Raise(this, HeightName);
      }
    }

    private decimal? _Height;
    internal static readonly string HeightName = PropertyName<ViewModel>.Get(_ => _.Height);

    #endregion

    #region Weight

    public decimal? Weight
    {
      get { return _Weight; }
      set
      {
        _Weight = value;
        PropertyChanged.Raise(this, WeightName);
      }
    }

    private decimal? _Weight;
    internal static readonly string WeightName = PropertyName<ViewModel>.Get(_ => _.Weight);

    #endregion

    #region Bmi

    public decimal? Bmi
    {
      get { return _Bmi; }
      set
      {
        _Bmi = value;
        PropertyChanged.Raise(this, BmiName);
      }
    }

    private decimal? _Bmi;
    internal static readonly string BmiName = PropertyName<ViewModel>.Get(_ => _.Bmi);

    #endregion

    #region CalculateCommand

    private void CalculateCommandHandler(object parameter)
    {
      Bmi = null;

      var model = new BmiModel { Height = this.Height.Value, Weight = this.Weight.Value };
      Bmi = model.CalculateBmi();
    }

    public ICommand CalculateCommand
    {
      get
      {
        if (_CalculateCommand == null)
          _CalculateCommand = new DelegateCommand { CommandHandler = this.CalculateCommandHandler };
        return _CalculateCommand;
      }
    }
    private ICommand _CalculateCommand;

    #endregion


  }
}