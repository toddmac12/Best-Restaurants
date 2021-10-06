// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using BestRestaurants.Models;
// using System.Collections.Generic;
// using System;

// namespace BestRestaurants.Tests
// {
//   [TestClass]
//   public class CuisinesTests : IDisposable
//   {

//     public void Dispose()
//     {
//       Cuisines.ClearAll();
//     }

//     [TestMethod]
//     public void CuisinesConstructor_CreatesInstanceOfCuisines_Cuisines()
//     {
//       Cuisines newCuisines = new Cuisines("test Cuisines");
//       Assert.AreEqual(typeof(Cuisines), newCuisines.GetType());
//     }

//     [TestMethod]
//     public void GetName_ReturnsName_String()
//     {
//       //Arrange
//       string name = "Test Cuisines";
//       Cuisines newCuisines = new Cuisines(name);

//       //Act
//       string result = newCuisines.Name;

//       //Assert
//       Assert.AreEqual(name, result);
//     }

//     [TestMethod]
//     public void GetId_ReturnsCuisinesId_Int()
//     {
//       //Arrange
//       string name = "Test Cuisines";
//       Cuisines newCuisines = new Cuisines(name);

//       //Act
//       int result = newCuisines.Id;

//       //Assert
//       Assert.AreEqual(1, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsAllCuisinesObjects_CuisinesList()
//     {
//       //Arrange
//       string name01 = "Work";
//       string name02 = "School";
//       Cuisines newCuisines1 = new Cuisines(name01);
//       Cuisines newCuisines2 = new Cuisines(name02);
//       List<Cuisines> newList = new List<Cuisines> { newCuisines1, newCuisines2 };

//       //Act
//       List<Cuisines> result = Cuisines.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectCuisines_Cuisines()
//     {
//       //Arrange
//       string name01 = "Work";
//       string name02 = "School";
//       Cuisines newCuisines1 = new Cuisines(name01);
//       Cuisines newCuisines2 = new Cuisines(name02);

//       //Act
//       Cuisines result = Cuisines.Find(2);

//       //Assert
//       Assert.AreEqual(newCuisines2, result);
//     }

//     [TestMethod]
//     public void AddRestaurant_AssociatesRestaurantWithCuisines_RestaurantList()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Restaurant newRestaurant = new Restaurant(description);
//       List<Restaurant> newList = new List<Restaurant> { newRestaurant };
//       string name = "Work";
//       Cuisines newCuisines = new Cuisines(name);
//       newCuisines.AddRestaurant(newRestaurant);

//       //Act
//       List<Restaurant> result = newCuisines.Restaurants;

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }
    
//   }
// }