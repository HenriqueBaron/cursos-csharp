using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CovarianciaContravariancia
{
    /// <summary>
    /// Interface que permite covariância, ou seja,conversão de um tipo específico para um tipo genérico.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IRecuperavel<out T>
    {
        T Recuperar(int codigo);
    }
}
