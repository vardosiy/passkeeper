namespace Passkeeper.Model
{
	public abstract class Storable
	{
		public abstract void Save();

		protected abstract void LoadData();
		protected abstract void SaveToFile();
	}
}
