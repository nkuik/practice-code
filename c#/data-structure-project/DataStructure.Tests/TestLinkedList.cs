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
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            Assert.Equal(_hasInitialValue.Length(), 1);
        }
    }
}