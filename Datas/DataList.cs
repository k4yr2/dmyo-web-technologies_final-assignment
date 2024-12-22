using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Datas
{
    public class DataList<TModel> where TModel : BaseModel
    {
        readonly Dictionary<int, TModel> cache = new();

        /// <summary>
        /// Append model with its unique id
        /// </summary>
        public bool Append(TModel model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));
            return cache.TryAdd(model.Id, model);
        }
    }
}
