﻿namespace BibliotheksverwaltungLib
{
    public class Book
    {
        public Book(Guid id, string title, string category)
        {
            Id = id;
            Title = title;
            Category = category;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
    }
}
