namespace Passkeeper.Model
{
	public abstract class Storable
	{
		protected abstract void LoadData();
		protected abstract void SaveToFile();
	}
}
