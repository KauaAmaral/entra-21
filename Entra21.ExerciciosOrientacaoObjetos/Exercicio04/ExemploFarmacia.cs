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
            
            farmacia.Categoria1 = "Curativos";
            farmacia.Categoria2 = "Remedios";
            farmacia.Categoria3 = "Perfumes";
            
            farmacia.NomeProduto1 = "Bandaid";
            farmacia.CategoriaProduto1 = farmacia.Categoria1;
            farmacia.PrecoProduto1 = 4.99;
            farmacia.NomeProduto2 = "DorFlex";
            farmacia.CategoriaProduto2 = farmacia.Categoria2;
            farmacia.PrecoProduto2 = 12.90;
            farmacia.NomeProduto3 = "Paracetamol";
            farmacia.CategoriaProduto3 = farmacia.Categoria2;
            farmacia.PrecoProduto3 = 10.89;


        }
    }
}
