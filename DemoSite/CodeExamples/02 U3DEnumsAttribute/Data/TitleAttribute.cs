using System;

namespace eWolf.CodeExamples.EnumnAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class TitleAttribute : Attribute
    {
        public TitleAttribute(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
    }
}