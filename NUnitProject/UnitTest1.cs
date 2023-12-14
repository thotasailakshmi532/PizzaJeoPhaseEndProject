using Microsoft.AspNetCore.Mvc;
using PizzaJeoPhaseEndProject.Pages;

namespace NUnitProject
{
    public class Tests
    {
        [TestFixture]
        public class PizzaOrderTests
        {
            [Test]
            public void PizzaSelectionPage_ShouldReturnPageResult()
            {
                // Arrange
                var pizzaPageModel = new PizzaModel();

                // Act
                var result = pizzaPageModel.OnPostAddToCart();

                // Assert
                Assert.IsInstanceOf<RedirectToPageResult>(result);
                var redirectResult = (RedirectToPageResult)result;
                Assert.AreEqual("OrderCheckout", redirectResult.PageName);
            }

            [Test]
            public void OrderCheckoutPage_ShouldReturnPageResult()
            {
                // Arrange
                var orderCheckoutModel = new OrderCheckoutModel
                {
                    SelectedPizza = "Pepperoni",
                    Quantity = 2
                };

                // Act
                var result = orderCheckoutModel.OnPostPlaceOrder();

                // Assert
                Assert.IsInstanceOf<RedirectToPageResult>(result);
                var redirectResult = (RedirectToPageResult)result;
                Assert.AreEqual("OrderConfirmation", redirectResult.PageName);
            }

            // Add more test methods as needed to cover different scenarios
        }

    }
}