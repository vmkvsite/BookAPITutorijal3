﻿namespace predavanje9.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //Da li smo pročitali knjigu
        public bool IsRead { get; set; }
        //datum kada smo ju pročitali (nullable Datetime - ako ju nismo pročitala datumće 
        //imati vrijednost null)

    
    public DateTime? DateRead { get; set; }
        //ocjena (nullable int - ako ju nismo pročitali ne možemo ju ocijeniti pa će
        //vrijednost biti null)
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverPictureURL { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
