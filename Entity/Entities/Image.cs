﻿namespace Entity.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article>? Articles { get; set; }

    }
}
