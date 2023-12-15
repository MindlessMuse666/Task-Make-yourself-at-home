using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
     [SerializeField] private Shelf[] _shelfs;

    private void Awake()
    {
        foreach (var shelf in _shelfs)
        {
            shelf.ItemSpawned += CheckShelfItemsCount;
        }
    }

    private void CheckShelfItemsCount()
    {
        foreach (var shelf in _shelfs)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }
        }
    }
}