namespace Aula03
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }

        public Movie(int id, string title, int categoryId, string categoryDescription)
        {
            Id = id;
            Title = title;
            Category = new Category(categoryId, categoryDescription);
        }

        public void Play()
        {
            Console.WriteLine($"The movie {Title} started");
        }

        public void Stop()
        {
            Console.WriteLine($"The movie {Title} stopped");
        }
    }
}
