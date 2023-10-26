using UnityEngine;

namespace eWolf.CodeExamples.EnumnAttributes
{
    public class ShowEnumData : MonoBehaviour
    {
        public PickupItems PickupItems = PickupItems.None;

        public void ShowAttributeData()
        {
            string title = EnumHelper.GetEnumTitle(PickupItems);
            string description = EnumHelper.GetEnumDescription(PickupItems);

            Debug.Log($"TITLE:{title}");
            Debug.Log($"TEXT:{description}");
        }
    }
}