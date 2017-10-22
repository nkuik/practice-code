using System;
using Xunit;
using DataStructure;

namespace Test
{
    public class CustomLinkedListTest
    {
        private readonly CustomLinkedList _noInitialValue;
        private readonly CustomLinkedList _hasInitialValue;

        public CustomLinkedListTest()
        {
            _noInitialValue = new DataStructure.CustomLinkedList();            
            _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
        }

        [Fact]
        public void ReturnTrue()
        {
            Assert.NotNull(_noInitialValue);
        }

        [Fact]
        public void AddFunction()
        {
            _noInitialValue.Add("hello");
            Assert.Equal(_noInitialValue.Length(), 1);
        }

        [Fact]
        public void AddsNodeOnInstantiation()
        {
            Assert.Equal(_hasInitialValue.Length(), 1);
        }

        [Fact]
        public void AddsSecondNode()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("World");
            Assert.Equal(_hasInitialValue.Length(), 2);
        }

        [Fact]
        public void Length()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("World");
            _hasInitialValue.Add("My");
            _hasInitialValue.Add("Name");
            _hasInitialValue.Add("Is");
            _hasInitialValue.Add("Hal");
            Assert.Equal(_hasInitialValue.Length(), 6);
        }

        [Fact]
        public void GetReturnsCorrectNode()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("World");
            _hasInitialValue.Add("What");
            var value = _hasInitialValue.Get(1);
            Assert.Equal(value, "World");
        }
    }
}