namespace Mediator.Ejercicio
{
    public class CheckBox : ManejadorEventos
	{
		private bool IsChecked;

		public virtual bool Checked
		{
			get
			{
				return IsChecked;
			}
			set
			{
				IsChecked = value;
				ProcesarEvento();
			}
		}

	}
}
