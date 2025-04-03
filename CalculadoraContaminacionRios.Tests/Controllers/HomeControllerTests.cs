using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using CalculadoraContaminacionRios.Controllers;
using CalculadoraContaminacionRios.Models;

namespace CalculadoraContaminacionRios.Tests.Controllers
{
    public class HomeControllerTests
    {
        private readonly HomeController _controller;

        public HomeControllerTests()
        {
            _controller = new HomeController();
        }

        [Fact]
        public void Index_ReturnsViewResult()
        {
            // Act
            var result = _controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
        }

        [Fact]
        public void Resultados_ReturnsViewResult_WithValidModel()
        {
            // Arrange
            var model = new ContaminacionModel
            {
                Concentracion = 10,
                Velocidad = 5,
                LimiteInferior = 0,
                LimiteSuperior = 10
            };

            // Act
            var result = _controller.Resultados(model);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult);
            Assert.Equal(model, viewResult.Model);
        }

        [Fact]
        public void Resultados_ReturnsViewResult_WithInvalidModel()
        {
            // Arrange
            _controller.ModelState.AddModelError("Concentracion", "Required");

            // Act
            var result = _controller.Resultados(new ContaminacionModel());

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.True(viewResult.ViewData.ModelState.IsValid == false);
        }

        [Fact]
        public void Calcular_InvalidModel_ReturnsIndexView()
        {
            // Arrange
            var controller = new HomeController();
            controller.ModelState.AddModelError("Concentracion", "La concentración es obligatoria.");

            var model = new ContaminacionModel();

            // Act
            var result = controller.Calcular(model) as ViewResult;

            // Assert
            Assert.Equal("Index", result.ViewName);
        }
    }
}