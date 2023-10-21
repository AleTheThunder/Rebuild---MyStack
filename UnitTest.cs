using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using NUnit.Framework;

namespace MyStack_Donner
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void Push_Pop()
        {
            // Arrange
            MeineStack<int> stack = new MeineStack<int>();
            stack.Push(1);

            // Act
            int result = stack.Pop();

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Peek()
        {
            // Arrange
            MeineStack<int> stack = new MeineStack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            int result1 = stack.Peek();
            int result2 = stack.Peek();

            // Assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(2, result2);
        }

        [Test]
        public void IsEmpty()
        {
            // Arrange
            MeineStack<int> stack = new MeineStack<int>();

            // Act & Assert
            Assert.IsTrue(stack.IsEmpty);

            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty);

            stack.Pop();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            // Arrange
            MeineStack<int> stack = new MeineStack<int>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Peek_EmptyStack_ThrowsException()
        {
            // Arrange
            MeineStack<int> stack = new MeineStack<int>();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }
    }
}
