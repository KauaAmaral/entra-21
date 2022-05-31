using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class ExemploFarmacia
    {
        public void Executar()
        {
            var farmacia = new Farmacia();
            farmacia.RazaoSocial = "Farmacia Popular";
            farmacia.Cnpj = "12.345.678/0001-90";

            farmacia.Categoria[0] = "Curativos";
            farmacia.Categoria[1] = "Remedios";
            farmacia.Categoria[2] = "Perfumes";

            farmacia.NomeProduto[0] = "Bandaid";
            farmacia.CategoriaProduto[0] = farmacia.Categoria[0];
            farmacia.PrecoProduto[0] = 4.99;
            farmacia.NomeProduto[1] = "DorFlex";
            farmacia.CategoriaProduto[1] = farmacia.Categoria[1];
            farmacia.PrecoProduto[1] = 12.90;
            farmacia.NomeProduto[2] = "Paracetamol";
            farmacia.CategoriaProduto[2] = farmacia.Categoria[2];
            farmacia.PrecoProduto[2] = 10.89;


        }
    }
}
