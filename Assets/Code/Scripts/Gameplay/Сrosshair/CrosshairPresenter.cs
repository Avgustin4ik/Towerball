namespace Code.Scripts.Gameplay.Сrosshair
{
    using Abstract;
    using Unity.Mathematics;

    public class CrosshairPresenter : Presenter<CrosshairModel>, ICrosshair
    {
        public CrosshairPresenter(CrosshairModel model) : base(model)
        {
        }
        public override void InitializeAndSubscribe()
        {
            base.InitializeAndSubscribe();
        }

        public void Move(float2 position) => Model.Position = position;
        public void FixPosition(bool isFixed) => Model.IsPositionFixed = isFixed;
     
        public float2 Position => Model.Position;
        public bool IsPositionFixed => Model.IsPositionFixed;
    }
}