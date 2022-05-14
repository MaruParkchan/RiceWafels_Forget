using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomItem : MonoBehaviour {

    private SpriteRenderer spriteRender;
    public Sprite[] sprite;

    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRender.sprite = sprite[DataController.itemNumber];
    }

}
