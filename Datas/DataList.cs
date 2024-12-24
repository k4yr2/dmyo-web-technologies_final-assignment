using muhammedkayraozkaya_241103046.Models;
using System.Reflection;

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

        /// <summary>
        /// Remove specified id
        /// </summary> 
        public bool Remove(int id, out TModel? model)
        {
            return cache.Remove(id, out model);
        }

        /// <summary>
        /// Model with specified id
        /// </summary>
        public TModel? Model(int id)
        {
            cache.TryGetValue(id, out TModel? model);
            return model;
        }

        /// <summary>
        /// Pool containing models
        /// </summary>
        public IEnumerable<TModel> Models()
        {
            return cache.Values;
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