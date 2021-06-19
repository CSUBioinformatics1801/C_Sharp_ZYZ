using System;
using System.Collections.Generic;
namespace Test6_5{
    public class Book : IEquatable<Book>{
        public string BookName { get; set; }
        public int BookId { get; set; }
        public string Writer_Name{get;set;}
        public override string ToString(){
            return BookName +" <" + BookId + "> "+ Writer_Name;
        }
        public override bool Equals(object obj){//check null
            if (obj == null) return false;
            Book objAsBook = obj as Book;
            if (objAsBook == null) return false;
            else return Equals(objAsBook);
        }
        public override int GetHashCode(){//rank by Hash
            return BookId;
        }
        public bool Equals(Book other){
            if (other == null) return false;
            return (this.BookId.Equals(other.BookId));
        }
    }
    public class Reader{
        public string Reader_Name{get;set;}
        public int Reader_ID{get;set;}
        List<Book> borrowed_books=new List<Book>(5);
        public void add_Book(){
            if(borrowed_books.Count==5){
                Console.WriteLine("Borrowings reach the 5 books limits.");
            }
            else{//for example
                borrowed_books.Add(new Book(){BookName="Propagation Dynamics on Complex Networks",BookId=1001,Writer_Name="Xinchu Fu"});
                borrowed_books.Add(new Book(){BookName="Introduction to Algorithms",BookId=1002,Writer_Name="Thomas H. Cormen"});
                borrowed_books.Add(new Book(){BookName="BioBuilder",BookId=1003,Writer_Name="Natalie Kuldell"});
            }
        }
        public void show_Book(){
            Console.WriteLine("Reader Name: {0}, ID = {1}\nCurrent borrowed: {2}",Reader_Name,Reader_ID,borrowed_books.Count);
            int num=0;
            foreach(Book S in borrowed_books){
                num++;
                Console.Write("\t{0}.",num);
                Console.WriteLine(S);
            }
        }
        public Reader(int Reader_ID,string Reader_Name){
            this.Reader_ID=Reader_ID;
            this.Reader_Name=Reader_Name;
        }
    }
    public class Example{
        public static void Main(){
            Reader r1=new Reader(1001,"Ian");
            r1.add_Book();
            r1.show_Book();
        }
    }
}
