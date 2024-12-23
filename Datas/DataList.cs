using muhammedkayraozkaya_241103046.Models;

namespace muhammedkayraozkaya_241103046.Datas
{
    public class DataList<TModel> where TModel : BaseModel
    {
        readonly Dictionary<int, TModel> cache = new();

        /// <summary>
        /// Pool containing models
        /// </summary>
        public IEnumerable<TModel> Models
        {
            get
            {
                return cache.Values;
            }
        }

        /// <summary>
        /// Append model with its unique id
        /// </summary>
        public bool Append(TModel model)
        {
            ArgumentNullException.ThrowIfNull(model, nameof(model));
            return cache.TryAdd(model.Id, model);
        }

        /// <summary>
        /// Model with specified id
        /// </summary>
        public bool Model(int id, out TModel? model)
        {
            return cache.TryGetValue(id, out model);
        }

        /// <summary>
        /// Remove specified id
        /// </summary> 
        public bool Remove(int id, out TModel? model)
        {
            return cache.Remove(id, out model);
        }

        /// <summary>
        /// Shuffle all elements in the pool
        /// </summary>
        public void Shuffle()
        {
            TModel[] models = Models.ToArray();
            cache.Clear();

            Random rng = new();
            TModel[] shuffled = [..models.OrderBy(c => rng.Next(models.Length * 10))];

            foreach (var item in shuffled)
                cache.Add(item.Id, item);
        }
    }
}