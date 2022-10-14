namespace Aula03
{
    internal class Animation : Movie, IAudioControl
    {
        public Animation(int id, string title, int categoryId, string categoryDescription) : base(id, title, categoryId, categoryDescription)
        {
        }

        public void IncreaseVolume()
        {            
            Console.WriteLine("Volume was increased");
        }
    }
}
