using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentUWPApp
{
    public class Student : INotifyPropertyChanged
	{
		private string _navn;

		public string Navn
		{
			get { return _navn; }
			set 
				{
					if (_navn != value)
					{
						_navn = value;
						this.OnPropertyChanged();
					}
				}
			}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string Navn = null) 
			=> this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Navn));
	}
}
