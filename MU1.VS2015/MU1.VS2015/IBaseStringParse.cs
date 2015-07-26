using System.Threading.Tasks;

namespace MU1.VS2015
{
    public interface IBaseStringParse
    {
        string StringToParse { get; set; }

        Task<string> GetStringValue();

        bool HasBooleanValue();
    }
}