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
            var value = _hasInitialValue.Get(0);
            Assert.Equal(value, "Hello");
        }
        
        [Fact]
        public void InsertFunctionWorks()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Insert("World", 1);
            Assert.Equal(_hasInitialValue.Length(), 2);
        }
        
        [Fact]
        public void GetWorksAfterInsert()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("My");
            _hasInitialValue.Insert("World", 1);
            _hasInitialValue.Add("Is");
            _hasInitialValue.Insert("Name", 3);
            Assert.Equal(_hasInitialValue.Get(1), "World");
            Assert.Equal(_hasInitialValue.Get(3), "Name");
        }
        
        [Fact]
        public void RemovalTests()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("World");
            _hasInitialValue.Add("My");
            _hasInitialValue.Add("Name");
            _hasInitialValue.Add("Is");
            _hasInitialValue.Add("Hal");
            _hasInitialValue.Remove(2);
            Assert.Equal(_hasInitialValue.Length(), 5);
        }

        [Fact]
        public void GetWorksAfterRemovalTests()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("World");
            _hasInitialValue.Add("My");
            _hasInitialValue.Add("Name");
            _hasInitialValue.Add("Is");
            _hasInitialValue.Add("Hal");
            _hasInitialValue.Remove(2);
            Assert.Equal(_hasInitialValue.Get(2), "Name");
        }

        [Fact]
        public void TestSearch()
        {
            var _hasInitialValue = new DataStructure.CustomLinkedList("Hello");            
            _hasInitialValue.Add("World");
            _hasInitialValue.Add("My");
            _hasInitialValue.Add("Name");
            _hasInitialValue.Add("Is");
            _hasInitialValue.Add("Hal");
            Assert.Equal(_hasInitialValue.Search("My"), 2);
            Assert.Equal(_hasInitialValue.Search("Hal"), 5);
        }
    }
}