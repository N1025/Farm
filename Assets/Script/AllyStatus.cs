using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[CreateAssetMenu(fileName = "AllyStatus",menuName ="CreateAllyStatus")]
public class AllyStatus : CharaStatus
{
    //装備している武器
    [SerializeField]
    private Item equipWeapon = null;
    //装備しているおまもり
    [SerializeField]
    private Item equipAmulet = null;
    //アイテムと個数のディクショナリー
    [SerializeField]
    private ItemDictionary itemDictionary = null;

    public void SetEquipWeapon(Item weaponItem)
    {
        this.equipWeapon = weaponItem;
    }

    public Item GetEquipWeapon()
    {
        return equipWeapon;
    }

    public void SetEquipAmulet(Item amuletItem)
    {
        this.equipWeapon = amuletItem;
    }

    public Item GetEquipAmulet()
    {
        return equipAmulet;
    }

    public void CreateItemDictionary(ItemDictionary itemDictionary)
    {
        this.itemDictionary = itemDictionary;
    }

    public void SetItemDictionary(Item item,int num = 0)
    {
        itemDictionary.Add(item,num);
    }

    //アイテムが登録された順番のItemDictionaryを返す
    public ItemDictionary GetItemDictionary()
    {
        return itemDictionary;
    }
    //ひらがなの名前でソートしたItemDidtionaryを返す
    public IOrderedEnumerable<KeyValuePair<Item,int>> GetSortItemDictionary()
    {
        return itemDictionary.OrderBy(item => item.Key.GetHiraganaName());
    }
    public int SetItemNum(Item tempItem,int num)
    {
        return itemDictionary[tempItem] = num;
    }
    //アイテムの数を返す
    public int GetItemNum(Item item)
    {
        return itemDictionary[item];
    }
}
