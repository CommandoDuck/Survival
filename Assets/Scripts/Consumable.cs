using UnityEngine;
using System.Collections;
using System;

public class Consumable : Item
{
    private Type[] itemTypes;

    public int health { get; set; }
    public int mana { get; set; }

    public Consumable()
    { }

    public Consumable(string itemName, string description, int maxsize, ItemType type, string sprite, int health, int mana) : base (itemName, description, maxsize, type, sprite)
    {
        this.health = health;
        this.mana = mana;
    }

    public Consumable(string itemName, string description, Type[] itemTypes, string sprite, int health, int mana)
    {
        this.itemName = itemName;
        this.description = description;
        this.itemTypes = itemTypes;
        this.sprite = sprite;
        this.health = health;
        this.mana = mana;
    }

    public override void Use()
    {
        
    }

    public override string GetTooltip()
    {
        return base.GetTooltip();
    }
}
