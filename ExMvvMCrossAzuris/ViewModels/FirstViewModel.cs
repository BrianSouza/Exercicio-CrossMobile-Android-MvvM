using Cirrious.MvvmCross.ViewModels;

namespace ExMvvMCrossAzuris.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		/*
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
		*/

		private string sNome;
		private string sSobrenome;
		private string sNomeCompleto;

		public string SNomeCompleto {
			get {
				return string.Format ("{0} {1}", sNome, sSobrenome);
			}
		}

		public string SSobrenome {
			get {
				return sSobrenome;
			}
			set {
				sSobrenome = value;
				RaisePropertyChanged (() => SSobrenome);
				RaisePropertyChanged (() => SNomeCompleto);
			}
		}

		public string SNome {
			get {
				return sNome;
			}
			set {
				sNome = value;
				RaisePropertyChanged (() => SNome);
				RaisePropertyChanged (() => SNomeCompleto);
			}
		}
	}
}
