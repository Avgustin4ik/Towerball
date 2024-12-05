namespace Code.Scripts.Gameplay.Abstract
{
    using System;

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
        
        public virtual void Unsubscribe()
        {
            //отписка изменения модели
        }
        
        public virtual void Destroy()
        {
            Unsubscribe();
            //отписка изменения модели
        }
        
        ~Presenter()
        {
            Destroy();
        }
    }
}