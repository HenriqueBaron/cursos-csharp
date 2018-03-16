using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CovarianciaContravariancia
{
    /// <summary>
    /// Interface que permite contravariância, ou seja, conversão de um tipo genérico para um tipo específico.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IArmazenavel<in T>
    {
        void Armazenar(T item);
    }
}
