using UnityEngine;

namespace Views
{
    internal class UIHeroEventTrigger:MonoBehaviour
    {
        private UIHeroSelector _heroSelector;
        [SerializeField] private UICell _cell;
        private void Start()
        {
            _heroSelector = FindObjectOfType<UIHeroSelector>();
        }
        public void OnClick()
        {
            _heroSelector.OnHeroClicked(_cell.Coord);
        }

    }
}
