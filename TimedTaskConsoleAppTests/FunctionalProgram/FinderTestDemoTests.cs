using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram.Tests
{
    [TestClass()]
    public class WordFinderTests
    {
        [TestMethod()]
        public void Should_find_a_word()
        {
            //Arrange
            var article = new Article()
            {
                Title = "this is a title",
                Content = "this is content",
                Comment = "this is comment",
                Author = "this is author"
            };

            //Act
            var result = WordFinder<Article>.For(article)
                .Find(x => x.Title)
                .Find(x => x.Content)
                .Find(x => x.Comment)
                .Find(x => x.Author)
                .Execute("content");
            //Console.WriteLine("\nWhat is your name? ");
            //Console.WriteLine(result);
            //Console.ReadKey();
            Assert.IsTrue(result);
        }
    }
}