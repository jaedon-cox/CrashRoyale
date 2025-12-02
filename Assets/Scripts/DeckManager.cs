using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public Transform[] deckSlots;        // Assign 3 deck slots in inspector
    public GameObject[] cardPrefabs;     // All card prefabs, index = cardID

    private void Start()
    {
        LoadDeck();
    }

    public void LoadDeck()
    {
        for (int i = 0; i < deckSlots.Length; i++)
        {
            // Remove any existing card in the slot
            if (deckSlots[i].childCount > 0)
                Destroy(deckSlots[i].GetChild(0).gameObject);

            if (PlayerPrefs.HasKey("DeckSlot_" + i))
            {
                int savedCardID = PlayerPrefs.GetInt("DeckSlot_" + i);

                if (savedCardID >= 0 && savedCardID < cardPrefabs.Length)
                {
                    GameObject card = Instantiate(cardPrefabs[savedCardID], deckSlots[i]);
                    DraggableItem item = card.GetComponent<DraggableItem>();
                    item.cardID = savedCardID;

                    Debug.Log("Loaded card " + savedCardID + " into slot " + i);
                }
            }
        }
    }

    // Call this from a UI button to clear the deck
    public void ClearDeck()
    {
        for (int i = 0; i < deckSlots.Length; i++)
        {
            // Remove any card currently in the deck slot
            if (deckSlots[i].childCount > 0)
                Destroy(deckSlots[i].GetChild(0).gameObject);

            // Clear saved PlayerPrefs
            PlayerPrefs.DeleteKey("DeckSlot_" + i);
        }

        PlayerPrefs.Save();
        Debug.Log("Deck cleared!");
    }
}
