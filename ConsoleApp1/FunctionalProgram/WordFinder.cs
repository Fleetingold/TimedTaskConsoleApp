using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgram
{
    public class WordFinder<TModel>
    {
        private readonly List<Func<string, bool>> _conditions;
        private static TModel _model;
        public WordFinder(){
            _conditions = new List<Func<string, bool>>();
        }
        public static WordFinder<TModel> For(TModel model) {
            _model = model;
            return new WordFinder<TModel>();
        }

        public WordFinder<TModel> Find<TProperty>(Func<TModel, TProperty> expression)
        {
            Func<string, bool> searchCondition = word => expression(_model).ToString().Split(' ').Contains(word);
            _conditions.Add(searchCondition);
            return this;
        }

        public bool Execute(string wordList)
        {
            return _conditions.Any(x=>x(wordList));
        }

    }

   public  class FinderTestDemo {
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
        }
    }

    public class Article
    {
        public Article()
        {
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Comment { get; set; }
        public string Author { get; set; }
    }

}