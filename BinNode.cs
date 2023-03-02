using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
	class BinNode<T>
	{
		private BinNode<T> left;
		private T value;
		private BinNode<T> right;
		public BinNode(T value)
		{
			this.value = value;
			this.left = null;
			this.right = null;
		}
		public BinNode(BinNode<T> left, T value, BinNode<T> right)
		{
			this.value = value;
			this.left = left;
			this.right = right;
		}
		public T GetValue() { return this.value; }
		public BinNode<T> GetLeft() { return this.left; }
		public BinNode<T> GetRight() { return this.right; }
		public bool HasLeft() { return this.left != null; }
		public bool HasRight() { return this.right != null; }
		public void SetValue(T value) { this.value = value; }
		public void SetLeft(BinNode<T> left)
		{
			if (left == null) { left = null; return; }
			this.left = new BinNode<T>(left.value);
			this.left.SetLeft(left.left);
			this.left.SetRight(left.right);
		}
		public void SetRight(BinNode<T> right)
		{
			if (right == null) { right = null; return; }
			this.right = new BinNode<T>(right.value);
			this.right.SetLeft(right.left);
			this.right.SetRight(right.right);
		}
		public override string ToString()
        {
            return $"Root Value: {this.value}";
        }
    }
}
