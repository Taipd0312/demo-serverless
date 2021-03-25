using AWSServerless.Models;
using System.Collections.Generic;

namespace AWSServerless.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemsToShoppingList(ShoppingListModel shoppingListModel);
        void RemoveItem(string name);
    }
}