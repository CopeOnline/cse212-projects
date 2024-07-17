using System.ComponentModel.Design.Serialization;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            if (Left.Contains(value))
                return;
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            if (Right.Contains(value))
                return;
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
       if (Data == value) {
            return true;
        }
        if (value < Data && Left != null) {
            // Search in the left subtree
            return Left.Contains(value);
        } else if (value > Data && Right != null) {
            // Search in the right subtree
            return Right.Contains(value);
        }
        return false;
    }

    public int GetHeight() {
        if (Left == null && Right == null)
            return 1; 
        else {
            int leftHeight = Left != null ? Left.GetHeight() : 0;
            int rightHeight = Right != null ? Right.GetHeight() : 0;

            return 1 + Math.Max(leftHeight, rightHeight);
            }
        }
}