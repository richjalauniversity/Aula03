﻿namespace Aula03
{
    internal class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Category(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
