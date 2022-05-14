using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBuy : MonoBehaviour {

    [SerializeField] private int itemNumber;

	public void ItemChange()
    {
        DataController.itemNumber = itemNumber;
    }
}
