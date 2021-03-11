using System;
using AmazonBookstore.Models;
using Microsoft.AspNetCore.Mvc;

//Define the view component

namespace AmazonBookstore.Components
{
    public class CartSummaryViewComponent: ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
