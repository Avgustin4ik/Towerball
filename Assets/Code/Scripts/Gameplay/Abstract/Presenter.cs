namespace Code.Scripts.Gameplay.Abstract
{
    public class Presenter<TModel> where TModel : IModel
    {
        protected readonly TModel Model;
        public Presenter(TModel model)
        {
            Model = model;
        }
        
        public virtual void InitializeAndSubscribe()
        {
            //подписка изменения модели
        }
    }
}