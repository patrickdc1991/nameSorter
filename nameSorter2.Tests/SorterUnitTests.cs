using System;
using System.Collections.Generic;
using Xunit;

namespace nameSorter2.Tests
{
    public class SorterUnitTests
    {
        [Fact]
        public void SimpleSort()
        {
            List<string> nameList = new() { "aaa zzz", "bbb ccc yyy", "ddd xxx", "eee www" };
            List<string> expected = new() { "eee www", "ddd xxx", "bbb ccc yyy", "aaa zzz" };
            Utils.NameSort(nameList);
            Assert.Equal(expected, nameList);
        }

        [Fact]
        public void LastNamesOnly()
        {
            List<string> nameList = new() { "zzz", "yyy", "xxx", "www" };
            List<string> expected = new() { "www", "xxx", "yyy", "zzz" };
            Utils.NameSort(nameList);
            Assert.Equal(expected, nameList);
        }

        [Fact]
        public void MixSingleNamesAndFullNames()
        {
            List<string> nameList = new() { "aaa zzz", "yyy", "ccc xxx", "www" };
            List<string> expected = new() { "www", "ccc xxx", "yyy", "aaa zzz" };
            Utils.NameSort(nameList);
            Assert.Equal(expected, nameList);
        }

        [Fact]
        public void HyphenatedNames()
        {
            List<string> nameList = new() { "aaa z-aaaa", "yyy", "ccc xxx", "www" };
            List<string> expected = new() { "www", "ccc xxx", "yyy", "aaa z-aaaa" };
            Utils.NameSort(nameList);
            Assert.Equal(expected, nameList);
        }

        [Fact]
        public void EmptyList()
        {
            List<string> nameList = new();
            List<string> expected = new();
            Utils.NameSort(nameList);
            Assert.Equal(expected, nameList);
        }
    }
}
