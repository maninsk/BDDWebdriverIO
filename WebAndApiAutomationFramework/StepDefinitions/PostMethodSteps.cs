
using TechTalk.SpecFlow;

namespace WebAndApiAutomationFramework.StepDefinitions
{
    using System;
    using System.Drawing;
    using System.Net.Mime;
    using Newtonsoft.Json.Linq;
    using NUnit.Framework;
    using TechTalk.SpecFlow;
    using WebAndApiAutomationFramework.PageObjects;

    [Binding]
    public class PostMethodSteps
    {   

        [Given(@"the user gives pet data")]
        public void TheUserGivesPetData()
        {
            //storing the base uri
            //RestAssured.baseURI = "https://petstore.swagger.io/#/pet/addPet";
            //storing the json payload in the string
            String requestBody = "";

        }

        [When(@"user adds on pet information")]
        public void UserAddsOnPetInformation()
        {
            // See below we have called the post method in when section which accepts the endpoint as parameter and in the given section we need to provide the json payload in the body method
            //Response res = given().contentType(ContentType.JSON).
           // body(requestBody).
            //when().
            //post("api/login").
            //then().log().all()
            //    .extract().
            //response();
        }


        [Then(@"sucessful response should be received")]
        public void SucessfulResponseShouldBeReceived()
        {
            //applying assertion on response code
            //Assert.assertEquals(201, response.getStatusCode());
        }

        [Then(@"the pet data should be added")]
        public void ThePetDataShouldBeAdded()
        {
           
        }
    }
}
