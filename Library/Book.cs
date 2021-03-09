using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        public Book(int bookid,string bName,string bAuthor,string bPublisher)
        {
            this.bid = bookid;
            this.bName = bName;
            this.bAuthor = bAuthor;
            this.bPublisher = bPublisher;
            this.issued = false;
        }

        public int bid { get; set; }
        public string bName { get; set; }
        public string bAuthor { get; set; }
        public string bPublisher { get; set; }
        public bool issued { get; set; }

    }
}
