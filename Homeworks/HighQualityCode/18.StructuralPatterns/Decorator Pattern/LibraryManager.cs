namespace Decorator
{
    using System;

    public class LibraryManager
    {
        private const int NbDashes = 30;

        public static void Main()
        {
            // Create book
            var book = new Book("McConnell, Steve", "Code Complete", 5);
            book.Display();
            Console.WriteLine(new string('-', NbDashes));

            // Create video
            var video = new Video("Kubrick, Stanley", "A Clockwork Orange", 21, 112);
            video.Display();
            Console.WriteLine(new string('-', NbDashes));

            // Make book borrowable, then borrow and display
            Console.WriteLine("Making book borrowable:");
            var borrowableBook = new Borrowable(book);
            borrowableBook.BorrowItem("Doncho Kostov");
            borrowableBook.BorrowItem("Ivaylo Minkov");
            borrowableBook.Display();
            Console.WriteLine(new string('-', NbDashes));

            // Make video borrowable, then borrow and display
            Console.WriteLine("Making video borrowable:");
            var borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Nikolay Kenov");
            borrowableVideo.BorrowItem("Minko Kenov");
            borrowableVideo.Display();
            Console.WriteLine(new string('-', NbDashes));

            // Make only video buy-able
            Console.WriteLine("Making video buyable:");
            var buyableAndBorrowableVideo = new Buyable(borrowableVideo, 24);
            buyableAndBorrowableVideo.Display();
            Console.WriteLine(new string('-', NbDashes));
        }
    }
}
