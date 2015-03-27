
namespace Task01_School_classes.Interfaces
{
    using System.Collections.Generic;

    public interface IComments
    {
        List<string> Comments { get; set; }
        void AddComment(string comment);
    }
}
