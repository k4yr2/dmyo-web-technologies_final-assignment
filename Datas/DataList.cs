using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Datas
{
    public class DataList<TModel> where TModel : BaseModel
    {
        readonly Dictionary<int, TModel> cache = new();

    }
}
