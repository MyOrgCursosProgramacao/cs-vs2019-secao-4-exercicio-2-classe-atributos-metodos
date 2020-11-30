using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src
{
    class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = (1.0 + porcentagem / 100.0) * SalarioBruto;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
