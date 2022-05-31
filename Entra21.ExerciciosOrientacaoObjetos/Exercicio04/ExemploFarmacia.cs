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

            farmacia.Categoria[1] = "Curativos";
            farmacia.Categoria[2] = "Remedios";
            farmacia.Categoria[3] = "Perfumes";

            farmacia.NomeProduto[1] = "Bandaid";
            farmacia.CategoriaProduto[1] = farmacia.Categoria[1];
            farmacia.PrecoProduto[1] = 4.99;
            farmacia.NomeProduto[2] = "DorFlex";
            farmacia.CategoriaProduto[2] = farmacia.Categoria[2];
            farmacia.PrecoProduto[2] = 12.90;
            farmacia.NomeProduto[3] = "Paracetamol";
            farmacia.CategoriaProduto[3] = farmacia.Categoria[2];
            farmacia.PrecoProduto[3] = 10.89;


        }
    }
}
