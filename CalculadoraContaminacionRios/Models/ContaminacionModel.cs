using System;
using System.ComponentModel.DataAnnotations;

namespace CalculadoraContaminacionRios.Models
{
    /// <summary>
    /// Representa el modelo de datos para los cálculos de contaminación en ríos.
    /// </summary>
    public class ContaminacionModel
    {
        /// <summary>
        /// Obtiene o establece la concentración del contaminante en el río.
        /// </summary>
        [Required(ErrorMessage = "La concentración es obligatoria.")]
        [Range(0, double.MaxValue, ErrorMessage = "La concentración debe ser un valor positivo.")]
        public double Concentracion { get; set; }

        /// <summary>
        /// Obtiene o establece la velocidad del río.
        /// </summary>
        [Required(ErrorMessage = "La velocidad es obligatoria.")]
        [Range(0, double.MaxValue, ErrorMessage = "La velocidad debe ser un valor positivo.")]
        public double Velocidad { get; set; }

        /// <summary>
        /// Obtiene o establece el límite inferior del tramo a calcular.
        /// </summary>
        [Required(ErrorMessage = "El límite inferior es obligatorio.")]
        public double LimiteInferior { get; set; }

        /// <summary>
        /// Obtiene o establece el límite superior del tramo a calcular.
        /// </summary>
        [Required(ErrorMessage = "El límite superior es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El límite superior debe ser mayor o igual al límite inferior.")]
        public double LimiteSuperior { get; set; }
    }
}