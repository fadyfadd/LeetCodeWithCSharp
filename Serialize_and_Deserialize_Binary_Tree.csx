#r "nuget:xunit, 2.5.0"
using Xunit;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class SerializeDeserializeBinaryTree
{
    public string serialize(TreeNode root)
    {
        if (root == null)
            return "X,";

        return root.val + "," + serialize(root.left) + serialize(root.right);
    }

    public TreeNode deserialize(string data)
    {
        Queue<string> nodes = new Queue<string>(data.Split(',', StringSplitOptions.RemoveEmptyEntries));
        return DeserializeHelper(nodes);
    }

    private TreeNode DeserializeHelper(Queue<string> nodes)
    {
        string val = nodes.Dequeue();
        if (val == "X")
            return null;

        TreeNode node = new TreeNode(int.Parse(val));
        node.left = DeserializeHelper(nodes);
        node.right = DeserializeHelper(nodes);
        return node;
    }
}

{
    SerializeDeserializeBinaryTree codec = new SerializeDeserializeBinaryTree();
    TreeNode root = new TreeNode(1);
    root.left = new TreeNode(2);
    root.right = new TreeNode(3);
    root.right.left = new TreeNode(4);
    root.right.right = new TreeNode(5);

    string serialized = codec.serialize(root);
    Assert.Equal("1,2,X,X,3,4,X,X,5,X,X,", serialized);

    TreeNode deserializedRoot = codec.deserialize(serialized);
    Assert.Equal(1, deserializedRoot.val);
    Assert.Equal(2, deserializedRoot.left.val);
    Assert.Equal(3, deserializedRoot.right.val);
    Assert.Equal(4, deserializedRoot.right.left.val);
    Assert.Equal(5, deserializedRoot.right.right.val);
}