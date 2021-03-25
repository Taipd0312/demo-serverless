using AWSServerless.Models;
using AWSServerless.Services;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }
        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingListModel)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingListModel);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleItemsFromShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);

            return Ok();
        }
    }
}
