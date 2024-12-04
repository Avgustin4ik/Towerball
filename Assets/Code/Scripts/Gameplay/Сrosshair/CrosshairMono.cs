namespace Code.Scripts.Gameplay.Сrosshair
{
    using UnityEngine;

    public class CrosshairMono : MonoBehaviour
    {
        private ICrosshair _crosshair;
        
        //инжектируем "конструктор"
        public void Initialize(ICrosshair crosshair)
        {
            _crosshair = crosshair;
        }
        
        //в тике обновляем позицию курсора
        //если позиция фиксирована, то не обновляем
        
        //при клике на мышь пытаемся зафиксировать позицию
        //если позиция уже фиксирована, то снимаем фиксацию - это дебаг
    }
}