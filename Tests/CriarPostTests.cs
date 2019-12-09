using jsonplaceholder.Requests;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using jsonplaceholder.Bases;
using jsonplaceholder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;

namespace jsonplaceholder.Tests
{
    [TestFixture]
    public class CriarPostTests : TestBase
    {
        [Test]
        public void TesteMetodoPost()
        {

            #region Parameters
            string title = "Teste 'POST' adicionando User";
            string body = "Testando....";
            string userId = "1";

            //Resultado esperado
            string statusCodeEsperado = "Created";

            #endregion

            CriarPostRequest criarPostRequest = new CriarPostRequest();
            criarPostRequest.setJsonBody(title, body, userId);
                       
            IRestResponse<dynamic> response = criarPostRequest.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreEqual(title, response.Data.title.ToString());
                Assert.AreEqual(body, response.Data.body.ToString());
                Assert.AreEqual(userId, response.Data.userId.ToString());
                                
            });
        }

    }
}