namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            Console.WriteLine("InOrder Traversal For Given Is BST ");
            binarySearch.Display();
            Console.ReadLine();
        }
    }
}