using TMPro;
using UnityEngine;

public class DisplayInitiativeOrder : MonoBehaviour
{
  [SerializeField] private GameObject initiativeCardPrefab;

  private void Start()
  {
    ClearDisplay();

    for (var i = 0; i < CombatManager.Combatants.Count; i++)
    {
      GameObject initiativeCard = Instantiate(initiativeCardPrefab, transform);

      TextMeshProUGUI[] textComponents = initiativeCard.GetComponentsInChildren<TextMeshProUGUI>();
      TextMeshProUGUI combatantName = textComponents[0];
      TextMeshProUGUI order = textComponents[1];

      combatantName.text = CombatManager.Combatants[i].Name;
      order.text = (i + 1).ToString();
    }
  }

  private void ClearDisplay()
  {
    foreach (Transform child in transform)
    {
      Destroy(child.gameObject);
    }
  }
}
