﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public Abstraccion(IBridge pImp, Dictionary<string, double> pProd)
        {
            implementacion = pImp;
            productos = pProd;
        }
        public Abstraccion(int pTipo, Dictionary<string, double> pProd)
        {
            if (pTipo == 1)
            {
                implementacion = new Implementacion();
            }
            if (pTipo == 2)
            {
                implementacion = new Implementacion2();
            }
            if (pTipo == 3)
            {
                implementacion = new Implementacion3();
            }
            productos = pProd;
        }
        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }
        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
