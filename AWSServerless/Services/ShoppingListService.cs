using AWSServerless.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerless.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();

        public void AddItemsToShoppingList(ShoppingListModel shoppingListModel)
        {
            _shoppingListStorage.Add(shoppingListModel.Name, shoppingListModel.Quantity);
        }

        public Dictionary<string, int> GetItemsFromShoppingList()
        {
            return _shoppingListStorage;
        }

        public void RemoveItem(string name)
        {
            _shoppingListStorage.Remove(name);
        }
    }
}
