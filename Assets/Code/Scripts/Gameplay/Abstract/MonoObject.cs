namespace Code.Scripts.Gameplay.Abstract
{
    public abstract class MonoObject<TPresenter> : UnityEngine.MonoBehaviour
    {
        private TPresenter _presenter;
        public TPresenter Presenter => _presenter;
        //инжектируем "конструктор"
        public virtual void Initialize(TPresenter presenter)
        {
            _presenter = presenter; 
        }
        
    }
}